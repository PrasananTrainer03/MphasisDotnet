/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Empno]
      ,[Nam]
      ,[Basic]
      ,[MgrNo]
  FROM [sqlpractice].[dbo].[EmpMgr]


  select E1.Empno 'Manager ID',
  E1.Nam 'Manager Name',
  E2.Empno 'Employee ID',
  E2.Nam 'Employee Name'
  from EmpMgr E1 RIGHT JOIN EmpMgr E2 
  ON E1.Empno = E2.MgrNo