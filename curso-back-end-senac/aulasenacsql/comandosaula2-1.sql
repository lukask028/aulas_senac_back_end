/*criando a tabela aluno tabela alunos*/

/*create table tblAluno(
idAluno int not null primary key identity(1,1),
nome varchar(50),
sobrenome varchar(50),
matricula int not null unique);*/


/* inserindo dados na tabela aluno */
/* nome, sobrenome, matricula */

/*select * from tblAluno*/

/*insert into tblAluno(nome, sobrenome, matricula) values ('Lucas','Lourenço',54874589);
insert into tblAluno(nome, sobrenome, matricula) values ('Joao', 'Figo', 54123214);
insert into tblAluno(nome, sobrenome, matricula) values ('Flavia', 'Figueiredo', 54789652);
insert into tblAluno(nome, sobrenome, matricula) values ('Olivia', 'Optan', 87412365);
insert into tblAluno(nome, sobrenome, matricula) values ('Jose', 'Oliveira', 41178932);
insert into tblAluno(nome, sobrenome, matricula) values ('Felipe', 'Rocardo', 41789654);
insert into tblAluno(nome, sobrenome, matricula) values ('Gabriela', 'Hastad', 41256325);
insert into tblAluno(nome, sobrenome, matricula) values ('Celia', 'Maria', 45698745);
insert into tblAluno(nome, sobrenome, matricula) values ('Gustavo', 'Menezes', 41256523);
insert into tblAluno(nome, sobrenome, matricula) values ('Cicero', 'Abreu', 41784187);*/

/*criando a tabela discplina*/

create table tblDisciplina(
idDisciplina int not null primary key identity(1,1),
idAluno int not null,
nomeDis varchar(50) unique,
professor varchar(50))


/*inserindo dados na tabela disciplina*/

/*insert into tblDisciplina(idDisciplina, nomeDis, professor) values ('portugues', 'Rodrigo');*/

