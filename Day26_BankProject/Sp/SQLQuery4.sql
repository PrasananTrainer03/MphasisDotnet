USE [bank]
GO

/****** Object:  StoredProcedure [dbo].[prcAccountSearch]    Script Date: 08-03-2022 09:12:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prcAccountSearch]
					@AccountNo INT
AS
BEGIN
	SELECT * FROM Accounts WHERE AccountNo=@AccountNo
END
GO


