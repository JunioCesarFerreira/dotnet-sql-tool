# Guia de Configuração do Container MySQL com Docker

Este guia explica como criar um container Docker para rodar uma instância do banco de dados MySQL utilizando um Dockerfile personalizado, e como executar queries SQL no banco de dados criado.

## Pré-requisitos

- Docker instalado em sua máquina. Se não tiver, você pode baixá-lo do [site oficial do Docker](https://www.docker.com/products/docker-desktop).

## Passos para Criar o Container MySQL

### 1. Preparar o Dockerfile

Crie um arquivo chamado `Dockerfile` no seu diretório de trabalho com o seguinte conteúdo:

```Dockerfile
# Usa a imagem oficial do MySQL como base
FROM mysql:latest

# Define variáveis de ambiente para a configuração do MySQL
ENV MYSQL_DATABASE nome_do_banco
ENV MYSQL_USER usuario_personalizado
ENV MYSQL_PASSWORD senha_segura
ENV MYSQL_ROOT_PASSWORD senha_root

# (Opcional) Copia scripts SQL para serem executados durante a inicialização do container
COPY ./init-scripts/ /docker-entrypoint-initdb.d/
```

[Veja o arquivo Dockerfile](Dockerfile).

Substitua `nome_do_banco`, `usuario_personalizado`, `senha_segura`, e `senha_root` conforme desejado.

### 2. (Opcional) Preparar Scripts de Inicialização

Se desejar executar scripts SQL para configuração inicial do seu banco de dados (como criação de tabelas ou inserção de dados), coloque-os em um diretório chamado `init-scripts` no mesmo local que seu Dockerfile.

### 3. Construir a Imagem Docker

No terminal, navegue até o diretório onde o `Dockerfile` está localizado e execute o comando:

```bash
docker build -t mysql_personalizado .
```

Isso irá construir uma nova imagem Docker chamada `mysql_personalizado` baseada nas instruções do seu Dockerfile.

### 4. Iniciar o Container MySQL

Após a construção da imagem, inicie o container com o seguinte comando:

```bash
docker run --name meu_mysql -d -p 3306:3306 mysql_personalizado
```

Isso cria e inicia um container chamado `meu_mysql`, mapeando a porta padrão do MySQL (3306) do container para a mesma porta no host.

## Como Executar Queries SQL no Banco de Dados

### Conectar ao Banco de Dados MySQL

Para executar queries via terminal, utilize:

```bash
docker exec -it nome_do_container mysql -u usuario_personalizado -p --database=nome_do_banco
```

Você será solicitado a inserir a `senha_segura`.

### Executar Queries SQL

Uma vez conectado, você pode começar a executar suas queries SQL diretamente no terminal. Por exemplo:

```sql
CREATE TABLE exemplo (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);
```

Lembre-se de que todo comando SQL deve ser finalizado com `;`.

### (Opcional) Executar Queries Sem Entrar no Container

Você também pode executar queries diretamente do terminal do host sem entrar no container, utilizando:

```bash
docker exec -it nome_do_container mysql -u usuario_personalizado -p --database=nome_do_banco -e "SUA_QUERY_SQL_AQUI"
```

Substitua `SUA_QUERY_SQL_AQUI` pela sua consulta SQL real. Note que a senha (se necessária) pode ser solicitada ou incluída diretamente na linha de comando (não recomendado por motivos de segurança).

---