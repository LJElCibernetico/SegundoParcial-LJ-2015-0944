create database segundoParcialDB;

create table TiposDeTelefonos
(
	id int primary key identity(1,1) not null,
	tipo varchar(30)
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

