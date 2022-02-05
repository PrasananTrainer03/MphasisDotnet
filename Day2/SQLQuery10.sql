select CASE 
WHEN AD.Rno=1 THEN AD.FirstName ELSE ''
END Firstname,
AD.City,AD.State,AD.PolicyID,AD.AppNumber,AD.AnnualPremium,AD.ModalPremium
from 
(select FirstName,City,State,
P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium,
ROW_NUMBER() OVER(Partition BY FirstName ORDER BY FIRSTNAME) Rno
from Agent A INNER JOIN AgentPolicy AP 
ON A.AgentID=AP.AgentID
INNER JOIN Policy P 
ON P.PolicyID=AP.PolicyID)AD