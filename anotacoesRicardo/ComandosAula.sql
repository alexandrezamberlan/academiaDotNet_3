use master

drop database empresa_db;

create database empresa_db;

use empresa_db

CREATE TABLE Departamento (
  idDepartamento INT NOT NULL IDENTITY,
  nome VARCHAR(45) NOT NULL,
  localizacao VARCHAR(45) NOT NULL,
  orcamento VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (idDepartamento)
);

select * from Departamento

CREATE TABLE Empregado (
  idEmpregado INT NOT NULL IDENTITY,
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


INSERT INTO Departamento VALUES('Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('Redes','Taquara','12122');

INSERT INTO Empregado VALUES('Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');


SELECT * FROM EMPREGADO;

SELECT  *  
FROM  Departamento;

