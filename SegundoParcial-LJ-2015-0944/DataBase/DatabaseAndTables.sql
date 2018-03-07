create database segundoParcialDB;

create table Personas
(
	personaID int primary key identity(1,1),
	nombre varchar(max),
	fecha date
);

drop table Personas;

select * from Personas;

create table TiposDeTelefonos
(
	id int primary key identity(1,1) not null,
	tipo varchar(30)
);

drop table TiposDeTelefonoDetalle;

create table TiposDeTelefonoDetalles
(
	DetalleID int primary key identity(1,1) not null,
	PersonaID int,
	TiposDeTelefonoID int,
	Tipo varchar(max),
	Telefono varchar(max)
);

select * from TiposDeTelefonos;

insert into TiposDeTelefonos(tipo)
values ('Residencial');

insert into TiposDeTelefonos(tipo)
values ('Trabajo');

insert into TiposDeTelefonos(tipo)
values ('Oficina');

insert into TiposDeTelefonos(tipo)
values ('Casa');

insert into TiposDeTelefonos(tipo)
values ('Celular');

