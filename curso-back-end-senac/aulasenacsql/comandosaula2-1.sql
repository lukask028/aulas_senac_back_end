/* criar tabela aluno, disciplina , e endereco*/

/* a tabela aluno deve conter 10 dados */
/* a tabela disciplina deve conter o id_aluno */
/* a tabela disciplina deve conter no mínimo 2 disciplinas*/
/* a tabela endereco deve conter o id_aluno */ 

/*criando a tabela aluno tabela alunos*/
use [Cadastro aluno];

create table [tbl_Aluno](
idAluno int not null primary key identity(1,1),
nome varchar(50),
sobrenome varchar(50),
matricula int not null unique,
fk_idDisciplina int not null) ;


/* inserindo dados na tabela aluno */
/* nome, sobrenome, matricula */

/*select * from tbl_Aluno*/



insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Lucas','Lourenço',54874589, 1);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Joao', 'Figo', 54123214, 2);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Flavia', 'Figueiredo', 54789652, 1);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Olivia', 'Optan', 87412365, 4);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Jose', 'Oliveira', 41178932, 3);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Felipe', 'Rocardo', 41789654, 4);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Gabriela', 'Hastad', 41256325, 2);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Celia', 'Maria', 45698745, 3);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Gustavo', 'Menezes', 41256523, 4);
insert into tbl_Aluno(nome, sobrenome, matricula, fk_idDisciplina) values ('Cicero', 'Abreu', 41784187, 3);

/*select * from tbl_Aluno;*/



/*criando a tabela discplina*/
/*CRUD*/
/*create*/

create table tbl_Disciplina(
idDisciplina int not null primary key identity(1,1),
disciplina varchar(50) unique,
professor varchar(50));


/*read*/
/*select * from tbl_Disciplina;*/

/*inserindo dados na tabela disciplina*/

insert into tbl_Disciplina(disciplina, professor) values ('Portugues', 'Rodrigo');
insert into tbl_Disciplina(disciplina, professor) values ('Matematica', 'Julia');
insert into tbl_Disciplina(disciplina, professor) values ('Historia', 'Diego');
insert into tbl_Disciplina(disciplina, professor) values ('Informatica', 'Fernanda');

/*select * from tbl_Disciplina;*/
/*update*/
update tbl_Disciplina set professor = 'Vanessa' where idDisciplina = 4;
select * from tbl_Disciplina;

/*delete from tbl_Disciplina where idDisciplina = 4;*/
/*delete*/


/* criando tabela de endereco */
CREATE TABLE tbl_Enderecos(
idEndereco INT NOT NULL Primary KEY IDENTITY(1,1),
cep VARCHAR(10) NOT NULL,
logradouro VARCHAR(100),
numero INT, 
complemento VARCHAR(100),
bairro VARCHAR(100), 
cidade VARCHAR(100), 
uf VARCHAR(2),
fk_idAluno INT NOT NULL,
);

/*select * from tbl_Enderecos;*/

/* inserindo dados na tbl_enderecos */

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('14.645-454', 'Rua dos acahados', 65, 'A', 'Bairro Baixo', 'Cidade do lago', 'RJ', 1); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('65.154-147', 'Rua dos fundos', 54, 'B', 'Bairro Chique', 'Cidade da Barra', 'SP', 2); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('21.354-123', 'Rua dos bonecos', 45, 'C', 'Bairro Alto', 'Cidade de Arvores', 'RJ', 3); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('64.847-215', 'Rua dos jao', 65, 'D', 'Bairro Medio', 'Cidade do Rio', 'MG', 4); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno)
values ('73.783-654', 'Rua da frente', 65, 'E', 'Bairro Nobre', 'Cidade do Mar', 'RJ', 5);

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('65.154-147', 'Rua dos fundos', 40, 'B', 'Bairro Chique', 'Cidade da Barra', 'SP', 6); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('64.847-215', 'Rua dos jao', 20, 'D', 'Bairro Medio', 'Cidade do Rio', 'MG', 7); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno)
values ('73.783-654', 'Rua da frente', 11, 'E', 'Bairro Nobre', 'Cidade do Mar', 'RJ', 8);

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('21.354-123', 'Rua dos bonecos', 33, 'C', 'Bairro Alto', 'Cidade de Arvores', 'RJ', 9); 

insert into tbl_Enderecos(cep, logradouro, numero, complemento, bairro, cidade, uf, fk_idAluno) 
values ('14.645-454', 'Rua dos acahados', 31, 'A', 'Bairro Baixo', 'Cidade do lago', 'RJ', 10); 


/*select * from tbl_Enderecos;*/


/* como fazer a relacao de aluno disciplina, funciona colocando uma coluna de disciplina em tbl aluno? duvida */  

/* relação da fk_idDisciplina(tbl_aluno) com idDisciplina(tbl_Disciplina)*/
/* só é possível criar relacao de tabelas com chave primaria e secundaria  */

alter table  tbl_Aluno add foreign key(fk_idDisciplina) references tbl_Disciplina(idDisciplina);


/* relação da fk_idAluno(tbl_Enderecos) com idAluno(tbl_Aluno)*/

alter table tbl_Enderecos add foreign key(fk_idAluno) references tbl_Aluno(idAluno);

/* leitura com relacionamento */

/* só possível fazer o inner join se tiver a relacao de referencias das keys*/
select * from tbl_Aluno inner join tbl_Enderecos on 
tbl_Enderecos.fk_idAluno = tbl_Aluno.idAluno;