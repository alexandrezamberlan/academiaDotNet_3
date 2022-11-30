# Roteiro das Aulas

## 3011/2022
    -Xamarin
    - Site da Microsoft - https://learn.microsoft.com/pt-br/xamarin/get-started/what-is-xamarin
    - Documentação Xamarin - https://learn.microsoft.com/pt-br/xamarin/
    - Conhecendo Xamarin - https://youtu.be/rtuywS2fG2Y
    - Tutoriais Xamarin (básico ao avançado) - https://youtube.com/playlist?list=PLfvOpw8k80WqDChdm1cdlWx0FIR9ILtcm 

    - Foco
        Xamarin.Android
        Xamarin.Forms
        Xamarin.Essentials
## 26/11/2022 - sábado
    - Criptografia (continuação)
        - função de embaralhamento (hash) via cálculo - função matemática
        - codificar mensagens ou conteúdos entre remetente e destinatário
            - há a criptografia no remetente, e a decriptografia no destinatário
        - Tipos:
            - criptografia simétrica: 
                - mesma chave privada para remetente e destinatário
                - menos segura
                - mais rápida
                - WhatsApp usa esse tipo
            - criptografia assimétrica: 
                - chave pública para o remetente
                - chave privada para o destinatário
                - mais segura
                - mais lenta (principalmente no processo de decriptografia)
                - usada em Certificações Digitais
        - Algoritmos:
            - simétrica: DES, 3DES, AES (WhatsApp)
            - assimétrica: RSA, TwoFish

    - Desafio Entity

## 23/11/2022
    - Reescrita (override) do: Equals, HashCode, CompareTo (ICompare)
    - Criptografia: simétrica, assimétrica
                    algoritmos
                    exemplos em C#
        - https://github.com/ricardosma/CriptografiaExemplo
        - https://github.com/ricardosma/Criptografia

## 16/11/2022
    - Desafio 2 - Mini ERP - Windows Forms, ADO.Net, SQL Server, Management Studio
## 11/11/2022
    - Windows Forms + ADO.Net
        - Exemplo do Ricardo e do Fabrício -> CRUD + string conexão + sqlinjection
        - Exemplos do Alexandre - CRUD + string conexão
    - Atividade:
        1) refazer o sistema da glicemia com crud completo (paciente e medidas de glicemia)
        2) refazer o sistema do usuário (usuário + email)
        3) acompanhar o Alexandre no passo-a-passo

## 09/11/2022
 - Banco de Dados -> SGBD -> SQL
    BD -> conjunto de tabelas em arquivo
    SGBD -> gerente do BD: integridade; consistência; transações
         -> chave primária (um atributo ou muitos)
         -> chave estrangeira (um atributo ou muitos)

         -> Observação: evitar no máximo que chave estrangeira seja chave primária.....
    SQL -> Sql Server (BD e SGBD da Microsoft) -> transact SQL
        -> DDL: create database, drop database, alter, create table, alter table, drop table
        -> DML: * insert into values
                * select columns
                  from tables
                  where
                 order by
                * update table
                  set column
                  where
                * delete from table
                  where

                  




Departmento(codDepartamento, nome)
Empregado(codEmpregado,nome, codDepartamento)

Departamento 1..1 ------- 0..n Empregado

1  -> n -> a chave estrangeira vai para o lado do n
====================

Professor(codProfessor, nome)
Curso(codCurso, nome)
ProfessorCurso(codProfessor, codCurso, ...)

Professor 1..n ------- 1..n Curso

n -> n -> criação de uma terceira tabela/classe que terá no mínimo as duas chaves primárias das tabelas

Desenhista(codDesenhista, nome, codMesa)
Mesa(codMesa, lugar, tipo)

Desenhista 1..1 ---- 1..1 Mesa

1 -> 1 -> tanto faz o lugar da chave estrangeira ou juntar numa tabela unica


Professor 1..n  --- 1..n Curso

Professor
Curso
ProfessorCurso

Curso 1..n --- 1..n Disciplinas
Disciplina
CursoDisciplina

Aluno 1..n --- 1..n Curso
Aluno
AlunoCurso

Turma: Aluno 0..n --- 1..n Disciplina
AlunoDisciplina(codAluno, codDisciplina, ano, semestre)
AlunoDisciplina(1,15)
AlunoDisciplina(1,15)


















