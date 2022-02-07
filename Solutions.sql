select Ecode from project where Hours >= 100

select * from Employ where Ecode = ANY(select Ecode from project 
where hours >=100);

select * from project;

select ename from Employ where ecode = ANY(
select ecode from project 
group by ecode
having count(*) > 1);

select * from Employ where ecode = ANY 
(select ecode from project)

select * from Employ where ecode <> ALL 
(select ecode from Project)

select D.DeptCode,Ename,P.ProjCode,Hours
from Department D INNER JOIN Employ E 
ON D.DeptCode=E.DeptCode 
INNER JOIN Project P ON 
E.Ecode = P.Ecode
