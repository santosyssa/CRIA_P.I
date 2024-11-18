use tcc_cria;

create table Tipo_Usuarios(
	idTipo_Usuario int primary key identity not null,
	nome varchar (250) not null unique 
);

create table Usuarios(
	id int primary key not null,
	ra int unique not null,
	nome varchar(600) not null,
	email varchar(600) unique not null,
	senha varchar (250) not null,
	idTipo_Usuario int foreign key  references Tipo_Usuarios (idTipo_Usuario)
);

create table Inscricao(
	id int primary key not null,
	ra int unique not null,
	nome varchar(600) not null,
	email varchar(600) unique not null
);
