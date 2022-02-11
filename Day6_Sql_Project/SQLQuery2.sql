/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [empno]
      ,[Name]
      ,[Dept]
      ,[Desig]
      ,[Basic]
  FROM [mphasispractice].[dbo].[EmployMphasis]


  sp_help EmployMphasis;