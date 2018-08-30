USE AdventureWorks
GO
--[01]-04
SELECT co.Name 'CategoryName', 
(
	SELECT TOP 1 p.Name 
	FROM Production.ProductCategory c
	INNER JOIN Production.ProductSubcategory sc
	ON c.ProductCategoryID = sc.ProductCategoryID
	INNER JOIN Production.Product p
	ON p.ProductSubcategoryID = sc.ProductSubcategoryID
	INNER JOIN Sales.SalesOrderDetail s
	ON p.ProductID = s.ProductID
	WHERE c.ProductCategoryID = co.ProductCategoryID
	GROUP BY p.Name 
	ORDER BY SUM(OrderQty) DESC
) 'ProductName'
FROM Production.ProductCategory co
GO
--[02]-03,04
SELECT p.ProductId, p.Name, p.SafetyStockLevel,
SUM(i.Quantity) 'TotalInStock',
CASE 
WHEN SUM(i.Quantity) <= p.SafetyStockLevel THEN N'حداقل موجودی'
ELSE N'موجودی نزدیک به حداقل'
END 'AvailabilityStatus'

FROM Production.Product p
INNER JOIN Production.ProductInventory i
ON p.ProductID = i.ProductID
GROUP BY p.ProductId, p.Name, p.SafetyStockLevel
HAVING SUM(i.Quantity) <= p.SafetyStockLevel + 100 

