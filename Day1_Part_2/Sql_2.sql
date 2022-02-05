-- String Funcitons 

-- Charindex : Displays the first occurrence of given char 

select charindex('e','keerthi')

-- len() : used to display the length of string 

select len('arka mitra') 

select Empno,Nam,len(nam) from Emp 
Go

-- reverse() : Used to display string in reverse order 

select Nam, reverse(nam) from Emp 
GO

-- LEFT() : Displays no.of left-side chars 

select left('Welcome',4)

-- RIGHT() : Display no.of right-side chars

select RIGHT('Welcome',4)

-- Substring() : used to display part of string 

select SUBSTRING('welcome to sql',3,5) 

-- lower() : displays in lower case 
-- upper() : Displays in upper case 

select lower('Abhishek'),upper('Abhishek') 

-- Replace() : Used to replace old char/word with new char/word in 
-- all occurrences 

select replace('Java Training','Java','Sql');

select 'abhishek' + ' Anand'

select nam + dept from Emp 