## 08/11/2022
- Banco de Dados
    - SGBD
        - Cardinalidades
    - SQL
        - DDL
        - DML
    - Framework para Mapeamento Objeto-Relacional (ORM ou MOR)
        - Antigamente, o foco do sistema era o banco de dados
        - Atualmente, o foco são as funcionalidades
            - Teoria da Orientação a Objetos
                - Classe, métodos, atributos
                - Processo chamado MOR: das classes são geradas as tabelas de forma automática

        - Exceção:
            Sistemas Legados: o caminho é do banco (tabelas) para as classes (orientação a objetos)

## 04/11/2022
- Windows Form:
    - Exercícios
    - Vídeo apoio: https://youtu.be/JgBqsIffWdU
        - Sistema de Cadastro de Jogadores - nome completo
            - valida se o nome já está ou não na base de dados (lista + arquivo)
            - gera o email a partir do sobrenome e do primeiro nome da pessoa + @ufn.edu.br
            - transforma para maiúsculo
            - persiste em base de dados (lista + arquivo)
            - conecta com a base de dados (primeira execução)

## 26/10/2022
- Windows Form
    - componentes gráficos para desktop: Form, Label, TextBox, Button, Panel, Combo box, Menu
    - componente é um objeto de classe
        - aspecto estrutural -> propriedade -> característica -> atributo (nome, texto, posição, tamanho, visibilidade, )
        - aspecto funcional  -> evento                        -> método (maximizar, minimizar, clicar, desclicar, pressionar, ...)

    - Ferramenta gestora de componentes gráficos (ARRASTAR E SOLTAR): 
        - caixa para as propriedade de um componente
        - caix para os eventos do componente

## 19/10/2022
- Práticas com OO, Listas e Manipulação de arquivos (plain text)
    - StreamReader
    - StreamWriter
    - Classe Utilidade -> métodos de classe para alguns serviços...
    - Classe da Regra do Negócio 

## 05/10/2022
- Orientação a Objetos 
    - https://www.w3schools.com/cs/cs_oop.php
    - https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop

    - Usar classes nativas do C#: List, string, Random, ....

    Paradigma da Orientação a Objetos 
        - operacionaliza a ideia de "terceirização" de serviços

        - reutilização
            - instanciação de objetos (definir que um objeto é de um tipo ou associado a uma classe)
                - automaticamente o objeto encapsula atributos e métodos da classe associada
            - herança
        - encapsulamento/segurança
            - um objeto ou uma classe possuem atributos e métodos exclusivos a ela
            - visibilidade (private, protected e public)

        - polimorfismo
            - de sobrecarga - um mesmo método funcionando de mais de uma forma
            - de sobreescrita - um método herdado é reescrito localmente

    string nomePessoa;
        - objeto/instancia/elemento/ocorrencia ele possui:
            1) propriedades/caracteristicas/atributos
            2) comportamentos/funcionalidades/operações/métodos

## 28/09/2022
- Fazendo a lista de exercícios 3 - repetição
- Revendo como usar o git, github no terminal (cmd ou shell) e no VS Code


## 21/09/2022

- Apresentação da turma, colegas e habilidades
- Boas práticas de trabalho em equipe na computação
    1) Versionamento de código
        - https://visualstudio.microsoft.com/pt-br/free-developer-offers/
        - Para sincronizar VS Code ou VS 2022 com GitHub é preciso:
            1) instalar o git na máquina
            2) no VS Code - instalar a extensão GitLens
            3) primeiro, criar o projeto no github, segundo, clonar na sua máquina, alterar e sincronizar
                - o primeiro sincronismo deve validar com usuário e senha na WEB

    2) Consultar fontes da microsoft de preferência
        - https://docs.microsoft.com/pt-br/dotnet/csharp/
        - https://www.w3schools.com/cs/index.php

- Ambientes de Desenvolvimento (IDE)
    1) Visual Studio 2022 - https://visualstudio.microsoft.com/pt-br/free-developer-offers/
    2) Visual Studio Code - https://visualstudio.microsoft.com/pt-br/free-developer-offers/
    3) Git - https://git-scm.com/downloads
    4) SQL Server - https://www.microsoft.com/pt-br/sql-server/sql-server-downloads


