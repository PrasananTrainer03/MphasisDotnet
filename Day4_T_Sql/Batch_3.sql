declare @name varchar(30)
set @name='Arka mitra'
print 'Name is ' +@name
GO

declare
	@a int,
	@b int,
	@c int
set @a=12
set @b=15
set @c=@a+@b 
print 'Sum is  ' +convert(varchar(10),@c)
GO

select * from Employ;

select * from Agent;

declare 
	@totalRecords INT
begin
   select @totalRecords=count(*) from Agent 
   Print 'Total Records are  ' +convert(varchar(10),@totalRecords)
end

declare
	@agentId INT,
	@FirstName varchar(30),
	@LastName varchar(30),
	@City varchar(30),
	@State varchar(30),
	@SSn varchar(30)
begin
   set @agentId=21
   select 
	 @FirstName=FirstName,
	 @LastName=LastName,
	 @City=City,
	 @State=State,
	 @SSN=SSN
   from Agent Where AgentId=@agentId 
   print 'First Name  ' +@FirstName 
   print 'Last Name  ' +@LastName
   print 'City  ' +@City
   print 'State ' +@state 
   print 'SSN ' +@ssn 
end
GO

declare
	@agentId INT,
	@FirstName varchar(30),
	@LastName varchar(30),
	@City varchar(30),
	@State varchar(30),
	@SSn varchar(30)
begin
   set @agentId=3
   if exists(select * from Agent where agentId=@agentId) 
   BEGIN
   select 
	 @FirstName=FirstName,
	 @LastName=LastName,
	 @City=City,
	 @State=State,
	 @SSN=SSN
   from Agent Where AgentId=@agentId 
   print 'First Name  ' +@FirstName 
   print 'Last Name  ' +@LastName
   print 'City  ' +@City
   print 'State ' +@state 
   print 'SSN ' +@ssn 
   END
   ELSE 
   BEGIN
	Print 'Agent Record not Found...'
   END
end
GO

