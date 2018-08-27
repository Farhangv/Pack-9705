CREATE DATABASE Session07
GO
USE Session07
GO
CREATE TABLE Person
(
	Id INT IDENTITY(1000,2),
	Name NVARCHAR(50) NOT NULL,
	Family NVARCHAR(50) NOT NULL,
	Username VARCHAR(25) NOT NULL UNIQUE,
	[Password] NVARCHAR(50) NOT NULL,
	NationalCode CHAR(12) NOT NULL UNIQUE ,
	CellPhone CHAR(11), 
	Email VARCHAR(50), 
	BirthDate DATE,
	RowGuid UNIQUEIDENTIFIER NOT NULL UNIQUE DEFAULT NEWID(),
	CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
	ModifiedDate DATETIME,
	[RowVersion] TIMESTAMP,
	CONSTRAINT PK_Person_Id PRIMARY KEY(Id),
	UNIQUE(Email),
	CONSTRAINT UQ_CellPhone UNIQUE(CellPhone),
	CONSTRAINT CHK_NationalCode CHECK(NationalCode LIKE '___-______-_'),
	CONSTRAINT CHK_Email CHECK(Email LIKE '%@%.%'),
	CONSTRAINT CHK_CellPhone CHECK(CellPhone LIKE '09_________')
)
GO
DROP TABLE Person
GO
CREATE TABLE Person
(
	Id INT IDENTITY(1000,2),
	Name NVARCHAR(50) NOT NULL,
	Family NVARCHAR(50) NOT NULL,
	Username VARCHAR(25) NOT NULL UNIQUE,
	[Password] NVARCHAR(50) NOT NULL,
	NationalCode CHAR(12) NOT NULL UNIQUE ,
	CellPhone CHAR(11), 
	Email VARCHAR(50), 
	BirthDate DATE,
	RowGuid UNIQUEIDENTIFIER NOT NULL UNIQUE DEFAULT NEWID(),
	CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
	ModifiedDate DATETIME,
	[RowVersion] TIMESTAMP,
	CONSTRAINT PK_Person_Id PRIMARY KEY(Id),
	UNIQUE(Email),
	CONSTRAINT UQ_CellPhone UNIQUE(CellPhone),
	CONSTRAINT CHK_NationalCode CHECK(NationalCode LIKE '___-______-_'),
	CONSTRAINT CHK_Email CHECK(Email LIKE '%@%.%'),
	CONSTRAINT CHK_CellPhone CHECK(CellPhone LIKE '09_________')
)
GO
CREATE TABLE Student
(
	PersonId INT PRIMARY KEY,
	StudentCode INT NOT NULL UNIQUE,
	EntranceYear SMALLINT NOT NULL,
	Field NVARCHAR(50) NOT NULL
)
CREATE TABLE Teacher
(
	PersonId INT PRIMARY KEY,
	EmployeeCode INT NOT NULL UNIQUE,
	Experience TINYINT,
	CVFile VARBINARY(MAX) 
)
GO
CREATE TABLE Course
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(50),
	Duration TINYINT,
	TeacherPersonId INT
)
GO
CREATE TABLE Student_Course
(
	StudentPersonId INT,
	CourseId INT,
	CONSTRAINT UQ_StudentCourse UNIQUE(StudentPersonId, CourseId)
)
GO
SELECT c.Title, CONCAT(p.Name , ' ', p.Family) 'FullName'
FROM Course c
INNER JOIN Student_Course sc ON c.Id = sc.CourseId
INNER JOIN Student s ON s.PersonId = sc.StudentPersonId
INNER JOIN Person p ON s.PersonId = p.Id
WHERE s.PersonId = 1006

GO
SELECT CONCAT(p.Name , ' ', p.Family) 'FullName', SUM(c.Duration)
FROM Course c
INNER JOIN Student_Course sc ON c.Id = sc.CourseId
INNER JOIN Student s ON s.PersonId = sc.StudentPersonId
INNER JOIN Person p ON s.PersonId = p.Id
--WHERE s.PersonId = 1006
GROUP BY CONCAT(p.Name , ' ', p.Family)
HAVING SUM(c.Duration) > 100
GO
CREATE DATABASE LibraryDemo
GO
USE LibraryDemo
GO
CREATE TABLE Book
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(100) NOT NULL,
	ISBN CHAR(100),
	PublishYear SMALLINT
)
GO
--DROP TABLE Person
GO
CREATE TABLE Person
(
	Id INT PRIMARY KEY,
	Name NVARCHAR(100),
	Family NVARCHAR(100)
)
GO
CREATE TABLE Author
(
	PersonId INT PRIMARY KEY,
	Birthdate DATETIME2,
	Biography NVARCHAR(200) 
)
GO
CREATE TABLE Subscriber
(
	PersonId INT PRIMARY KEY,
	CellPhone CHAR(11),
	Email VARCHAR(200)
)
GO
CREATE TABLE Book_Author
(
	AuthorId INT,
	BookId INT,
	PRIMARY KEY(AuthorId, BookId)
)
GO
CREATE TABLE Loan
(
	Id INT IDENTITY PRIMARY KEY,
	BookId INT,
	SubscriberId INT,
	StartDate DATETIME,
	DueDate DATETIME
)
GO
INSERT INTO Book(Title, PublishYear, ISBN)
SELECT Name, YEAR(ModifiedDate), ProductNumber
FROM AdventureWorks.Production.Product
GO
INSERT INTO Person(Id, Name, Family)
SELECT BusinessEntityId, FirstName, LastName
FROM AdventureWorks.Person.Person

GO
INSERT INTO Author(PersonId, Birthdate, Biography)
SELECT  BusinessEntityID, BirthDate,JobTitle
FROM AdventureWorks.HumanResources.Employee
GO
INSERT INTO Subscriber(PersonId, Email, CellPhone)
SELECT p.BusinessEntityID, pe.EmailAddress, pp.PhoneNumber
FROM AdventureWorks.Person.Person p
INNER JOIN AdventureWorks.Person.PersonPhone pp
ON p.BusinessEntityID = pp.BusinessEntityID
INNER JOIN AdventureWorks.Person.EmailAddress pe
ON p.BusinessEntityID = pe.BusinessEntityID
INNER JOIN AdventureWorks.Sales.Customer c
ON p.BusinessEntityID = c.PersonID
