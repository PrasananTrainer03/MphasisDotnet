USE [bank]
GO

/****** Object:  StoredProcedure [dbo].[prcAccountNoGenerate]    Script Date: 08-03-2022 09:11:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[prcAccountNoGenerate]  
AS  
BEGIN  
 select MAX(AccountNo)+1 Accno from Accounts   
END
GO


