if exists(select * from sysobjects where name='prcEmpMphasisDelete') 
Drop proc prcEmpMphasisDelete
Go

create proc prcEmpMphasisDelete
							@empno INT
AS
BEGIN
	
	if exists(select * from EmployMphasis where empno=@empno) 
	BEGIN
	   Delete from EmployMphasis Where empno=@empno
	END
	ELSE 
	BEGIN
	  Print 'Record Not Found...'
	END
END

exec prcEmpMphasisDelete 8
GO