SELECT * FROM [192.168.22.139].master.sys.databases
GO
SELECT *
FROM KN139.master.sys.databases
GO
CREATE DATABASE LocalSession14
GO
USE LocalSession14
GO
CREATE TABLE Person
(
	Id INT PRIMARY KEY,
	FullName NVARCHAR(50)
)
GO
INSERT INTO Person VALUES (1,'Chandler Bing'),(2,'Ross Geller'), (3, 'Penni')
GO
USE Session14
GO
CREATE TABLE Contact
(
	Id INT IDENTITY PRIMARY KEY,
	PersonId INT NOT NULL,
	[Value] NVARCHAR(30)
)
GO
INSERT INTO Contact VALUES(1, '09121234568'), (1,'02154789652'), (2, '09354578965')
GO
SELECT * 
FROM [KN139].Session14.dbo.Contact c
INNER JOIN Person p
ON p.Id = c.PersonId
GO
CREATE SYNONYM Contact FOR [KN139].Session14.dbo.Contact
GO
SELECT * 
FROM Contact c
INNER JOIN Person p
ON p.Id = c.PersonId
