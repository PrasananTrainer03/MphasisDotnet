if exists(select * from sysobjects where name='prcAccountClose') 
Drop proc prcAccountClose 
GO

Create proc prcAccountClose
					@accountNo INT
AS
BEGIN
		if exists(select * from Accounts where AccountNo=@accountNo) 
		BEGIN
			Update Accounts set Status='inactive' where AccountNo=@accountNo
			print 'Account Closed...'
		END
		ELSE 
		BEGIN
			print 'Account No Not Found...'
		END
END
Go

exec prcAccountClose 3
Go

GO
