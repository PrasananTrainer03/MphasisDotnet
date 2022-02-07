use master 
go

drop database mphasispractice 
go

create database mphasispractice
go

use mphasispractice
GO

if exists(select * from sysobjects where name='Department') 
Drop Table Department 
GO
/* *******************************************************************************************
								Creating Department Table
   *******************************************************************************************
*/

Create Table Department
(
   DeptCode INT 
   constraint PK_Department_DeptCode Primary Key,
   DeptHead varchar(30)
)
GO

/* ********************************************************************************
					Inserting Data into Department Table
   ********************************************************************************
*/

Insert into Department(DeptCode,DeptHead) values(1,'Yashwanth'),
												(2,'Sushree'),
												(3,'Naveen'),
												(4,'Divya'),
												(5,'Jayasurya')
GO

/* ***********************************************************************************************
								Creating Employ Table
   ***********************************************************************************************
*/

if exists(select * from sysobjects where name='Employ') 
Drop Table Employ 

Create Table Employ
(
   Ecode INT 
   constraint pk_employ_ecode primary key,
   DeptCode INT
   constraint fk_employ_deptCode REFERENCES Department(DeptCode),
   Ename varchar(30),
   Gender varchar(10) 
   constraint chk_employ_gender check(Gender IN('Male','Female'))
)
GO
/* *******************************************************************************************
							Inserting Data into Employ Table
   *******************************************************************************************
*/

Insert into Employ(Ecode,DeptCode,Ename,Gender) 
		values(1,1,'Peraiah','Male'),
			  (2,1,'Lokesh','Male'),
			  (3,3,'Madhusree','Female'),
			  (4,3,'Rashmi','Female'),
			  (5,4,'Jhansi','Female'),
			  (6,4,'Naveen','Male'),
			  (7,3,'Rakesh','Male'),
			  (8,1,'Sanjay','Male'),
			  (9,4,'Sakshi','Female'),
			  (10,4,'Akhila','Female')
GO

/* ************************************************************************************************
									Creating Project Table
   ************************************************************************************************
*/

if exists(select * from sysobjects where name='Project') 
Drop Table Project 
Go

Create Table Project
(
   ProjCode INT,
   Ecode INT
   constraint fk_project_ecode references Employ(Ecode),
   constraint pk_project_projcode_ecode primary key(projcode,ecode),
   Hours INT
)
Go

Insert into Project(ProjCode,Ecode,Hours) values(1,1,66),
											    (1,3,88),
												(2,1,88),
												(1,2,88),
												(2,4,77),
												(2,5,88),
												(2,3,77),
												(4,2,77),
												(4,3,100)
GO

