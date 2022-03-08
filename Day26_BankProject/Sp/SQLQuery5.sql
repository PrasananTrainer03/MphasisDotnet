USE [bank]
GO

/****** Object:  StoredProcedure [dbo].[prcAccountDeposit]    Script Date: 08-03-2022 09:12:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prcAccountDeposit]
				@AccountNo INT,
				@TranAmount INT
AS
BEGIN
	UPDATE Accounts SET Amount=AMOUNT + @TranAmount 
		WHERE AccountNo = @AccountNo
	INSERT INTO TRANS(AccountNo,TranAmount,TranType) 
	values(@AccountNo,@TranAmount,'C')
END
GO


