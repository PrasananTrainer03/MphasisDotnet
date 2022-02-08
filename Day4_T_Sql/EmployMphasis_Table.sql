use mphasispractice
Go

if exists(select * from sysobjects where name='EmployMphasis') 
Drop Table EmployMphasis; 
Go

Create Table EmployMphasis
(
   empno INT IDENTITY(1,1)
   constraint pk_employMphasis_empno primary key,
   Name varchar(30),
   Dept varchar(30),
   Desig varchar(30),
   Basic INT
)
Go

Insert into EmployMphasis(Name,Dept,Desig,Basic) 
values('Yashwanth','Sql','Programmer',98422),
('Amrut','Dotnet','Expert',99113),
('Arka mitra','Sql','Programmer',99666),
('Revti','Dotnet','Expert',99992),
('Sandhya','Sql','Programmer',99911),
('Sanket','Dotnet','Expert',99244) 
GO
