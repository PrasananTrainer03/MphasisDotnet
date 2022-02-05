-- Group By : Used to generate summary reports 

select Dept,sum(basic) from Emp
group by dept
GO

select Dept,avg(basic) from Emp
group by dept
GO

select Dept,MAX(basic) from Emp
group by dept
GO

select Dept,MIN(basic) from Emp
group by dept
GO


select Dept,COUNT(*) from Emp
group by dept
GO

-- Having Clause : Used to check conditions on aggregate fields 

select Dept,COUNT(*) from Emp
group by dept
having count(*) > 1
GO

select Dept,sum(basic) from Emp
group by dept
having sum(basic) > 100000
GO

select Dept,sum(basic) from Emp
WHERE DEPT IN('DOTNET','Dotnet MVC','JAVA')
group by dept
having sum(basic) > 100000
ORDER BY DEPT DESC
GO

