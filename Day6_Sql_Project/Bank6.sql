if exists(select * from sysobjects where name='prcDeposit') 
Drop proc PrcDeposit 
Go

create proc [dbo].[prcAccountDeposit]
				@AccountNo INT,
				@TranAmount INT
AS
BEGIN
    if exists(select * from Accounts Where AccountNo=@AccountNo)
	BEGIN
	UPDATE Accounts SET Amount=AMOUNT + @TranAmount 
		WHERE AccountNo = @AccountNo
	INSERT INTO TRANS(AccountNo,TranAmount,TranType) 
	values(@AccountNo,@TranAmount,'C')
	Print 'Amount Credited to Your Account...'
	END
END
GO

exec prcAccountDeposit 1,15000
Go
