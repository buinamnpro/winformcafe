create database qlcafe
go 
use qlcafe
go
create table tablefood
(
id int identity primary key,
name nvarchar(100) default N'chua dat ten ',
status nvarchar(100)default N'trong', --trong va co nguoi 

)
go
create table account 
(

displayname nvarchar(100) not null,
username nvarchar(100)not null primary key ,
password nvarchar(100) not null default 0,
type int not null default 0
)
go
create table foodcategory (
id int identity primary key,
	name nvarchar(100)not null default N'chua dat ten ',
)
create table food
(
id int identity primary key		,
 name nvarchar(100) not null default N'chua dat ten ' ,
 idcategory int not null ,
 price float not null default 0,
 foreign key (idcategory) references dbo.foodcategory(id)				

)
create table bill
(
id int identity primary key,
 datecheckin date not null default getdate() ,
 datecheckout date,
 idtable int not null,
 status int not null default 0,-- 1 da thanh toan 0 la chua thanh toan 
 foreign key (idtable) references dbo.tablefood(id)
)
go
create table billinfo (
id int identity primary key,
idbill int not null,
idfood int not null,
count int not null default 0
foreign key (idbill) references dbo.bill(id),
foreign key (idfood) references dbo.food(id)
)