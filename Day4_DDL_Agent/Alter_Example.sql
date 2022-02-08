use mphasispractice
Go

if exists(select * from sysobjects where name='EmpNew') 
Drop Table EmpNew;

Create Table EmpNew
(
   Empno INT,
   basic numeric(9,2)
);

/* Adding Name field to the table */ 

ALTER Table EmpNew Add Name varchar(30) 
Go

Alter Table EmpNew Add Dept varchar(30)
Go

Alter Table EmpNew Add Desig varchar(30)
GO

Alter Table EmpNew Add gender varchar(10)
Go

/* How to Add Primary Key */ 


Alter table EmpNew Alter Column Empno INT NOT NULL
GO

Alter table EmpNew Add constraint pk_empnew_Empno primary key(empno)
GO


/* Modify Gender field size to 15 chars */

Alter Table EmpNew Alter Column Gender varchar(15) 
GO

/* Drop the Column gender from the EmpNew table */ 

Alter Table Empnew Drop Column gender 
GO

Sp_help EmpNew;
