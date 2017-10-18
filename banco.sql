create database farmacia_ja
go
use farmacia_ja
go
create table usuario(
	_id int identity(1,1) not null,
	nome varchar(100) not null,
	email varchar(80) not null,
	telefone varchar(11) not null,
	usuario varchar(50) not null,
	senha varchar(30) not null,
	logado int not null,
	logarAuto int  not null
	primary key(_id)
)
go
create table endereco(
	_id int not null,
	logradouro varchar(200) not null,
	numero int not null,
	complemento varchar(80) null,
	bairro varchar(100) not null,
	cidade varchar(100) not null,
	estado varchar(2) not null,
	primary key(_id),
	foreign key(_id) references usuario(_id)
)
go
INSERT INTO farmacia_ja..usuario
VALUES('HYGOR', 'HYGOR@HOTMAIL.COM', '31993755276', 'HYGORL', '123456789', 1, 1)