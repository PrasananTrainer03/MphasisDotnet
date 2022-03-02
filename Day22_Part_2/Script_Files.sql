use sqlpractice
go

if exists(select * from sysobjects where name='Users')
Drop Table users
Go

create table Users
(
   userName varchar(30) primary key,
   Passcode varchar(30)
)
Go

insert into Users(username,Passcode) 
values('Arka','Mitra'),
('Subham','Chowdary'),
('Lamiya','Sanadi'),
('Nikhil','Tagad'),
('Pinki','Chaudhary')


select count(*) cnt from Users where username='Arka'
and passcode='Mitra'