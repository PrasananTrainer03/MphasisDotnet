Create Proc PrcSayHello
AS
BEGIN
	Print 'Welcome to Sql Server...'
END
GO

Exec PrcSayHello
GO

-- To Drop a stored Procedure 

-- Drop Proc PrcSayHello 

Create proc prcgreeting(@name varchar(30))
AS
BEGIN
	Print 'Welcome to ' +@name
END
GO

Exec prcgreeting 'Yashwanth'
Go

Exec prcgreeting 'Revti' 
GO

Create proc prcCalc @a INT,@b INT
AS
BEGIN
   Declare
	   @c INT
   BEGIN
      set @c = @a + @b 
	  print 'Sum is  ' +convert(varchar,@c)
   END
END
Go

Exec prcCalc 12,5  
Go

Create proc prcAgentCount
AS
BEGIN
	declare @count INT
	select @count=Count(*) from Agent 
	print 'Total Recods from Agent is  ' +Convert(varchar(30),@count)
END
GO

Exec prcAgentCount 
Go
