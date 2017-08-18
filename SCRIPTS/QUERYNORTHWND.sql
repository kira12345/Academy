Select distinct country From Customers
Select count(distinct country) From Customers
Select*from Customers;
Select*from Products;
select* from Customers where country='Mexico'
select count(distinct country) from Customers WHERE country='UK';
Select count(Customers) as "Total Custumers" From Customers WHERE country='UK'

Select*from Customers where PostalCode between '1010' and '1012' 
Select*from Customers where CustomerID like 'AN%'
Select*from Customers where CompanyName like'%CO%'
Select*from Customers where CompanyName like'%CA'
Select*from Customers where Country IN('Mexico','Germany','Spain') ORDER BY COUNTRY ASC

Insert Into Customers(CustomerID,CompanyName, Country) values('ACC','C# Academy','Accenture')  
Insert Into Customers(CustomerID,CompanyName, Country) values('ACC2','C# Academy','Accenture')  
Select*from Customers where CustomerID='ACC2'

SELECT *FROM Customers WHERE CustomerID LIKE('ACC%');
UPDATE Customers set ContactName='Contact 1',City='Monterrey' WHERE CustomerID='ACC'
UPDATE Customers SET Country='Mexico' WHERE CustomerID='ACC' or CustomerID='ACC2'
DELETE FROM Customers WHERE CustomerID='ACC2'

SELECT MAX(Products.UnitPrice) AS "PRODUCT PRICE" FROM PRODUCTS 
SELECT MIN(Products.UnitPrice) AS "PRODUCT PRICE" FROM PRODUCTS 

INSERT INTO Employees(LastName,FirstName)
SELECT CompanyName, ContactName From Customers where CustomerID='ACC'

Select*From Employees
select*from Employees where LastName='C# Academy'

Select e.EmployeeID,(e.FirstName + ''+e.LastName) as Name, o.OrderID,o.OrderDate From  Employees e
INNER JOIN Orders o ON o.EmployeeID =e.EmployeeID


Select e.EmployeeID,(e.FirstName + ''+e.LastName) as Name, o.OrderID,o.OrderDate, c.CompanyName,c.Country From  Employees e
INNER JOIN Orders o ON o.EmployeeID =e.EmployeeID INNER JOIN Customers c ON o.CustomerID=c.CustomerID ORDER BY c.Country

Select e.EmployeeID,(e.FirstName + ''+e.LastName) as Name, o.OrderID,o.OrderDate, c.CompanyName,c.Country From  Employees e
INNER JOIN Orders o ON o.EmployeeID =e.EmployeeID INNER JOIN Customers c ON o.CustomerID=c.CustomerID ORDER BY c.Country

Select Customers.CompanyName,Orders.OrderID
from Customers
left join Orders on Customers.CustomerID=Orders.CustomerID
order by Customers.CompanyName

Select Customers.CompanyName,Orders.OrderID
from Customers
right join Orders on Customers.CustomerID=Orders.CustomerID
order by Customers.CompanyName

SELECT COUNT(CustomerID) as "Customer By Country",Country, City 
FROM Customers 
GROUP BY Country, City
ORDER BY COUNT(CustomerID) DESC, Country, City;

Use NORTHWND

SELECT COUNT(ProductID) AS "Products have"
FROM Products
GROUP BY CategoryID

SELECT COUNT(CategoryID) AS "Products have",CategoryName
FROM Categories
GROUP BY CategoryName 

SELECT Orders.OrderID, Products.ProductName, Suppliers.CompanyName
FROM Products INNER JOIN Suppliers ON Products.ProductID=Suppliers.SupplierID 
INNER JOIN Orders ON Suppliers.SupplierID=Orders.OrderID

--NUMBERS OF ORDER BY SUPPLIERS 
--DISPLAYS COMPANYNAME,PRODUCTNAME ON THE 1997 
--FORMAT DATE YYYY-MM-DD

SELECT COUNT(o.OrderID) as "Total orders", s.CompanyName, p.ProductName from Orders o
INNER JOIN [Order Details] OD ON od.OrderID=o.OrderID
INNER JOIN Products P ON p.ProductID=od.ProductID
INNER JOIN Suppliers s ON s.SupplierID=p.SupplierID
WHERE YEAR(O.OrderDate)='1997'
--WHERE o.OrderDate between '1997-01-01' and o.OrderDate < '1998'
GROUP BY o.OrderID,s.CompanyName, p.ProductName