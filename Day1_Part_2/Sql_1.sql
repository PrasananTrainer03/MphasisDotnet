-- Display list of tables available in current database 

select * from INFORMATION_SCHEMA.tables 

-- Display information about EMP Table 

sp_help EMP

-- Display all records from Emp table 

select * from Emp 

-- Display Empno, Nam, Basic From Emp table 

select Empno, Nam, Basic from  Emp 

-- Project Operator as we are projecting Particular columns 

-- Where Clause : Used to filter the table records 

-- Display all records whose basic > 50000 

select * from Emp where basic > 50000
GO

-- Display all records whose Nam is 'Swapna' 

select * from Emp where nam='Swapna';

-- Display all records whose Dept is 'Dotnet'

select * from Emp where dept='Dotnet'

-- Between...AND : used to display records from Start to end range 

-- Display all records whose basic from 50000 to 80000 

select * from Emp where basic between 50000 and 80000;

select * from Emp where basic NOT between 50000 and 80000;

-- IN Clause : Used to display records w.r.t. Multiple column values. 

-- Display all records from Emp where dept is dotnet or java 

select * from Emp where Dept In('Dotnet','Java');

select * from Emp where Dept NOT In('Dotnet','Java');

select * from emp where nam in('Swapna','Kalyan','Ashima');

-- LIKE : used to display records w.r.t. Wild cards 

-- Display all records whose name start with 'S'


select * from emp where nam like 'S%';

-- Display all records whose name ends with 'a'

select * from Emp where nam like '%a';

-- Order By : Used to display values w.r.t. Specific field(s) 
-- in ascending or descending order 

select Empno, nam, Dept,Basic 
From Emp 
Order By Basic 

select Empno, nam, Dept,Basic 
From Emp 
Order By Basic DESC 

select Empno, nam, Dept,Basic 
From Emp 
Order By Dept,Nam 


select Empno, nam, Dept,Basic 
From Emp 
Order By Dept,Nam,Basic 

-- Distinct : used to eliminate duplicates at the time of display

select dept from Emp;

select * from Emp 

select distinct dept from Emp; 

-- Write a query to display manager name as 
  -- if dept is dotnet then 'Arka Mitra'
  -- if dept is Java then 'Spoorthi'
  -- if dept is SQL then 'Srikanth'
  -- else 'Divya'

select Empno,Nam,Dept,Basic, 
CASE DEPT 
    WHEN 'Dotnet' THEN 'Arka Mitra'
	WHEN 'Java' THEN 'Spoorthi'
	WHEN 'SQL' THEN 'Srikanth' 
	ELSE 'Divya'
END 'Manager'
From Emp 

select * from Agent;

select AgentId,FirstName,LastName,City, State, 
CASE MaritalStatus 
  WHEN 0 THEN 'Unmarried' 
  WHEN 1 THEN 'Married'
END 'Status'
from Agent 

select * from Policy
GO


select 
  PolicyID, AppNumber, AppDate,ModalPremium,PayMentModelID,
  CASE PayMentModelID 
	WHEN 1 THEN 'Yearly'
	WHEN 2 THEN 'Half-Yearly'
	WHEN 3 THEn 'Quarterly'
  END 'Status'
from Policy
GO

-- Write a query in Emp table if Dept is java increase basic by 1000
					--		if dept is dotnet increase by 1500
						--    if dept is sql increase by 2000
						--	else increment by 0 

select 
  Empno,Nam,Dept,Basic,
  CASE DEPT 
     WHEN 'JAVA' THEN Basic+1000
	 WHEN 'DOTNET' THEN Basic+1500
	 WHEN 'SQL' THEN BASIC+2000 
	 ELSE Basic 
  END 'Updated Basic'
from Emp 
GO
