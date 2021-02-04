--Select
--ANSII 
 Select ContactName , CompanyName, City from Customers 

 Select * from  Customers where city = 'Berlin'

 -- case insensitive( Büyük küçük harf duyarsız)
 sELECT * from Products where CategoryID=1 or CategoryID=3


select * from Products order by CategoryID
 
 select * from products where CategoryID=1 order by UnitPrice desc 

 select count(*) from Products