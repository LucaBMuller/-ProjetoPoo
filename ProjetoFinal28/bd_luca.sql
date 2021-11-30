create database luca;
use luca;

create table dados (
id int primary key auto_increment unique,
lbm varchar(50) not null,
l6 varchar(50) not null,
m23 varchar(50) not null
)ENGINE=InnoDB;

create table usuarios(
id int primary key auto_increment unique,
nome varchar(50) not null,
telefone varchar(50) not null,
rua varchar(50) not null,
numero varchar(50) not null,
bairro varchar(50) not null,
cidade varchar(50) not null,
estado varchar(50) not null,
pais varchar(50) not null,
cpf varchar(50) not null,
rg varchar(50) not null,
dataNascimento varchar(50) not null,
email varchar(50) not null,
senha varchar(50) not null
)ENGINE=InnoDB;

insert into usuarios (id, nome, telefone, rua, numero, bairro, cidade, estado, pais, cpf, rg, dataNascimento, email, senha)
values(1, 'luca', 31998768767, 'da mata', 123, 'Savassi', 'Bh', 'MG', 'Brasil', 12345678910, 'mg12456101', '23/06/2003', 'luca@gmail.com', 123456);