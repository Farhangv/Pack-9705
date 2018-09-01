CREATE DATABASE Session09
GO
USE Session09
GO
USE AdventureWorks
GO
CREATE FUNCTION GetProductsInTopDay
(
	@Year SMALLINT
)
RETURNS @Result TABLE 
(
	ProductId INT,
	ProductName NVARCHAR(50),
	TotalSalesQty INT,
	[Date] DATE
)
AS
BEGIN
	DECLARE @SelectedDate DATE
	SELECT TOP 1 @SelectedDate = OrderDate
	FROM Sales.SalesOrderHeader h
	INNER JOIN Sales.SalesOrderDetail d
	ON h.SalesOrderID = d.SalesOrderID
	WHERE YEAR(OrderDate) = @Year
	GROUP BY OrderDate
	ORDER BY SUM(LineTotal) DESC

	INSERT INTO @Result
	SELECT p.ProductId, p.Name, SUM(s.OrderQty), h.OrderDate
	FROM Production.Product p
	INNER JOIN Sales.SalesOrderDetail s
	ON p.ProductID = s.ProductID
	INNER JOIN Sales.SalesOrderHeader h
	ON s.SalesOrderID = h.SalesOrderID
	WHERE @SelectedDate = h.OrderDate
	GROUP BY p.ProductId, p.Name, h.OrderDate
	UNION 
	SELECT NULL, NULL, SUM(OrderQty), @SelectedDate
	FROM Sales.SalesOrderDetail s
	INNER JOIN Sales.SalesOrderHeader h
	ON s.SalesOrderID = h.SalesOrderID
	WHERE h.OrderDate = @SelectedDate
	RETURN
END
GO
USE AdventureWorks
GO
SELECT DISTINCT ModifiedDate
FROM Sales.SalesOrderDetail
GO
SELECT * FROM Sales.SalesOrderHeader
GO
SELECT * FROM Sales.SalesOrderDetail
GO
	SELECT TOP 1  OrderDate
	FROM Sales.SalesOrderHeader h
	INNER JOIN Sales.SalesOrderDetail d
	ON h.SalesOrderID = d.SalesOrderID
	WHERE YEAR(OrderDate) = 2011
	GROUP BY OrderDate
	ORDER BY SUM(LineTotal) DESC

GO
	SELECT p.ProductId, p.Name, SUM(s.OrderQty), h.OrderDate
	FROM Production.Product p
	INNER JOIN Sales.SalesOrderDetail s
	ON p.ProductID = s.ProductID
	INNER JOIN Sales.SalesOrderHeader h
	ON s.SalesOrderID = h.SalesOrderID
	WHERE '2011-10-01' = h.OrderDate
	GROUP BY p.ProductId, p.Name, h.OrderDate
	UNION
	SELECT NULL, NULL, SUM(OrderQty), '2011-10-01'
	FROM Sales.SalesOrderDetail s
	INNER JOIN Sales.SalesOrderHeader h
	ON s.SalesOrderID = h.SalesOrderID
	WHERE h.OrderDate = '2011-10-01'
GO
SELECT *
FROM GetProductsInTopDay(2014)

GO
--CREATE FUNCTION نام تابع
--(
--	تعریف پارامتر های ورودی
--)
--RETURNS @نام متغیر جدولی خروجی TABLE 
--(
--تعریف ستون های خروجی / مشابه تعریف ستون های جدول واقعی     
--)
--AS
--BEGIN
--			دستورات
--			...

--	INSERT INTO @نام متغیر جدولی خروجی
--	SELECT …

--	RETURN
--END
GO
CREATE PROC GetProductsByColorName
(
	@Color NVARCHAR(50)
)
AS
BEGIN
	SELECT * FROM Production.Product
	WHERE Color = @Color
END
GO
EXEC GetProductsByColorName 'Red'
GO
GetProductsByColorName 'Red'
GO
USE Session08
GO
CREATE TABLE [User]
(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(50) UNIQUE NOT NULL,
	PasswordHash NVARCHAR(100) NOT NULL,
	Email VARCHAR(100) UNIQUE,
	CreateDate DATETIME
)
GO
ALTER TABLE [User]
ADD ModifiedDate DATETIME
GO
CREATE PROC UserInsert
(
	@Username VARCHAR(50),
	@Password NVARCHAR(50),
	@Email VARCHAR(50)
)
AS
BEGIN
	INSERT INTO [User](Username, PasswordHash, Email, CreateDate)
	VALUES (@Username, HASHBYTES('MD5', @Password), @Email, GETDATE())
END
GO
EXEC UserInsert 'Joey', '123', 'j@t.com'
GO
SELECT * FROM [User]
GO
ALTER PROC UserInsert
(
	@Username VARCHAR(50),
	@Password NVARCHAR(50),
	@Email VARCHAR(50)
)
AS
BEGIN
	INSERT INTO [User](Username, PasswordHash, Email, CreateDate)
	VALUES (@Username, HASHBYTES('MD5', @Password), @Email, GETDATE())

	RETURN SCOPE_IDENTITY()
END
GO
DECLARE @UserId INT
EXEC @UserId = UserInsert 'Chandler', '123', 'c@b.com'
SELECT @UserId
GO
ALTER PROC UserUpdate
(
	@UserId INT,
	@Password NVARCHAR(50),
	@Email NVARCHAR(50)
)
AS
BEGIN 
	IF @Password IS NOT NULL
	BEGIN
	UPDATE [User] SET 
	PasswordHash = HASHBYTES('MD5', @Password),
	Email = @Email,
	ModifiedDate = GETDATE()
	WHERE Id = @UserId
	END
	ELSE
	BEGIN
	UPDATE [User] SET 
	Email = @Email,
	ModifiedDate = GETDATE()
	WHERE Id = @UserId
	END
END
GO
EXEC UserUpdate 2, 'abcdef', 'chandler@b.com'
GO
SELECT * FROM [User]
GO
CREATE PROC UserDelete
(
	@UserId INT
)
AS
BEGIN
	DELETE FROM [User] WHERE Id = @UserId
END
GO
EXEC UserDelete 1
GO
SELECT * FROM [User]
GO
CREATE PROC UserSelect
(
	@UserId INT
)
AS
BEGIN
	SELECT * FROM [User] WHERE Id = @UserId
END
GO

