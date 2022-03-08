USE [bank]
GO

/****** Object:  StoredProcedure [dbo].[prcAccountCreate]    Script Date: 08-03-2022 09:11:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prcAccountCreate]
			@AccountNo INT,
			@FirstName varchar(30),
			@LastName varchar(30),
			@City varchar(30),
			@State varchar(30),
			@Amount INT,
			@CheqFacil varchar(10),
			@AccountType varchar(30)
AS
BEGIN
	Insert into Accounts(AccountNo,FirstName,
LastName,City,State,Amount,CheqFacil,AccountType)
values(@AccountNo,@FirstName,@LastName,@City,
@State,@Amount,@CheqFacil,@AccountType) 
END			
GO


