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