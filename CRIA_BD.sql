----Criar o banco----

create database CRIA;

----Conectar o banco----
use CRIA;

----DDL----

create table Usuario(
	ra	int primary key identity not null,
	nome varchar(600) not null,
	email varchar(600) not null
);

create table Matricula(
	id_Matri int primary key identity not null,
	ra int foreign key references Usuario (ra),
	id_Curso int foreign key references Curso (id_Curso),
	mensaliade date,
	validacao bit
);

create table Curso(
	id_Curso int primary key identity not null,
	nome varchar(800)
);

create table Mentor(
	id_Mentor int primary key identity not null, 
	nome varchar(600),
	id_Curso int foreign key references Curso(id_Curso)
);

create table ADM(
	id_ADM int primary key identity not null,
	nome varchar(600),
	email varchar(600),
	senha varchar(500)
);

create table API_FAM(
	id_API int primary key identity not null,
	ra int foreign key references Usuario (ra),
	id_Mentor int foreign key references Mentor (id_Mentor),
	id_Curso int foreign key references Curso(id_Curso),
	validar_Matricula int foreign key references Matricula(id_Matri)
);

----DML----

insert into Usuario (nome, email)
		values ('Luis Eduardo Mello Silva','luis_Mello@gmail.com'),
			   ('Nicolas Almeida Maurício','nicolas_Mauri@gmail.com'),
			   ('Rayssa Tavares dos Santos','ray_tavares@gmail.com');

select* from Usuario;
--------------------------------------------------------------------

insert into Curso 
		values ('Análise e desenvolvimentos de sistemas'),
			   ('Ciências da computação'),
			   ('Engenharia de software');

select* from Curso;
--------------------------------------------------------------------

insert into Mentor(nome,id_Curso)
		values ('Ranieri Marinho',1),
			   ('Cláudia Borim',3),
			   ('Eliane Amaral',2);

select* from Mentor;	
--------------------------------------------------------------------

insert into Matricula(ra,id_Curso,mensaliade,validacao)
		values (1,3,'13/05/2024',0),
			   (2,3,'09/05/2024',1),
			   (3,1,'03/05/2024',1);

select* from Matricula;
--------------------------------------------------------------------

insert into ADM	(nome,email,senha)
		values ('Administrador','adm_fam@vemprafam.com','vemprafam');

select* from ADM;
--------------------------------------------------------------------

insert into API_FAM(ra,id_Mentor,id_Curso,validar_Matricula)
		values (2,3,2,1),
			   (3,1,1,3);

select* from API_FAM;
--------------------------------------------------------------------

select Mentor.nome, Curso.nome
from Mentor
inner join Curso	
on Mentor.id_Curso = Curso.id_Curso

select Usuario.ra, Usuario.nome, Curso.nome
from Matricula
join Usuario on Matricula.ra = Usuario.ra
join Curso on Matricula.id_Curso = Curso.id_Curso


select Usuario.ra, Usuario.nome, Curso.nome, Matricula.validacao
from API_FAM
join Usuario on API_FAM.ra = Usuario.ra
join Curso on API_FAM.id_Curso = Curso.id_Curso
join Matricula on API_FAM.validar_Matricula = Matricula.id_Matri