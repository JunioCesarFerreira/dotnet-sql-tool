1. SELECT
   Usado para selecionar dados de um banco de dados.
   
   SELECT column1, column2 FROM table_name;
   
   Para selecionar todos os campos de uma tabela, usa-se `*`.
   
   SELECT * FROM table_name;

2. INSERT INTO
   Usado para inserir novos dados em uma tabela.
   
   INSERT INTO table_name (column1, column2) VALUES (value1, value2);

3. UPDATE
   Usado para atualizar dados existentes em uma tabela.
   
   UPDATE table_name SET column1 = value1 WHERE condition;

4. DELETE
   Usado para deletar dados de uma tabela.
   
   DELETE FROM table_name WHERE condition;

5. CREATE DATABASE
   Usado para criar um novo banco de dados.
   
   CREATE DATABASE database_name;

6. DROP DATABASE
   Usado para deletar um banco de dados.
   
   DROP DATABASE database_name;

7. CREATE TABLE
   Usado para criar uma nova tabela.
   
   CREATE TABLE table_name (
       column1 datatype,
       column2 datatype,
       ...
   );

8. DROP TABLE
   Usado para deletar uma tabela.
   
   DROP TABLE table_name;

9. ALTER TABLE
   Usado para adicionar, deletar, ou modificar colunas em uma tabela existente.
   - Adicionar coluna:
     
     ALTER TABLE table_name ADD column_name datatype;
     
   - Deletar coluna:
     
     ALTER TABLE table_name DROP COLUMN column_name;
     
   - Modificar coluna:
     
     ALTER TABLE table_name MODIFY COLUMN column_name datatype;

10. WHERE
    Usado para filtrar registros que satisfazem uma condi��o espec�fica.
    
    SELECT * FROM table_name WHERE condition;

11. ORDER BY
    Usado para ordenar os resultados de uma consulta SQL.
    
    SELECT * FROM table_name ORDER BY column_name ASC|DESC;

12. GROUP BY
    Usado para agrupar linhas que t�m os mesmos valores em colunas espec�ficas.
    
    SELECT column_name, COUNT(*) FROM table_name GROUP BY column_name;