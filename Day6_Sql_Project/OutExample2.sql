if exists(select * from sysobjects where name='prcEmpOutExec') 
Drop Proc PrcEmpOutExec 
GO

Create Proc prcEmpOutExec
					@empno INT
AS
BEGIN
	declare		
		@name varchar(30),
		@dept varchar(30),
		@desig varchar(30),
		@basic INT,
		@ret INT
	BEGIN
	   exec @ret=PrcEmpMphasisOut @empno,@name OUTPUT,
							@dept OUTPUT,@desig OUTPUT,@basic OUTPUT 
	   if @ret=1
	   BEGIN
		print 'Name ' +@name 
		print 'Department ' +@dept
		print 'Designation ' +@desig
		print 'Basic ' +convert(varchar(10),@basic)
	   END
	   ELSE
	   BEGIN
		Print 'Record Not Found...'
	   END
	END
END

exec PrcEmpOutExec 34
GO

