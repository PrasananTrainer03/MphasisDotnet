use BankProject
GO

if exists(select * from sysobjects where name='prcAccountCreate') 
Drop Table prcAccountCreate  
GO

create proc prcAccountCreate
						@FirstName varchar(30),
						@LastName varchar(30),
						@City varchar(30),
						@State varchar(30),
						@amount numeric(9,2),
						@cheqFacil varchar(10),
						@accountType varchar(30)
AS
BEGIN
	declare
		@accountNo INT
	BEGIN
		select 
			@accountNo=CASE WHEN Max(accountNo) IS NULL THEN 1 
			else Max(accountNo)+1 END 
			from Accounts
		Insert into Accounts(AccountNo,FirstName,LastName,City,State,
		Amount,CheqFacil,AccountType) values(@accountNo,@FirstName,
		@LastName,@City,@State,@amount,@cheqFacil,@accountType) 
		Print 'Account Created'
	END
END

Exec prcAccountCreate 'Yashwanth','G','Warangal','TS',58345,'Yes','Savings'

select * from Accounts

--select case when max(accountNo) IS NULL then 1 else max(accountNo)+1 END accno
--from Accounts
