
select 
CASE WHEN M.Manager IS NULL THEN 'No Manager'
ELSE M.Manager
END 'Manager',
M.MgrId,M.EmpID,M.EmpName
from
  (select E1.Empno MgrId,
  E1.Nam Manager ,
  E2.Empno EmpID,
  E2.Nam EmpName
  from EmpMgr E1 RIGHT JOIN EmpMgr E2 
  ON E1.Empno = E2.MgrNo) M