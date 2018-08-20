CREATE DATABASE Session05
GO
USE Session05
GO
CREATE TABLE Team
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50)
)
GO
INSERT INTO Team VALUES
('Bayern Munich'),
('Pars Jonubi Jam'),
('Barcelona'),
('AS Rome'),
('Real Madrid'),
('Liverpool'),
('Juventus'),
('AC Milan')
GO
CREATE TABLE Team2
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50)
)
GO
INSERT INTO Team2 VALUES
('Bayern Munich'),
('Pars Jonubi Jam'),
('Barcelona'),
('AS Rome'),
('Real Madrid'),
('Liverpool'),
('Juventus'),
('AC Milan')
GO

SELECT t1.Name, t2.Name
FROM Team t1
CROSS JOIN Team2 t2
WHERE t1.Name != t2.Name
---------------------
GO
DROP TABLE Team2
GO
SELECT t1.Name, t2.Name
FROM Team t1
CROSS JOIN Team t2
WHERE t1.Name != t2.Name
GO
CREATE TABLE Employee
(
	Id INT PRIMARY KEY,
	Name NVARCHAR(50),
	Family NVARCHAR(50),
	Position NVARCHAR(20),
	ManagerId INT
)
GO
INSERT INTO Employee VALUES
(1,'Joey', 'Tribbiani', 'CEO', NULL),
(2,'Ross', 'Geller', 'HR Manager', 1),
(3,'Monica', 'Geller', 'Accounting Manager', 1),
(4,'Sheldon', 'Cooper', 'Technical Manager', 1),
(5,'Ted', 'Mosbey', 'Senior Accountant', 3),
(6,'Leonard', 'Hofsteder', 'Recuiter', 2),
(7,'Rachel', 'Green', 'Junior Accountant', 5)
GO
SELECT e.Name, e.Family, e.Position, m.Name 'ManagerName', m.Family 'ManagerFamily', m.Position 'ManagerPosition'
FROM Employee e
INNER JOIN Employee m 
ON e.ManagerId = m.Id
-------------------------
SELECT e.Name, e.Family, e.Position, m.Name 'ManagerName', m.Family 'ManagerFamily', m.Position 'ManagerPosition'
FROM Employee e
LEFT OUTER JOIN Employee m 
ON e.ManagerId = m.Id
-------------------------
SELECT e.Name, e.Family, e.Position, m.Name 'ManagerName', m.Family 'ManagerFamily', m.Position 'ManagerPosition'
FROM Employee e
RIGHT OUTER JOIN Employee m 
ON e.ManagerId = m.Id
-------------------------
SELECT e.Name, e.Family, e.Position, m.Name 'ManagerName', m.Family 'ManagerFamily', m.Position 'ManagerPosition'
FROM Employee e
FULL OUTER JOIN Employee m 
ON e.ManagerId = m.Id
-------------------------
CREATE TABLE Category
(
	Id INT PRIMARY KEY,
	Name NVARCHAR(50),
	ParentCategoryId INT
)
GO
INSERT INTO Category(Id, Name)
SELECT ProductSubCategoryId, Name
FROM AdventureWorks.Production.ProductSubcategory
GO
SELECT * 
FROM Category
GO
SELECT c.Name 'CategoryName', p1.Name 'ParentName', p2.Name 'GrandParnetName'
FROM Category c
LEFT OUTER JOIN  Category p1
ON c.ParentCategoryId = p1.Id
LEFT OUTER JOIN Category p2
ON p1.ParentCategoryId = p2.ParentCategoryId 
-------------------------
USE AdventureWorks
-------------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Color = 'Red'
--UNION
UNION ALL
--INTERSECT
--EXCEPT
SELECT p.ProductId, Name, Color, 0
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, Name, Color
HAVING SUM(OrderQty) > 2000
-------------------
USE Session05
-------------------
SELECT * FROM Employee
-------------------
USE AdventureWorks
-------------------
SELECT * FROM Person.Person
-------------------
SELECT BusinessEntityId, ISNULL(Title,'') + FirstName + ' ' + MiddleName + ' ' + LastName 'FullName'
FROM Person.Person
-------------------
SELECT BusinessEntityId, CONCAT(Title, FirstName, ' ', MiddleName, ' ', LastName) 'FullName'
FROM Person.Person
-------------------
SELECT Name,SUBSTRING(Name, 2, 1)
FROM Production.Product
--------------------
SELECT LEFT(Name, 2), RIGHT(Name, 1)
FROM Production.Product
--------------------
SELECT DATEPART(YEAR, HireDate)
FROM HumanResources.Employee
--------------------
SELECT GETDATE() 'DATETIME', SYSDATETIME() 'DATETIME2', SYSDATETIMEOFFSET() 'DATETIMEOFFSET'
--------------------
SELECT DATEADD(DAY, 14,GETDATE())
--------------------
SELECT DATEADD(DAY, -20,GETDATE())
--------------------
SELECT SYSDATETIMEOFFSET(),SWITCHOFFSET(SYSDATETIMEOFFSET(), '- 05:30')
--------------------
SELECT GETDATE() , TODATETIMEOFFSET(GETDATE(), '+ 04:30')
--------------------
SELECT ProductId, Name , Color,
CASE Color
WHEN 'Red' THEN N'قرمز'
WHEN 'Blue' THEN N'آبی'
WHEN 'Black' THEN N'مشکی'
--ELSE N'سایر رنگ ها'
END 'رنگ'

FROM Production.Product
----------------------
SELECT p.ProductId, Name, Color, ListPrice, SUM(s.OrderQty) [Sum],
CASE
WHEN SUM(s.OrderQty) > 3000 THEN N'پرفروش'
WHEN SUM(s.OrderQty) BETWEEN 1000 AND 2999 THEN N'فروش متوسط'
ELSE N'کم فروش'
END 'میزان فروش'
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, Name, Color, ListPrice
ORDER BY [Sum] DESC
-----------------------
USE Session05
----------------------
SELECT *
INTO Sales
FROM AdventureWorks.Sales.SalesOrderDetail
-----------------------
DELETE FROM Sales
WHERE SalesOrderID = 54148
-----------------------
SELECT * FROM Sales
-----------------------
DELETE FROM Sales
-----------------------
DROP TABLE Sales
-----------------------
TRUNCATE TABLE Sales
-----------------------
INSERT INTO 
Employee(Id,Name)
VALUES
(10,'Joey'),
(20,'Ross')
-------------------------
SELECT * FROM Employee
-------------------------
CREATE TABLE Person
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Job NVARCHAR(50)
)
--------------------------
INSERT INTO Person(Name, Job)
VALUES ('John Doe', 'Developer')
--------------------------
SELECT * FROm Person
--------------------------
INSERT INTO Person(Name, Job)
SELECT CONCAT(p.Title, p.FirstName, ' ', p.MiddleName, ' ', p.LastName) 'FullName',
e.JobTitle
FROM AdventureWorks.Person.Person p
INNER JOIN AdventureWorks.HumanResources.Employee e
ON p.BusinessEntityID = e.BusinessEntityID
-------------------------
SELECT * FROM Person
-------------------------
SELECT ProductId, Name, ListPrice, StandardCost
INTO Product
FROM AdventureWorks.Production.Product
-------------------------
SELECT * FROM Product