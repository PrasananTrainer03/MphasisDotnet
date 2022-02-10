if exists(select * from sysobjects where name='prcAccountSearch') 
Drop proc prcAccountSearch 
GO

Create proc prcAccountSearch
					@accountNo INT
AS
BEGIN
	declare
		@firstName varchar(30),
		@lastName varchar(30),
		@city varchar(30),
		@state varchar(30),
		@amount numeric(9,2),
		@cheqFacil varchar(30),
		@accountType varchar(30)
	BEGIN
		if exists(select * from Accounts where AccountNo=@accountNo) 
		BEGIN
			select 
				@firstName=FirstName,
				@lastName=LastName,
				@city=City,
				@state=State,
				@amount=Amount,
				@cheqFacil=CheqFacil,
				@accountType=AccountType
			from Accounts where AccountNo=@accountNo
		Print 'FirstName ' +@firstName
		print 'LastName ' +@lastName 
		print 'City ' +@city
		Print 'State ' +@state
		print 'Amount ' +convert(varchar(100),@amount) 
		Print 'CheqFacil  ' +@cheqFacil
		print 'Account Type ' +@accountType
		END
		ELSE 
		BEGIN
			print 'Account No Not Found...'
		END
	END
END
GO

exec prcAccountSearch 3 
GO
