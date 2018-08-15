USE AdventureWorks
--------------------
SELECT * 
FROM Production.Product
--------------------
USE Blogging
--------------------
SELECT * 
FROM Post
--------------------
USE AdventureWorks
--------------------
SELECT *
FROM Production.Product
--------------------
SELECT * 
FROM Sales.SalesOrderHeader
-------------------
SELECT ProductId شناسه , Name AS نام, Color 'رنگ', ListPrice AS 'قیمت فروش'
FROM Production.Product
-------------------
SELECT ProductId, OrderQty, UnitPrice, UnitPriceDiscount
FROM Sales.SalesOrderDetail
-------------------
SELECT ProductId, OrderQty, UnitPrice, UnitPriceDiscount,
(OrderQty * (UnitPrice * (1 - UnitPriceDiscount))) 'LineTotal'
FROM Sales.SalesOrderDetail
-------------------
SELECT ProductId, OrderQty, UnitPrice, UnitPriceDiscount,
(OrderQty * (UnitPrice * (1 - UnitPriceDiscount))) 'LineTotal'
FROM Sales.SalesOrderDetail AS s
--------------------
SELECT Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY Name
--------------------
SELECT Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY Color DESC, Name
-------------------
SELECT TOP 10 Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY ListPrice DESC
-------------------
SELECT TOP 10 PERCENT Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT TOP 6 WITH TIES Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY Name
OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY
--------------------
DECLARE @PageNumber INT
DECLARE @RowsPerPage INT
SET @PageNumber = 2
SET @RowsPerPage = 20
SELECT Name, ProductId, Color, ListPrice, ProductSubCategoryId
FROM Production.Product
ORDER BY Name
OFFSET (@PageNumber - 1) * @RowsPerPage ROWS FETCH NEXT @RowsPerPage ROWS ONLY
--------------------
SELECT DISTINCT Color
FROM Production.Product
--------------------
SELECT DISTINCT TOP 5 ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT DISTINCT TOP 20 ListPrice, ProductID
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID < 10
--------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID < 800 AND ProductID > 780
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID BETWEEN 780 AND 800
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID = 777
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE ProductID != 4
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
--WHERE Name LIKE 'Adjustable%'
--WHERE Name LIKE '%Mountain%'
--WHERE Name LIKE '___Mountain%'
--WHERE Name LIKE 'H__Mountain%' 
WHERE Name LIKE 'H__Mountain%' AND Color = 'Black' AND ListPrice < 1000
---------------------
SELECT ProductId, Name, Color, ListPrice, StandardCost
FROM Production.Product
WHERE Name LIKE '%\_%' ESCAPE '\'
---------------------
SELECT ProductId, [Name], Color, ListPrice, StandardCost
FROM Production.Product
---------------------
SELECT BusinessEntityId,YEAR(GETDATE()) - YEAR(BirthDate) 'Age'
FROM HumanResources.Employee
---------------------
SELECT GETDATE()
---------------------
SELECT COUNT(*)
FROM Production.Product
---------------------
SELECT COUNT(Color)
FROM Production.Product
---------------------
SELECT LineTotal
FROM Sales.SalesOrderDetail
---------------------
SELECT SUM(LineTotal) 'SalesTotal'
FROM Sales.SalesOrderDetail
---------------------
SELECT MIN(UnitPrice), MAX(UnitPrice), AVG(UnitPrice), VAR(UnitPrice)
FROM Sales.SalesOrderDetail
---------------------
SELECT AVG(OrderQty)
FROM Sales.SalesOrderDetail
WHERE ProductID = 777
--------------------
SELECT ProductId, AVG(OrderQty)
FROM Sales.SalesOrderDetail
GROUP BY ProductId
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', COUNT(BusinessEntityID) 'EmployeesCount'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate)
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', COUNT(BusinessEntityID) 'EmployeesCount'
FROM HumanResources.Employee
WHERE YEAR(HireDate) = 2007
GROUP BY YEAR(HireDate), MONTH(HireDate)
HAVING COUNT(BusinessEntityID) < 50
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', COUNT(BusinessEntityID) 'EmployeesCount'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate)
HAVING COUNT(BusinessEntityID) < 50
ORDER BY [Year] DESC