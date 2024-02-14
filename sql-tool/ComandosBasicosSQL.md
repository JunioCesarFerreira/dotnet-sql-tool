
### 1. SELECT
Usado para selecionar dados de um banco de dados.
```sql
SELECT column1, column2 FROM table_name;
```
Para selecionar todos os campos de uma tabela, usa-se `*`.
```sql
SELECT * FROM table_name;
```

### 2. INSERT INTO
Usado para inserir novos dados em uma tabela.
```sql
INSERT INTO table_name (column1, column2) VALUES (value1, value2);
```

### 3. UPDATE
Usado para atualizar dados existentes em uma tabela.
```sql
UPDATE table_name SET column1 = value1 WHERE condition;
```

### 4. DELETE
Usado para deletar dados de uma tabela.
```sql
DELETE FROM table_name WHERE condition;
```

### 5. CREATE DATABASE
Usado para criar um novo banco de dados.
```sql
CREATE DATABASE database_name;
```

### 6. DROP DATABASE
Usado para deletar um banco de dados.
```sql
DROP DATABASE database_name;
```

### 7. CREATE TABLE
Usado para criar uma nova tabela.
```sql
CREATE TABLE table_name (
    column1 datatype,
    column2 datatype,
    ...
);
```

### 8. DROP TABLE
Usado para deletar uma tabela.
```sql
DROP TABLE table_name;
```

### 9. ALTER TABLE
Usado para adicionar, deletar, ou modificar colunas em uma tabela existente.
- Adicionar coluna:
  ```sql
  ALTER TABLE table_name ADD column_name datatype;
  ```
- Deletar coluna:
  ```sql
  ALTER TABLE table_name DROP COLUMN column_name;
  ```
- Modificar coluna:
  ```sql
  ALTER TABLE table_name MODIFY COLUMN column_name datatype;
  ```

### 10. WHERE
Usado para filtrar registros que satisfazem uma condição específica.
```sql
SELECT * FROM table_name WHERE condition;
```

### 11. ORDER BY
Usado para ordenar os resultados de uma consulta SQL.
```sql
SELECT * FROM table_name ORDER BY column_name ASC|DESC;
```

### 12. GROUP BY
Usado para agrupar linhas que têm os mesmos valores em colunas específicas.
```sql
SELECT column_name, COUNT