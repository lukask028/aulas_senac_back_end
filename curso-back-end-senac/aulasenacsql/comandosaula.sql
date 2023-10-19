--create database novo_proj;--

--selecionando a base de informações --
use  novo_proj;


-- criando a tabela usuarios --
/*create table usuarios (
id_ int,
nome varchar(100) not null,
idade int not null,
email varchar(100) not null unique,
salario float,
senha varchar(250) not null,
)*/


-- inserindo informacoes na tabela usuario--
/*insert into usuarios (id_, nome, idade, email, salario, senha) values (2, 'Jairo drum', 25, 'email8989@email.com', 1452.50, 'sddasfs334drf'),
(3, 'cacique ramos', 23, 'cc@email.com', 123.42, '324234asda'),
(4, 'sasa susu', 34, 'ss@emailasd.com', 2145.23, 'asda34aa224'),
(5, 'juju jaja', 42, 'jj@email.com', 324.32, 'aaafd341@@adss');*/
-- apagando a tabela --
-- drop table usuarios --

--retornando pesquisa geral da tabela-- 
--select * from usuarios;--

--retornando pesquisa com filtro--
--select idade from usuarios where idade = '42';--

--atualizando dados--
--update usuarios set idade = 20 where id_ = '1';--

--criando tabela produtos--
/*create table produtos (
id int not null identity(1,1),
nome varchar(50),
codigo int not null unique,
descricao varchar(150)
)*/

--retorna tabelas criadas no data base especifico no caso novo_proj
select * from sys.tables;

--select * from produtos;
