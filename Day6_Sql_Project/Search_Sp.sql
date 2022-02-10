if exists(select * from sysobjects where name='prcEmpMphasisSearch') 
Drop proc PrcEmpMphasisSearch
Go

create proc prcEmpMphasisSearch
							@empno INT
AS
BEGIN
	declare @name varchar(30),
			@dept varchar(30),
			@desig varchar(30),
			@basic INT
	if exists(select * from EmployMphasis where empno=@empno) 
	BEGIN
	   select 
		@name=Name,@dept=Dept,@desig=Desig,@basic=Basic
	   from EmployMphasis Where Empno=@empno
	   print 'Name is ' +@name 
	   print 'Department is ' +@dept 
	   print 'Designation is ' +@desig 
	   print 'Basic is ' +convert(varchar(30),@basic)
	END
	ELSE 
	BEGIN
	  Print 'Record Not Found...'
	END
END

exec prcEmpMphasisSearch 445
GO