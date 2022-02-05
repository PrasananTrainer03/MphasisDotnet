-- Example for INNER JOIN 

select * from Agent;

select * from Policy;

select A.AgentID,FirstName,LastName,City,State,
P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
from Agent A INNER JOIN AgentPolicy AP 
ON A.AgentID=AP.AgentID
INNER JOIN Policy P 
ON P.PolicyID=AP.PolicyID

-- Example for LEFT JOIN 

select A.AgentID,FirstName,LastName,City,State,
P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
from Agent A LEFT JOIN AgentPolicy AP 
ON A.AgentID=AP.AgentID
LEFT JOIN Policy P 
ON P.PolicyID=AP.PolicyID

-- Example for RIGHT JOIN

select A.AgentID,FirstName,LastName,City,State,
P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
from Agent A RIGHT JOIN AgentPolicy AP 
ON A.AgentID=AP.AgentID
RIGHT JOIN Policy P 
ON P.PolicyID=AP.PolicyID

-- Example for FULL JOIN 

select A.AgentID,FirstName,LastName,City,State,
P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
from Agent A FULL JOIN AgentPolicy AP 
ON A.AgentID=AP.AgentID
FULL JOIN Policy P 
ON P.PolicyID=AP.PolicyID

