use mphasispractice
go

if exists(select * from sysobjects where name='AgentPolicy')
Drop Table AgentPolicy 


if exists(select * from sysobjects where name='Agent') 
Drop Table Agent 
Go

/* **********************************************************
			      Creating Agent Table 
   **********************************************************
*/

Create Table Agent 
(
  AgentId INT IDENTITY(1,1)
  constraint pk_agent_agentId primary Key,
  FirstName varchar(30) 
  constraint chk_Agent_FirstName 
  check(FirstName not LIKE '%[^a-zA-Z]%'),  
  MI varchar(1),
  LastName varchar(30)  
  constraint chk_Agent_LastName 
  check(LastName not LIKE '%[^a-zA-Z]%'),
  FullName varchar(80),
  Gender varchar(10)
  constraint chk_agent_gender 
  check(gender IN('Male','Female')),
  dob datetime 
  constraint chk_agent_dob check(dob <= getdate()), 
  ssn varchar(30) 
  constraint chk_agent_ssn check(SSN like '[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'),
  MaritalStatus INT
  constraint chk_agent_maritalstatus check(MaritalStatus IN(0,1)),
  Address1 varchar(30),
  Address2 varchar(30),
  City varchar(20),
  state varchar(20), 
  Zipcode varchar(20),
  country varchar(30),
  InsertedOn datetime 
  constraint def_Agent_InsertedOn default getdate(), 
  InsertedBy varchar(30)
  constraint def_agent_InsertedBy default system_user,
  UpdatedOn dateTime,
  UpdatedBy varchar(30),
  DeletedOn DateTime,
  DeletedBy varchar(30)
)
Go

/*   ******************************************************************************************
			  						Inserting into Agent Table
     ******************************************************************************************
*/

Insert into Agent(FirstName,MI,LastName,Gender,DOB,SSN,MaritalStatus,
Address1,Address2,City,STATE,ZipCode,Country)
values('Sunitha','P','Premjee','Female','1/2/1988','434-55-3323',
1,'5th Avenue','Near Church','Parlin','NJ','434554','USA'),
('Pranitha','R','Reddy','Female','1/2/1986','324-55-2344',
1,'8th Mile','Sterling Heights','Detroit','MI','442345','USA'),
('Shavetha','D','Datta','Female','1/2/1980','643-34-4443',
0,'Dwaraka Nagar','5th Phase','NewDelhi','UP','438533','INDIA'),
('Shanthi','T','Tangvel','Female','12/03/1983','644-23-4534',
1,'Near Food Court','2nd Phase','Chicago','MI','483845','USA'),
('ashraf','V','Vahora','Male','1/1/1983','435-22-5212',
1,'8th Avenue','Church Road','Maywood','NJ','78434','USA'),
('Ramesh','L','Gole','Male','1/2/1981','643-34-7373',
0,'5th Phase','Sterling Heights','Detroit','MI','477843','USA'),
('Lavanya','S','K','FeMale','12-12-1988','335-44-2344',
0,'LIG B87','ASRAO NR','SECBAD','AP','500062','INDIA'),
('Murali','S','Krishna','Male','09-03-1986',
'234-44-2335',1,'RK HOstel','Ameerpet','HYDBAD','AP',
'500042','INDIA'),
('Raj','S','kumar','Male','12-12-1987',
'345-23-4211',0,'MadhaPur','Nr Cyber Towers','HYDBAD','AP',
'509244','INDIA'),
('Srimukha','S','Manchu','FeMale','09-03-1986',
'231-44-2335',0,'NRS','Madhapur','HYDBAD','AP',
'500042','INDIA'),
('Lalitha','S','B','FeMale','12-11-1987',
'341-23-4211',0,'KondaPur','Nr Stadium','HYDBAD','AP',
'509244','INDIA'),
('Rakesh','K','Chowdary','Male',
'1/2/1986','123-23-2444',1,'8th Mile','Church Road','Detroit',
'MI','484555','USA'),
('Rama','U','Rao','Male',
'1/2/1983','223-43-1444',1,'5th Mile','Ford Street','Chicago',
'NY','2484555','USA'),
('Madhuri','S','M','FeMale',
'12/12/1989','423-33-2444',1,'Beach Street','Univ Road','NewYork',
'CT','5484555','USA'),
('Prafulla','U','Rao','FeMale',
'1/2/1987','523-22-2644',1,'8th Mile','IBM Road','Detroit',
'MI','484555','USA'),
('Prasanna','P','Kumar','Male',
'09/03/1980','423-23-1444',1,'ASRAO NR','Good Luck Cafe','SECBAD',
'AP','500 062','INDIA') 
GO

Select * from Agent 
GO

/*  *****************************************************************************************
									 Creating Policy Table
	*****************************************************************************************
*/

if exists(select * from sysobjects where name='Policy') 
Drop Table Policy 

Create Table Policy
(
   PolicyID INT IDENTITY(1,1) constraint pk_policy_policyId primary key,
   AppNumber varchar(30),
   AppDate datetime,
   PolicyNumber varchar(30),
   AnnualPremium numeric(9,2),
   PaymentModeID int,
   ModalPremium numeric(9,2),
   InsertedOn DateTime
   constraint def_Policy_InsertedOn default getdate(),
   InsertedBy varchar(30) 
   constraint def_policy_InsertedBy default system_user,	
   UpdatedOn DateTime,
   UpdatedBy varchar(30),
   Deletedon DateTime,
   DeletedBy varchar(30) 
)
GO

/*  **********************************************************************************************
									Inserting Data into Policy Table  
	**********************************************************************************************
*/ 

INSERT INTO POLICY(APPNUMBER,APPDATE,POLICYNUMBER,
ANNUALPREMIUM,PAYMENTMODEID,MODALPREMIUM)
VALUES('A001','12/12/2010','C001',12000,2,2000),
('A002','12/12/2010','C002',20000,1,12000),
('A003','12/12/2010','C003',150000,1,20000),
('A004','01/02/2005','P001',22000,1,1000),
('A005','03/09/2009','S231',122000,2,22000),
('A006','02/12/2010','A131',232000,2,21000),
('A007','09/12/2007','P231',212000,2,23000),
('A008','03/09/2009','S231',122000,2,22000),
('A009','03/09/2009','I231',192000,1,24000)

GO

SELECT * From Policy 
GO


/* **********************************************************
			Creating AgentPolicy Table
   **********************************************************
*/

if exists(select * from sysobjects where name='AgentPolicy')
Drop Table AgentPolicy 

Create table AgentPolicy
(
    AgentID INT constraint fk_agentPolicy_AgentId references Agent(AgentID),
	PolicyID INT constraint fk_AgentPolicy_PolicyID references Policy(PolicyID)
	constraint pk_agentPolicy_agIdPolId primary key(AgentId,PolicyID),
	IsSplitAgent INT, 
	InsertedOn DateTime constraint def_agentPolicy_insertedON default getdate(),
	InsertedBy varchar(30) constraint def_agentpolicy_insertedBy default system_user
);

/* ***********************************************************
		  Inserting Data into AgentPolicy Table 
   ***********************************************************
*/ 

Insert into AgentPolicy(AgentID,PolicyID,IsSplitAgent) 
values(1,1,2),(1,3,1),(2,3,1),(2,1,1),(2,4,1),(2,5,1),
(4,1,2),(4,3,1),(5,1,2),(5,2,1)

Go

select * from AgentPolicy 
GO


