-- Aggregate Functions 

-- sum() : used to perform sum operation on the given field 

select sum(basic) from Emp;

-- Avg() : used to perform avg operation on the given field 

select avg(basic) from Emp;

--max() : Displays max. value 

select max(basic) from Emp;

--min() : Displays min. value 

select min(basic) from Emp;

-- count(*) : Used to display total no.of records avaialble in the table 

select count(*) from Emp;

select sum(annualpremium) from Policy;

select avg(annualpremium) from Policy; 

select max(annualpremium) from Policy;

select min(annualpremium) from Policy;

select count(*) from Policy;