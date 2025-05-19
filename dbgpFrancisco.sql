drop database dbFrancisco;
 
create database dbFrancisco;
 
use dbFrancisco;
 
create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(12) not null,
primary key(codUsu)
);
 
insert into tbUsuarios(nome,senha)values('senac', 'senac');
 
select * from tbUsuarios;
 
select nome,senha from tbUsuarios where nome='senac' and senha='senac';


update tbUsuarios set nome = 'senac', senha = '123456789123',where codUsu = 1;

-- pesquisa filtrada por nome
select * from tbusua
rios where nome like '%nome';

-- pesquisa filtrada por codigo

select * from tbUsuarios where codUsu = codUsu;


create table tbVoluntarios(
codUsu int not null auto_increment,
nome varchar(30) not null,
senha varchar(12) not null,
primary key(codUsu),
foreign key(codVol)
)