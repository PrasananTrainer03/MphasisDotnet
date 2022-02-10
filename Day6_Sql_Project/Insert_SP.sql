if exists(select * from sysobjects where name='PrcEmpMphasisInsert') 
Drop Proc prcEmpMphasisInsert 
GO

Create proc PrcEmpMphasisInsert
				@name varchar(30),
				@dept varchar(30),
				@desig varchar(30),
				@basic INT
AS
BEGIN
	Insert into EmployMphasis(Name,Dept,Desig,Basic) 
			values(@name,@dept,@desig,@basic)
END
Go

exec PrcEmpMphasisInsert 'Srikanth','Dotnet','Programmer',45992 
GO

select * from EmployMphasis
Go
