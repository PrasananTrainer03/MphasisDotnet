use BankProject
GO

if exists(select * from sysobjects where name='Accounts') 
Drop Table Accounts 
GO

Create Table Accounts
(
   AccountNo INT constraint pk_accounts_accountNo primary key,
   FirstName varchar(30),
   LastName varchar(30),
   City varchar(30),
   State varchar(30),
   Amount numeric(9,2),
   CheqFacil varchar(10),
   AccountType varchar(20),
   Status varchar(10) default 'active',
   dateofopen date default getdate()
)
Go
