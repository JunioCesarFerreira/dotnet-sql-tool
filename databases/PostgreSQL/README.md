# Guia de Configuração do Container PostgreSQL com Docker

Este guia explica como criar um container Docker para rodar uma instância do banco de dados PostgreSQL utilizando um Dockerfile personalizado, e como executar queries SQL no banco de dados criado.

## Pré-requisitos

- Docker instalado em sua máquina. Se não tiver, você pode baixá-lo do [site oficial do Docker](https://www.docker.com/products/docker-desktop).

## Passos para Criar o Container PostgreSQL

### 1. Preparar o Dockerfile

Crie um arquivo chamado `Dockerfile` no seu diretório de trabalho com o seguinte conteúdo:

```Dockerfile
# Use a imagem oficial do PostgreSQL como base
FROM postgres:latest

# Define variáveis de ambiente para configuração
ENV POSTGRES_DB nome_do_banco
ENV POSTGRES_USER usuario_personalizado
ENV POSTGRES_PASSWORD senha_segura

# (Opcional) Adiciona scripts SQL ou de shell que devem ser executados durante a inicialização do container
COPY ./init-scripts/ /docker-entrypoint-initdb.d/
```

Altere `nome_do_banco`, `usuario_personalizado`, e `senha_segura` conforme desejado.

[Veja o arquivo Dockerfile](Dockerfile).

### 2. (Opcional) Preparar Scripts de Inicialização

Se desejar executar scripts SQL para configuração inicial do seu banco de dados (como criação de tabelas ou inserção de dados), coloque-os em um diretório chamado `init-scripts` no mesmo local que seu Dockerfile.

### 3. Construir a Imagem Docker

No terminal, navegue até o diretório onde o `Dockerfile` está localizado e execute o comando:

```bash
docker build -t postgres_personalizado .
```

Isso irá construir uma nova imagem Docker chamada `postgres_personalizado` baseada nas instruções do seu Dockerfile.

### 4. Iniciar o Container PostgreSQL

Após a construção da imagem, inicie o container com o seguinte comando:

```bash
docker run --name meu_postgres -d -p 5432:5432 postgres_personalizado
```

Isso cria e inicia um container chamado `meu_postgres`, mapeando a porta padrão do PostgreSQL (5432) do container para a mesma porta no host.

## Como Executar Queries SQL no Banco de Dados

### Conectar ao Banco de Dados PostgreSQL

Para executar queries via terminal utilize:

```bash
docker exec -it nome_do_container psql -h localhost -p 5432 -U usuario_personalizado -d nome_do_banco
```

Insira a `senha_segura` quando solicitado.

### Executar Queries SQL

Uma vez conectado, você pode começar a executar suas queries SQL diretamente no terminal. Por exemplo:

```sql
CREATE TABLE exemplo (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);
```

Todo comando SQL deve ser finalizado com `;`.

### (Opcional) Executar Queries Sem Entrar no Container

Você também pode executar queries diretamente do terminal do host sem entrar no container, utilizando:

```bash
docker exec -it nome_do_container psql -U usuario_personalizado -d nome_do_banco -c "SUA_QUERY_SQL_AQUI"
```

Substitua `SUA_QUERY_SQL_AQUI` pela sua consulta SQL real.
