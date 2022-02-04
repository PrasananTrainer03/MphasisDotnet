-- Date Functions 

getdate() : Used to display todays date 

select getdate()


select convert(varchar,getdate(),1);

select convert(varchar,getdate(),2);


select convert(varchar,getdate(),3);


select convert(varchar,getdate(),102);


select convert(varchar,getdate(),101);

datepart() : used to display specific portion of given dates 

select datepart(dd,getdate());
select datepart(mm,getdate());
select datepart(yy,getdate());
select datepart(dw,getdate());
select datepart(qq,getdate());
select datepart(dy,getdate());
select datepart(wk,getdate());
select datepart(hh,getdate());
select datepart(mi,getdate());
select datepart(ss,getdate());

datename() : used to display in string format 

select datename(dw,getdate());

select datename(mm,getdate());

dateadd() : Used to add no.of months/years/days to the given date 

select DATEADD(dd,1,getdate());


select dateadd(mm,1,getdate());

select dateadd(yy,1,getdate());

datediff() : Used to display difference between two-dates 

select DATEDIFF(dd,'09/03/1995',getdate());
select DATEDIFF(mm,'09/03/1995',getdate());
select DATEDIFF(yy,'09/03/1995',getdate());
