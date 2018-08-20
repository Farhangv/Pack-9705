USE AdventureWorks
--------------------

SELECT ProductId, Name, 
(
	SELECT Name 
	FROM Production.ProductSubcategory s
	WHERE s.ProductSubcategoryID = p.ProductSubcategoryID
) 'SubCategoryName', 
(
	SELECT Name 
	FROM Production.ProductCategory c
	WHERE c.ProductCategoryID = 
		(
			SELECT ProductCategoryID
			FROM Production.ProductSubcategory s
			WHERE s.ProductSubcategoryID = p.ProductSubcategoryID
		)
) 'CategoryName'
FROM Production.Product p
---------------------
SELECT *
FROM Production.ProductCategory
---------------------
SELECT ProductId,SUM(OrderQty)
FROM Sales.SalesOrderDetail
GROUP BY ProductId
---------------------
SELECT ProductId,AVG(SUM(OrderQty))
FROM Sales.SalesOrderDetail
GROUP BY ProductId
---------------------
SELECT ROW_NUMBER() OVER (ORDER BY Name) ,Name, Color, ListPrice
FROM Production.Product
WHERE ROW_NUMBER() OVER (ORDER BY Name) 
BETWEEN 11 AND 20
----------------------
SELECT *
FROM 
	(
		SELECT ROW_NUMBER() OVER (ORDER BY Name) 'Row',
		Name, Color, ListPrice
		FROM Production.Product
	) dt
WHERE [Row]
BETWEEN 11 AND 20
----------------------
WITH q
AS
(
SELECT ProductId,SUM(OrderQty) 'Sum'
FROM Sales.SalesOrderDetail
GROUP BY ProductId
)
SELECT AVG([Sum])
FROM q
-----------------------
SELECT AVG(OrderQty)
FROM Sales.SalesOrderDetail;
------------------------
WITH cte
AS
(
	SELECT p.ProductId , 
		ISNULL(
		(
			SELECT SUM(OrderQty)
			FROM Sales.SalesOrderDetail s 
			WHERE p.ProductID = s.ProductID 
			GROUP BY ProductID
		),0) 'Sum'
	FROM Production.Product p
	GROUP BY p.ProductID
)
SELECT AVG([Sum])
FROM cte
---------------------
SELECT Name, ISNULL(Color, '[NoColor]')
FROM Production.Product
---------------------
SELECT Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL
---------------------
SELECT COUNT(Color)
FROM Production.Product
----------------------
SELECT ProductId, p.Name 'ProductName', Color, sc.Name 'SubCategoryName'
FROM Production.Product p
INNER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
----------------------
SELECT ProductId, p.Name 'ProductName', Color, sc.Name 'SubCategoryName'
FROM Production.Product p 
LEFT OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
----------------------
SELECT ProductId, p.Name 'ProductName', Color, sc.Name 'SubCategoryName'
FROM Production.Product p 
RIGHT OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
----------------------
SELECT ProductId, p.Name 'ProductName', Color, sc.Name 'SubCategoryName'
FROM Production.Product p 
FULL OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
----------------------
SELECT c.Name 'CategoryName', SUM(s.LineTotal) 'TotalSalesAmount'
FROM Production.ProductCategory c
INNER JOIN Production.ProductSubcategory sc
ON c.ProductCategoryID = sc.ProductCategoryID
INNER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY c.Name
----------------------
SELECT DISTINCT c.Name 'CategoryName', 
SUM(s.LineTotal) OVER (PARTITION BY c.Name) 'CategorySales',
SUM(s.LineTotal) OVER() 'TotalSales',
(
	SUM(s.LineTotal) OVER (PARTITION BY c.Name)/ 
	SUM(s.LineTotal) OVER()

) * 100 'TotalSalesPct'
FROM Production.ProductCategory c
INNER JOIN Production.ProductSubcategory sc
ON c.ProductCategoryID = sc.ProductCategoryID
INNER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
--GROUP BY c.Name
