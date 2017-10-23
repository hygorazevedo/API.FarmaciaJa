use master
create database farmaciaja
go
use farmaciaja
go

create table usuario(
	_id int identity(1,1) not null,
	nome varchar(100) not null,
	email varchar(80) not null,
	telefone varchar(11) not null,
	usuario varchar(50) not null,
	senha varchar(30) not null,
	logado int not null,
	logarAuto int  not null,
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
create table farmacia(
	_id int not null,
	descFarmacia varchar(255) not null,
	endereco varchar(255) not null,
	mediaTempoEntrega float not null,
	mediaNotaAtendimento float not null,
	informacoesFarmacia varchar(255) not null,
	primary key(_id)
)
go
create table produto(
	_id int not null,
	farmacia_id int not null,
	descProduto varchar(255) not null,
	nomeProduto varchar(100) not null,
	valorProduto money not null,
	primary key(_id)
)