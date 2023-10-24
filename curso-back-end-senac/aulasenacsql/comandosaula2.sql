use projeto;


/* Criacao das tabelas */

/*CREATE TABLE usuarios(
id_usuario INT NOT NULL Primary KEY IDENTITY(1,1),/* PRIMARY KEY AUTO INCREMENTO DE 1 EM 1*/
nome VARCHAR(50) NOT NULL, 
sobrenome VARCHAR(100), 
email VARCHAR(100) NOT NULL UNIQUE, /* CAMPO ÚNICO*/
senha VARCHAR(64) NOT NULL, 
salario FLOAT DEFAULT 1350); /* SALÁRIO PADRÃO */


CREATE TABLE enderecos(
id_endereco INT NOT NULL Primary KEY IDENTITY(1,1),
id_usuario INT NOT NULL,
cep VARCHAR(10) NOT NULL,
logradouro VARCHAR(100),
numero INT, 
complemento VARCHAR(100),
bairro VARCHAR(100), 
cidade VARCHAR(100), 
uf VARCHAR(2)
);*/


/*select * from usuarios; 

select * from enderecos;*/

/* inserindo informacoes na tabela usuario */

/*INSERT INTO usuarios(nome, sobrenome, email, senha)VALUES('Lucas', 'Monteiro', 'lucas.monteiro@educaco.senac.rio',
'q1w2e3r4t5y6u7i8o9p0');*/


/*INSERT INTO usuarios(nome, sobrenome, email, senha)VALUES('Tufas', 'Loureto', 'tufas.loureto@educaco.senac.rio',
'z0e2c3r2t4y6r9h6b8b1');*/

/* inserindo informacoes na tabela endereco */ 

/*INSERT INTO enderecos(id_usuario, cep, logradouro, numero, complemento, bairro, cidade, uf)
VALUES(1, '24.795-000', 'Rua dos Achados', 22, 'No Poste','Sei lá', 'Prego da Caixa', 'SL');

INSERT INTO enderecos(id_usuario, cep, logradouro, numero, complemento, bairro, cidade, uf)
VALUES(2, '24.455-000', 'Rua dos perdidos', 65, 'Esquina','Catambi', 'Baixada de todos', 'LR');*/


/* criando a relacao de tabelas */
/* só é possível criar relacao de tabelas com chave primaria e secundaria  */
/*ALTER TABLE enderecos ADD FOREIGN KEY(id_usuario) REFERENCES usuarios(id_usuario);*/

/* apangando uma tabela */
/*drop table enderecos;*/

/* apagando linhas numa tabela */
/*delete from enderecos where id_endereco = 3;*/

/*delete from enderecos where id_endereco = 4;*/

/*select * from enderecos;*/