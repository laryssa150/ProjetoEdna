drop database dbFrancisco;
 
create database dbFrancisco;
 
use dbFrancisco;
 
create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(12) not null,
primary key(codUsu)
);

create table tbAtribuicoes(
codAtr int not null auto_increment,
nome varchar (100) not null,
primary key(codAtr));

insert into tbAtribuicoes(nome) values(nome);

select * from tbAtribuicoes order by nome;

create table tbVoluntarios(
codVol int not null auto_increment,
nome varchar(100),
email varchar(100),
telCel char(15),
endereco varchar(100),
numero char(5),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
codAtr int not null,
data date,
hora time,
status boolean,
primary key(codVol),
foreign key(codAtr) references tbAtribuicoes(codAtr));

insert into tbVoluntarios (nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status);
values(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status);

--insert into tbUsuarios(nome,senha)values('senac', 'senac');
 
--select * from tbUsuarios;
 
--select nome,senha from tbUsuarios where nome='senac' and senha='senac';


--update tbUsuarios set nome = 'senac', senha = '123456789123',where codUsu = 1;

-- pesquisa filtrada por nome
--select * from tbusua
--rios where nome like '%nome';

--select * from tbUsuarios where nome = 'senac';

--delete from tbUsuarios where codUsu = '5';

-- pesquisa filtrada por codigo

--select * from tbUsuarios where codUsu = codUsu;


--create table tbVoluntarios(
--codUsu int not null auto_increment,
--nome varchar(30) not null,
--senha varchar(12) not null,
--primary key(codUsu),
--foreign key(codVol)
)

-- SELECT * FROM `tbvoluntarios` WHERE codvol = codVol
--SELECT * FROM tbvoluntarios WHERE nome like '%nome%';
