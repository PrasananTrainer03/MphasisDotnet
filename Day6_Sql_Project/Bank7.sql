use Bankproject 
GO

if exists(select * from sysobjects where name='prcAccountWithdraw') 
Drop proc prcAccountWithdraw 
Go

create proc [dbo].[prcAccountWithdraw]
				@AccountNo INT,
				@TranAmount INT
AS
BEGIN
	declare
		@balance numeric(9,2)
    if exists(select * from Accounts Where AccountNo=@AccountNo)
	BEGIN
		select @balance= Amount
		from Accounts where AccountNo=@AccountNo
		if @balance-@TranAmount >= 1000
		BEGIN
	UPDATE Accounts SET Amount=AMOUNT - @TranAmount 
		WHERE AccountNo = @AccountNo
	INSERT INTO TRANS(AccountNo,TranAmount,TranType) 
	values(@AccountNo,@TranAmount,'D')
	Print 'Amount Debited From Your Account...'
	END
	ELSE
	BEGIN
		print 'Insufficient Funds...'
	END
	END
	ELSE
	BEGIN
		print 'Invalid AccountNo...'
	END
END
GO

exec prcAccountWithdraw 1,15000
Go

exec prcAccountWithdraw 1,200000
Go
