-- script base de dados empresa_db

--criando base de dados
create database empresa_db;

--mostrando todas as tabelas da base de dados
SELECT name
FROM sys.databases;  

--usando a base de dados empresa_db
use empresa_db;

--criando tabela Departamento
CREATE TABLE Departamento (
  idDepartamento INT NOT NULL,
  nome VARCHAR(45) NOT NULL,
  localizacao VARCHAR(45) NOT NULL,
  orcamento VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (idDepartamento)
);


--criando tabela empregado
CREATE TABLE Empregado (
  idEmpregado INT NOT NULL,
  nome VARCHAR(45) NOT NULL,
  idGerente INT NULL,
  funcao VARCHAR(45) NULL,
  Departamento_idDepartamento INT NOT NULL,
  dataAdmissao DATE NOT NULL,
  salario INT NULL,
  comissao INT NULL,
  
  PRIMARY KEY (idEmpregado, Departamento_idDepartamento),
  INDEX fk_Empregado_Departamento_idx (Departamento_idDepartamento ASC),
  
  CONSTRAINT fk_Empregado_Departamento
    FOREIGN KEY (Departamento_idDepartamento)
    REFERENCES Departamento (idDepartamento)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

--inserindo dados nas tabelas
INSERT INTO Departamento VALUES('1','Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('2','Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('3','Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('4','Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('5','Redes','Taquara','12122');

INSERT INTO Empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('2','Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('9','Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('10','Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('12','Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');


--comandos gerais em SQL

-- Seleção de todos os campos (ou colunas) da tabela de Departamentos.
SELECT  *  
FROM  Departamento;

-- where
--
-- Operadores lógicos
--
-- operador significado
-- =  igual a
-- >  maior que
-- >= maior que ou igual a
-- <  menor que
-- <= menor que ou igual a

SELECT  Empregado.nome, Empregado.funcao
FROM  Empregado
WHERE  Empregado.Departamento_idDepartamento > 3;

SELECT  Empregado.nome, Empregado.funcao
FROM  Empregado
WHERE Empregado.funcao = 'GERENTE';

-- Selecione todos os departamentos cujo orçamento mensal
--seja maior que 10000. Apresente o Nome de tal departamento
--e seu orçamento anual, que será obtido multiplicando-se o
--orçamento mensal por 12.

select Departamento.nome, Departamento.orcamento * 12
from Departamento
where Departamento.orcamento >= 10000;


-- Apresente a instrução anterior porém ao invés dos
--'feios' DepNome e DepOrca, os Títulos Departamento e Orçamento.

SELECT  Departamento.nome 'DEPARTAMENTO', Departamento.orcamento * 12 'ORCAMENTO ANUAL'
FROM  Departamento
WHERE Departamento.orcamento > 5000;


-- Apresente todos os cargos existentes na empresa,
-- porém omita eventuais duplicidades.

select distinct Empregado.funcao
from Empregado;

-- Apresente os nomes e funções da cada funcionário contidos
--na tabela empregado, porém classificados alfabeticamente (A..Z)
--e depois alfabeticamente invertido (Z..A).

select Empregado.nome 'Nome do Empregado', Empregado.funcao 'Cargo'
from Empregado
order by  Empregado.nome;

select Empregado.nome 'Nome do Empregado', Empregado.funcao 'Cargo'
from Empregado
order by  Empregado.nome desc;

-- Demais Operadores
--
--Operador                  significado
--between  ...  and ...     entre dois valores ( inclusive )
--in ( .... )               lista de valores
--like                      com um padrao de caracteres
--is null                   é um valor nulo

SELECT  Empregado.nome, Empregado.salario
FROM  Empregado
WHERE  Empregado.salario BETWEEN  20  AND  30;

SELECT  Empregado.nome,  Empregado.Departamento_idDepartamento
FROM  Empregado
WHERE  Empregado.Departamento_idDepartamento  IN  (3,5);

SELECT  Empregado.nome, Empregado.funcao
FROM  Empregado
WHERE   Empregado.nome  LIKE  'L%';

SELECT Empregado.nome, Empregado.funcao
FROM  Empregado
WHERE  Empregado.comissao  IS  NULL;

-- Operadores Negativos
--
--operador               descrição
--<>                     diferente
--not nome_coluna =      diferente da coluna
--not nome_coluna >      não maior que
--not between            não entre dois valores informados
--not in                 não existente numa dada lista de valores
--not like               diferente do padrao de caracteres informado
--is not null            não é um valor nulo

-- Selecione os Empregados cujos salários sejam
--menores que 1000 ou maiores que 3500.


SELECT Empregado.nome,  Empregado.salario
FROM  Empregado
WHERE  Empregado.salario  NOT  BETWEEN  1000  AND  3500;

-- Apresente todos os funcionários com salários
--entre 3400 e 4000 e que sejam balconistas.

-- Operadores  'AND' (E) e  'OR' (OU).
--
SELECT Empregado.nome, Empregado.salario, Empregado.funcao
FROM  Empregado
WHERE  Empregado.salario  BETWEEN  3400 AND 5000
AND  Empregado.funcao =  'balconista';

-- Apresente todos os funcionários com salários
--entre 3400 e 4000 ou que sejam balconistas.

SELECT Empregado.nome, Empregado.salario, Empregado.funcao
FROM  Empregado
WHERE Empregado.salario  BETWEEN  3400 AND 5000
OR  Empregado.funcao =  'balconista';

-- Apresente o nome de todos os empregados em letras minúsculas.
--------------------------------------------------------------------------------------------------------------------------------------------------------


-- Funções de Caracteres
--Lower - 		força caracteres maiúsculos aparecerem em minúsculos.
--Upper - 		força caracteres minúsculos aparecerem em maiúsculos.
--Concat(x,y)- 		concatena a string 'x' com a string 'y'.
--Substring(x,y,str)- 	extrai um substring da string 'str', começando em 'x', e termina em 'y'.
--To_Char(num)- 		converte um valor numérico para  uma string de caracteres.
--To_Date(char,fmt)- 	converte uma string caracter em uma data.

SELECT LOWER( Empregado.nome )
FROM Empregado;

-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).

SELECT SUBSTRING(Empregado.nome,1,5) FROM Empregado;

-- Apresente a Média, o Maior, o Menor e também a Somatória
--dos Salários pagos aos empregados.

-- Funções Agregadas (ou de Agrupamento)
--
--função        retorno
--avg(n)        média do valor n, ignorando nulos
--count(expr)   vezes que o número da expr avalia para algo nao nulo
--max(expr)     maior valor da expr
--min(expr)     menor valor da expr
--sum(n)	       soma dos valores de n, ignorando nulos

SELECT  AVG(Empregado.comissao)  FROM  Empregado;

SELECT  MIN(Empregado.comissao)  FROM  Empregado;

SELECT  MAX(Empregado.comissao)  FROM Empregado;

SELECT  SUM(Empregado.comissao) FROM  Empregado;


-- Apresente a média de comissão pagos por departamento.

SELECT Empregado.Departamento_idDepartamento, AVG(Empregado.comissao)
FROM Empregado
GROUP BY Empregado.Departamento_idDepartamento;

--  Retome o problema anterior, porém apresente resposta
--apenas para departamentos com mais de 2 empregados.

SELECT  Empregado.Departamento_idDepartamento, AVG(Empregado.comissao)
FROM  Empregado
GROUP BY Empregado.Departamento_idDepartamento
HAVING COUNT(*) > 2;

-- Listar Nomes de Empregados, Cargos e
--Nome do Departamento onde o empregado trabalha.


--neste caso, o uso de ALIAS é desnecessário
SELECT A.nome, A.funcao, B.nome
FROM Empregado as A, Departamento as B
WHERE B.idDepartamento = A.Departamento_idDepartamento;

-- Liste os Códigos de Cada Funcionário, seus Nomes, seus Cargos
--e o nome do Gerente ao qual este se relaciona.

-- neste caso, o uso de ALIAS é fundamental
SELECT  A.idEmpregado, A.nome, A.funcao, B.nome 'CHEFE'
FROM  Empregado A, Empregado B
WHERE  A.idGerente  = B.idEmpregado;


-- INSERT

INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');


-- UPDATE

UPDATE Empregado 
SET Empregado.salario = Empregado.salario* 1.2 
WHERE Empregado.salario< 1000;


-- DELETE

DELETE FROM Empregado
WHERE Empregado.salario > 5000;


-- Relacione todos os nomes de funcionários e seus respectivos
--cargos, desde que o orçamento do departamento seja igual a 10000.

SELECT  Empregado.nome, Empregado.funcao
FROM Empregado A
WHERE  10000 IN (SELECT Departamento.orcamento
                  FROM Departamento
                  WHERE Departamento.idDepartamento = A.Departamento_idDepartamento);

-- Relacione todos os departamentos que possuem
--empregados com remuneração maior que 3000.

SELECT Departamento.nome
FROM Departamento A
WHERE EXISTS (SELECT * FROM Empregado
              WHERE Empregado.salario > 3000 AND Empregado.Departamento_idDepartamento = A.idDepartamento);

