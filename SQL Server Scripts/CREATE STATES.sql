USE LOJA_ROUPAS
GO

CREATE TABLE States
(
	Id			INT NOT NULL IDENTITY,
	UF			VARCHAR(2),
	StateName	VARCHAR(50)
	PRIMARY KEY(Id)
)
go

Insert into States (UF, StateName) values('AC','Acre');
insert into States (UF, StateName) values('AL','Alagoas');
insert into States (UF, StateName) values('AM','Amazonas');
insert into States (UF, StateName) values('AP','Amapa');
insert into States (UF, StateName) values('BA','Bahia');
insert into States (UF, StateName) values('CE','Ceara');
insert into States (UF, StateName) values('DF','Distrito Federal');
insert into States (UF, StateName) values('ES','Espirito Santo');
insert into States (UF, StateName) values('GO','Goias');
insert into States (UF, StateName) values('MA','Maranhao');
insert into States (UF, StateName) values('MG','Minas Gerais');
insert into States (UF, StateName) values('MS','Mato Grosso do Sul');
insert into States (UF, StateName) values('MT','Mato Grosso');
insert into States (UF, StateName) values('PA','Para');
insert into States (UF, StateName) values('PB','Paraiba');
insert into States (UF, StateName) values('PE','Pernambuco');
insert into States (UF, StateName) values('PI','Piaui');
insert into States (UF, StateName) values('PR','Parana');
insert into States (UF, StateName) values('RJ','Rio de Janeiro');
insert into States (UF, StateName) values('RN','Rio Grande do Norte');
insert into States (UF, StateName) values('RO','Rondonia');
insert into States (UF, StateName) values('RR','Roraima');
insert into States (UF, StateName) values('RS','Rio Grande do Sul');
insert into States (UF, StateName) values('SC','Santa Catarina');
insert into States (UF, StateName) values('SE','Sergipe');
insert into States (UF, StateName) values('SP','Sao Paulo');
insert into States (UF, StateName) values('TO','Tocantins');

