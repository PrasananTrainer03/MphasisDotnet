
select AD.AgentID,Ad.FirstName,AD.LastName,
PD.PolicyID,PD.AppNumber,PD.AnnualPremium,PD.ModalPremium
FROM 
(select AgentID,FirstName,LastName,City,State from Agent) AD,
(select PolicyID,AppNumber,ModalPremium,AnnualPremium,PayMentModelID from Policy)PD

select * from Agent;

