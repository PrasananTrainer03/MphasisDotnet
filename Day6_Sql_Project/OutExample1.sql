if exists(select * from sysobjects where name='PrcEmpMphasisOut') 
Drop Proc PrcEmpMphasisOut
GO

Create proc PrcEmpMphasisOut
						@empno INT,
						@name varchar(30) OUTPUT,
						@dept varchar(30) OUTPUT,
						@desig varchar(30) OUTPUT,
						@basic INT OUTPUT
AS
BEGIN
	if exists(select * from EmployMphasis Where empno=@empno)
	BEGIN
	   select @name=Name,@dept=Dept,@desig=Desig,@basic=Basic
	   from EmployMphasis Where Empno=@empno
		return 1
	END
	ELSE 
	BEGIN
		return 0
	END
END
GO
