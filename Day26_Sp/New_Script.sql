--Create Database practicesp
--Go

use practicesp
GO

if exists(select * from sysobjects where name='Employ') 
Drop Table Employ
GO

Create Table Employ
(
   Empno INT IDENTITY(1,1)
   constraint pk_employ_empno primary key,
   Name varchar(30),
   Gender varchar(10),
   Dept varchar(30),
   Desig varchar(30),
   Basic numeric(9,2)
)
GO

Insert into Employ(Name,Gender,Dept,Desig,Basic) 
values('Supriya','Female','Dotnet','Programmer',95923),
('vasantha','Female','Angular','Expert',99234),
('Sumeet','Male','UI','Designer',99211),
('Rakesh','Male','Dotnet','Expert',89442),
('Saurabh','Male','Angular','Programmer',99244) 
GO

if exists(select * from sysobjects where name='prcEmployShow') 
Drop Proc PrcEmployShow
GO

Create Proc prcEmployShow
AS
BEGIN
	select * from Employ 
END
GO

if exists(select * from sysobjects where name='prcEmploySearch') 
Drop Proc PrcEmploySearch
Go

Create Proc prcEmploySearch
						@empno INT
AS
BEGIN
	select * from Employ where empno=@empno 
END
GO


--exec prcEmploySearch 1 

if exists(select * from sysobjects where name='prcEmployInsert') 
Drop Proc prcEmployInsert
Go

Create proc prcEmployInsert
					@empno INT OUTPUT,
					@name varchar(30),
					@gender varchar(30),
					@dept varchar(30),
					@desig varchar(30),
					@basic int
AS
BEGIN
	Insert into Employ(Name,Gender,Dept,Desig,Basic) 
		values(@name,@gender,@dept,@desig,@basic)
	select @empno=SCOPE_IDENTITY()
END
GO

if exists(select * from sysobjects where name='prcEmployDelete') 
Drop Proc prcEmployDelete
Go


Create proc prcEmployDelete 
						@empno INT
AS
BEGIN
	Delete From Employ Where Empno=@empno 
END
GO


--select * from Employ 
--GO


--select @@identity 

--select SCOPE_IDENTITY()

if exists(select * from sysobjects where name='prcEmployOutExample') 
Drop Proc prcEmployOutExample
Go

Create Proc prcEmployOutExample
						@empno INT,
						@name varchar(30) OUTPUT,
						@gender varchar(10) OUTPUT,
						@dept varchar(30) OUTPUT,
						@desig varchar(30) OUTPUT,
						@basic INT OUTPUT
AS
BEGIN
  select @name=Name, @gender=Gender,
		@dept=Dept,@desig=Desig,@basic=Basic
	from Employ Where Empno=@empno
END
GO