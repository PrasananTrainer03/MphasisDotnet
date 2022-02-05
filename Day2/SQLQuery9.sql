select * from Emp;

-- Display all records who have one part name 

select Empno,Nam,dept,Basic,
len(nam)-len(replace(nam,' ','')) spaces
from Emp 

select ED.Empno,ED.nam,ED.basic
from
(select Empno,Nam,dept,Basic,
len(nam)-len(replace(nam,' ','')) spaces
from Emp)ED 
WHERE ED.spaces=0


select ED.Empno,ED.nam,ED.basic
from
(select Empno,Nam,dept,Basic,
len(nam)-len(replace(nam,' ','')) spaces
from Emp)ED 
WHERE ED.spaces=1


select ED.Empno,ED.nam,ED.basic
from
(select Empno,Nam,dept,Basic,
len(nam)-len(replace(nam,' ','')) spaces
from Emp)ED 
WHERE ED.spaces=2
