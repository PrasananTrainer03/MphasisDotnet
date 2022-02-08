if exists(select * from sysobjects where name='PrcEmployInsert')
Drop Proc PrcEmployInsert 
Go

Create Proc PrcEmployInsert
					@Name varchar(30),
					@Dept varchar(30),
					@Desig varchar(30),
					@Basic INT
AS
BEGIN
	Insert into EmployMphasis(Name,Dept,Desig,Basic) 
			Values(@name,@Dept,@Desig,@Basic)
END
GO

Exec PrcEmployInsert 'Sanjay','Dotnet','Programmer',99921
GO

select * from EmployMphasis 
GO

