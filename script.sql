-- CRIANDO BANCO DE DADOS

CREATE DATABASE bdProjeto;

-- USANDO O BANCO DE DADOS

USE bdProjeto;

-- CRIANDO AS TABELAS

CREATE TABLE tbPedido(
	codPedido int primary key auto_increment,
    tipoHamburguer varchar(50),
    valorHamburguer varchar(50),
    valorOpcionais varchar(50),
    valorTotal varchar(50)
)

-- CONSULTANDO A TABELA

SELECT * FROM tbPedido;