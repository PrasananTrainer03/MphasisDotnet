-- Stored Procedure to Search Record by Empno 

if exists(select * from sysobjects where name='PrcEmpMphasisSearch')
Drop proc PrcEmpMphasisSearch
GO

Create Proc PrcEmpMphasisSearch 
							@empno INT
AS
BEGIN
	Declare
		@name varchar(30),
		@dept varchar(30),
		@desig varchar(30),
		@basic INT
	BEGIN
	if exists(select * from EmployMphasis where empno=@empno)
	BEGIN
		select 
			@name=Name,
			@dept=Dept,
			@desig=Desig,
			@basic=Basic 
		from EmployMphasis Where Empno=@empno
		Print 'Name is ' +@name 
		print 'Department is  ' +@dept 
		Print 'Designation is ' +@desig
		Print 'Basic is  ' +convert(varchar(15),@basic)
	END
	ELSE 
	BEGIN
		Print 'Record Not Found...'
	END 
	END
END
GO

Exec PrcEmpMphasisSearch 52 
GO
