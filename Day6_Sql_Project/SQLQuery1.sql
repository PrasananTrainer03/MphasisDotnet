SELECT DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)) 

select dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))

select datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))))

select dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))) 'First Friday',
dateadd(dd,7,dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))))) 'Second Friday',
dateadd(dd,7,dateadd(dd,7,dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))))) 'Third Friday',
dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))))))) 'Fourth Friday', 
--month(dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
--dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))))))))),
-- month(getdate()),
case 
   when month(getdate())=month(dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0))))))))) then 
dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,7,dateadd(dd,6-datepart(dw,dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))),
dateadd(dd,1,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE()),0)))))))) 
end 'Fifth Friday'



