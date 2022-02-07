-- Subquery 

select max(basic) from Emp;

select max(annualpremium) from Policy;

-- Display name of employee who is getting max salary 

-- select nam from Emp where basic=max(basic) 

select nam from Emp where basic = (select max(basic) from Emp);

-- Display name of Employee who is getting min. salary 
select min(basic) from Emp;

select nam from Emp where basic = (select min(basic) from Emp);

-- Display 2nd Max Salary 

select max(basic) from Emp where basic < (select max(basic) from Emp);

-- Display name of person who is getting 2nd max. salary 

select nam from emp where basic = (
select max(basic) from Emp where basic < (select max(basic) from Emp))

-- Display 2nd min. salary

-- Display name of employee who is getting 2nd min. salary 

-- Display Agents who did business (Which is there in Agent and AgentPolicyTables) 

select * from Agent where AgentId=(select AgentId from AgentPolicy)

select * from Agent where AgentId=ANY(select distinct AgentId from AgentPolicy)

-- Display Policy Details for which business happend (Which is there in Policy and AgentPolicy Tables) 

select * from Policy where policyId=ANY(select distinct policyId from AgentPolicy)

-- Display Idle Agents (Which is there in Agent table and not there in AgentPolicy Table) 

select * from Agent where AgentID <> ALL(select distinct Agentid from AgentPolicy)

-- Display Idle Policies (Which is there Policy Table and not there in AgentPolicy Table) 

select * from Policy where PolicyID <> ALL (select Distinct PolicyID from AgentPolicy)
