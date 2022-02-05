select * from Agent;

row_number() : Used to generate row_number() on the field specified 

select PolicyID,AppNumber,ModalPremium,AnnualPremium,
ROW_NUMBER() OVER(Order By AnnualPremium desc)
from Policy

Rank() : Used to generate rank of the fields specified 

select PolicyID,AppNumber,ModalPremium,AnnualPremium,
RANK() OVER(Order By AnnualPremium desc)
from Policy

dense_rank() : Used to generate sequential rank number 

select PolicyID,AppNumber,ModalPremium,AnnualPremium,
Dense_RANK() OVER(Order By AnnualPremium desc)
from Policy

select PolicyID,AppNumber,ModalPremium,AnnualPremium,
ROW_NUMBER() OVER(Partition by AnnualPremium Order By AnnualPremium)
from Policy


select Empno,Nam,Dept,basic,
ROW_NUMBER() OVER(partition by Dept order by Dept)
from Emp;

