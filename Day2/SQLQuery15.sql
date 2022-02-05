select Empno,Nam,Dept,Basic from Emp 
where basic between 30000 and 70000

select Empno,Nam,Dept,Basic from Emp 
where basic between 50000 and 90000

-- UNION 

select Empno,Nam,Dept,Basic from Emp 
where basic between 30000 and 70000
UNION
select Empno,Nam,Dept,Basic from Emp 
where basic between 50000 and 90000

-- UNION ALL

select Empno,Nam,Dept,Basic from Emp 
where basic between 30000 and 70000
UNION ALL
select Empno,Nam,Dept,Basic from Emp 
where basic between 50000 and 90000

-- INTERSECT

select Empno,Nam,Dept,Basic from Emp 
where basic between 30000 and 70000
INTERSECT
select Empno,Nam,Dept,Basic from Emp 
where basic between 50000 and 90000

-- MINUS 

select Empno,Nam,Dept,Basic from Emp 
where basic between 30000 and 70000
EXCEPT
select Empno,Nam,Dept,Basic from Emp 
where basic between 50000 and 90000

