USE AdventureWorks
--------------------
SELECT Name, SUM(ListPrice)
FROM Production.Product
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate)
ORDER BY [Year], [Month]
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate) WITH ROLLUP
ORDER BY [Year], [Month]
--------------------
SELECT YEAR(HireDate) 'Year', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate)
ORDER BY [Year]
--------------------
SELECT COUNT(*) 'Count'
FROM HumanResources.Employee
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate) WITH CUBE
ORDER BY [Year], [Month]
--------------------
SELECT MONTH(HireDate) 'Month', COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY MONTH(HireDate)
ORDER BY [Month]
--------------------
SELECT YEAR(HireDate) 'Year', MONTH(HireDate) 'Month', DAY(HireDate) 'Day',
COUNT(*) 'Count'
FROM HumanResources.Employee
GROUP BY YEAR(HireDate), MONTH(HireDate), DAY(HireDate) WITH CUBE
ORDER BY [Year], [Month], [Day]
--------------------
SELECT ROW_NUMBER() OVER (ORDER BY Name) 'Row',ProductId, Name, Color
FROM Production.Product
--ORDER BY ProductID
---------------------
SELECT ROW_NUMBER() OVER (ORDER BY Name DESC) 'Row',ProductId, Name, Color
FROM Production.Product
---------------------
SELECT RANK() OVER (ORDER BY ListPrice DESC) 'Rank',ProductId, Name, ListPrice
FROM Production.Product
---------------------
SELECT RANK() OVER (ORDER BY ListPrice DESC) 'Rank',
DENSE_RANK() OVER (ORDER BY ListPrice DESC) 'DenseRank',
ProductId, Name, ListPrice
FROM Production.Product;
---------------------
WITH Q 
AS
(
SELECT RANK() OVER (ORDER BY ListPrice DESC) 'Rank',
DENSE_RANK() OVER (ORDER BY ListPrice DESC) 'DenseRank',
ProductId, Name, ListPrice
FROM Production.Product
)
SELECT * FROM Q
WHERE [Rank] <= 10
----------------
SELECT NTILE(10) OVER (ORDER BY ListPrice) '4-Tile',ProductId, Name, ListPrice
FROM Production.Product
----------------
SELECT RANK() OVER (PARTITION BY Color ORDER BY ListPrice DESC) 'Rank',
ProductId, Name, Color, ListPrice
FROM Production.Product
----------------
SELECT SUM(ListPrice) OVER (PARTITION BY Color) 'Sum',
ProductId, Name, Color, ListPrice
FROM Production.Product
ORDER BY ProductId
-----------------
SELECT SUM(ListPrice) 'Sum',
ProductId, Name, Color, ListPrice 
FROM Production.Product
GROUP BY ProductId, Name, Color, ListPrice 
ORDER BY ProductId
------------------
SELECT DISTINCT 
ProductId,
SUM(LineTotal) OVER (PARTITION BY ProductId) / SUM(LineTotal) OVER ()'TotalProductSalesPercentage'
FROM Sales.SalesOrderDetail
--GROUP BY ProductId
--ORDER BY TotalProductSalesPercentage DESC
-------------------
SELECT SUM(LineTotal)
FROM  Sales.SalesOrderDetail

SELECT SUM(LineTotal) OVER()
FROM Sales.SalesOrderDetail

SELECT ProductId,SUM(LineTotal)
FROM  Sales.SalesOrderDetail
GROUP BY ProductId
--------------------
SELECT DISTINCT ProductId,
SUM(LineTotal) OVER (PARTITION BY ProductId) 'TotalProductSales',
SUM(LineTotal) OVER () 'TotalSales',
(SUM(LineTotal) OVER (PARTITION BY ProductId) / SUM(LineTotal) OVER ()) * 100 'Pct'
FROM Sales.SalesOrderDetail
ORDER BY Pct DESC
--GROUP BY ProductId, LineTotal
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId IN 
(
SELECT DISTINCT ProductId 
FROM Sales.SalesOrderDetail
)
---------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId NOT IN 
(
SELECT DISTINCT ProductId 
FROM Sales.SalesOrderDetail
)
----------------------

SELECT DISTINCT ProductId , 
(
	SELECT Name
	FROM Production.Product p
	WHERE s.ProductID = p.ProductID
) 'ProductName'
FROM Sales.SalesOrderDetail s
-----------------------
SELECT *
FROM Production.Product
WHERE ProductSubcategoryID IN
(
	SELECT ProductSubcategoryID
	FROM Production.ProductSubcategory
	WHERE Name LIKE '%Bike%'
)

----------------------------
SELECT ProductId, Name, Color, StandardCost
FROM Production.Product
WHERE ProductId IN
(
	SELECT TOP 10 ProductId 
	FROM Sales.SalesOrderDetail 
	GROUP BY ProductID
	ORDER BY SUM(OrderQty) DESC
)