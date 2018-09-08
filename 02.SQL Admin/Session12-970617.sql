CREATE DATABASE Session12
GO
USE Session12
GO
SELECT ProductId, Name, Color, ListPrice, StandardCost
INTO Product
FROM AdventureWorks.Production.Product
GO
CREATE TABLE Person
(
	Id INT IDENTITY PRIMARY KEY,
	[Username] NVARCHAR(50),
	[Password] VARBINARY(100),
	FullName NVARCHAR(50),
	NationalCode NVARCHAR(15),
	JobTitle NVARCHAR(100),
	OrganizationalLevel INT
)
GO
INSERT INTO Person
SELECT CONCAT(p.FirstName, p.LastName),
HASHBYTES('md5', '123'),
CONCAT(FirstName , ' ' ,  MiddleName , ' ' , LastName),
e.NationalIDNumber,
e.JobTitle,
e.OrganizationLevel
FROM AdventureWorks.Person.Person p
INNER JOIN AdventureWorks.HumanResources.Employee e
ON p.BusinessEntityID = e.BusinessEntityID
GO
DROP TABLE Product
GO
SELECT ProductId, Name, Color, ListPrice, StandardCost, ProductSubcategoryID
INTO Production.Product
FROM AdventureWorks.Production.Product
GO
SELECT ProductSubCategoryId, Name
INTO Production.SubCategory
FROM AdventureWorks.Production.ProductSubcategory
GO
SELECT p.BusinessEntityId, p.FirstName,p.LastName, e.OrganizationLevel, e.JobTitle, e.Gender, e.HireDate
INTO HumanResources.Employee
FROM AdventureWorks.Person.Person p
INNER JOIN AdventureWorks.HumanResources.Employee e
ON p.BusinessEntityID = e.BusinessEntityID
GO
CREATE TABLE HumanResources.Salaries
(
	EmployeeId INT PRIMARY KEY,
	Salary DECIMAL(10,2)
)
GO
SELECT USER_NAME()
GO
CREATE DATABASE RLSDB
GO
USE RLSDB
GO
CREATE USER Manager WITHOUT LOGIN;
CREATE USER Sales1 WITHOUT LOGIN;  
CREATE USER Sales2 WITHOUT LOGIN; 
GO
CREATE TABLE Sales  
    (  
    OrderID int,  
    SalesRep sysname,  
    Product varchar(10),  
    Qty int  
    );   
GO
INSERT Sales VALUES   
(1, 'Sales1', 'Valve', 5),   
(2, 'Sales1', 'Wheel', 2),   
(3, 'Sales1', 'Valve', 4),  
(4, 'Sales2', 'Bracket', 2),   
(5, 'Sales2', 'Wheel', 5),   
(6, 'Sales2', 'Seat', 5);  
-- View the 6 rows in the table  
SELECT * FROM Sales;  

EXECUTE AS USER = 'Sales1';  
SELECT * FROM Sales;   
REVERT; 
GO
GRANT SELECT ON Sales TO Manager;  
GRANT SELECT ON Sales TO Sales1;  
GRANT SELECT ON Sales TO Sales2;  
GO
CREATE SCHEMA Security;  
GO  

CREATE FUNCTION Security.fn_securitypredicate
(
	@SalesRep sysname
)  
RETURNS TABLE  
WITH SCHEMABINDING  
AS  
    RETURN 
	SELECT 1 AS fn_securitypredicate_result   
	WHERE @SalesRep = USER_NAME() OR USER_NAME() = 'Manager';  
	
GO
CREATE SECURITY POLICY SalesFilter  
ADD FILTER PREDICATE Security.fn_securitypredicate(SalesRep)   
ON dbo.Sales  
WITH (STATE = ON);
GO
EXECUTE AS USER = 'Sales1';  
SELECT * FROM Sales;   
REVERT; 
EXECUTE AS USER = 'Sales2';  
SELECT * FROM Sales;   
REVERT;    
EXECUTE AS USER = 'Manager';  
SELECT * FROM Sales;   
REVERT; 
GO
USE Session12
GO
SELECT * FROM HumanResources.Employee
GO
CREATE SCHEMA Security;  
GO
CREATE FUNCTION Security.fn_securitypredicate
(
	@OrganizationLevel INT
)  
RETURNS TABLE  
WITH SCHEMABINDING  
AS  
    RETURN 
	SELECT 1 AS fn_securitypredicate_result   
	WHERE @OrganizationLevel > 2
	
GO
CREATE SECURITY POLICY HREmployeeFilter  
ADD FILTER PREDICATE Security.fn_securitypredicate(OrganizationLevel)   
ON HumanResources.Employee  
WITH (STATE = ON);
GO
SELECT * FROM HumanResources.Employee

