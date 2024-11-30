create database Criabd;

use Criabd;

create table tipoUsuario(
	idTipoUsuario int primary key identity not null,
	nome varchar (250) not null unique 
);

create table usuario(
	idUser int primary key identity not null,
	nome varchar (250) not null,
	email varchar (250) not null unique,
	senha varchar (250) not null,
	acesso int foreign key  references tipoUsuario (idTipoUsuario)
);

create table financeiro(
	idFin int primary key identity not null,
	dataVenc date not null,
	aVencer bit,
	pago bit
);

create table curso(
	idCurso int primary key identity not null,
	nome varchar (250) not null unique,
	habilitacao varchar (250) not null,
	duracao int not null
);


create table aluno(
	idAluno int primary key identity not null,
	nome varchar (250) not null,
	dataNascimento date,
	telefone varchar (250) not null unique,
	email varchar (250) not null unique
);

create table matricula(
	ra int primary key identity not null,
	nome int foreign key  references aluno (idAluno),
	curso int foreign key  references curso (idCurso),
	semestre int,
	turno varchar (250) not null unique,
	campus varchar (250) not null unique,
	mensalidade int foreign key  references financeiro (idFin)
);

create table inscricao(
	ra int primary key identity not null,
	nome varchar (250) not null,
	email varchar (250) not null unique,
	ano date,
	fam int foreign key  references matricula (ra)
);


insert into tipoUsuario values ('Administrador')
							  ,('Aluno')

insert into usuario (nome, email, senha, acesso) values		
				('ADM', 'secretaria@vemprafam.com', 'Paulista1508', 1)
			   ,('Nicolas Maurício', 'nicolasmau@gmail.com', 'teste12356', 2)
			   ,('Rayssa', 'rayssasanz@gmail.com', 'teste321', 2)

insert into financeiro (dataVenc, aVencer, pago) values		
				('2024-11-09', 0, 0)
			   ,('2024-12-09', 1, 1)
			   
insert into curso (nome, habilitacao, duracao) values		
				('Analise e Desenvolvimento de Sistemas', 'Tecnólogo', 4)
			   ,('Ciências da Computação', 'Bacharelado', 8)
			   ,('Engenharia da Computação', 'Bacharelado', 10)

insert into aluno (nome, dataNascimento, telefone, email) values		
				('Rayssa Tavares dos Santos', '2003-04-01', '(11)91244-7894', 'rayssasanz@gmail.com')
			   ,('Nicolas de Almeida Maurício', '2000-11-16', '(11)97742-1243', 'nicolasmau@gmail.com')

insert into matricula (nome, curso, semestre, turno, campus, mensalidade) values		
				(1, 3, 8, 'Noturno', 'Paulista',1)
			   ,(2, 2, 5, 'Matutino', 'Bela Cintra',2)

insert into inscricao (nome, email, ano , fam) values		
				('Rayssa Tavares dos Santos', 'rayssasanz@gmail.com', '2024-12-09',1)
			   ,('Nicolas de Almeida Maurício', 'nicolasmau@gmail.com', '2024-12-09',2)
			   
