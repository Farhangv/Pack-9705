CREATE DATABASE Session08
GO
USE Session08
GO
CREATE TABLE Person
(
	Id INT,
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
	PersonId INT PRIMARY KEY FOREIGN KEY REFERENCES Person(Id) ON DELETE NO ACTION ON UPDATE NO ACTION,
	StudentCode INT NOT NULL UNIQUE,
	EntranceYear SMALLINT NOT NULL,
	Field NVARCHAR(50) NOT NULL
)
CREATE TABLE Teacher
(
	PersonId INT PRIMARY KEY ,
	EmployeeCode INT NOT NULL UNIQUE,
	Experience TINYINT,
	CVFile VARBINARY(MAX) ,
	FOREIGN KEY (PersonId) REFERENCES Person(Id) ON DELETE CASCADE ON UPDATE CASCADE
)
GO
CREATE TABLE Course
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(50),
	Duration TINYINT,
	TeacherPersonId INT DEFAULT 1,
	CONSTRAINT FK_Teacher_PersonId 
	FOREIGN KEY(TeacherPersonId) REFERENCES Teacher(PersonId)
	ON DELETE SET NULL ON UPDATE SET DEFAULT
)
GO
CREATE TABLE Student_Course
(
	StudentPersonId INT FOREIGN KEY REFERENCES Student(PersonId),
	CourseId INT FOREIGN KEY REFERENCES Course(Id),
	CONSTRAINT UQ_StudentCourse UNIQUE(StudentPersonId, CourseId),
)
GO
ALTER TABLE Teacher
ADD HireYear SMALLINT
GO
ALTER TABLE Teacher
ADD CONSTRAINT CHK_HireYear CHECK(HireYear > 1380)
GO
ALTER TABLE Student
ADD PassedUnits SMALLINT
GO
ALTER TABLE Student
ADD TotalUnits SMALLINT
GO
SELECT * FROM AdventureWorks.Sales.SalesOrderDetail
GO
ALTER TABLE Student
ADD RemainingUnits AS (TotalUnits - PassedUnits)
GO
ALTER TABLE Teacher
DROP COLUMN IF EXISTS Experience
GO
ALTER TABLE Teacher
ADD Experience AS YEAR(GETDATE()) - HireYear
GO
ALTER TABLE Teacher
ALTER COLUMN CVFile VARBINARY(1000)
GO
--ALTER TABLE Teacher
--ALTER COLUMN EmployeeCode INT UNIQUE
GO
CREATE TABLE Employee
(
	PersonId INT PRIMARY KEY FOREIGN KEY REFERENCES Person(Id),
	JobTitle NVARCHAR(50),
	Department NVARCHAR(50)
)

GO
CREATE VIEW VW_HREmployees
AS
SELECT p.*, e.*
FROM Employee e
INNER JOIN Person p
ON p.Id = e.PersonId
WHERE Department = 'HR'
GO
SELECT *
FROM VW_HREmployees
GO
ALTER VIEW VW_HREmployees
AS
SELECT *
FROM Employee e
INNER JOIN Person p
ON p.Id = e.PersonId
WHERE Department = 'HR'
GO
UPDATE VW_HREmployees 
SET Email = 'Rachell@Green.com'
WHERE PersonId = 3
GO
UPDATE VW_HREmployees 
SET Email = 'Rachell@Green.com'
WHERE Id = 2
GO
DELETE FROM VW_HREmployees
WHERE Id = 2
GO
ALTER TABLE Employee 
DROP CONSTRAINT FK__Employee__Person__52593CB8
GO
ALTER TABLE Employee 
ADD FullName NVARCHAR(50)
GO
ALTER VIEW VW_HREmployees
AS
SELECT *
FROM Employee e
WHERE Department = 'HR'
GO
SELECT * FROM VW_HREmployees
GO
UPDATE VW_HREmployees
SET FullName = 'David Doe'
WHERE PersonId = 3
GO
INSERT INTO VW_HREmployees(PersonId, JobTitle, Department, FullName)
VALUES (11, 'Senior Recuiter', 'HR', 'Penni')
GO
SELECT * FROM Employee
GO
ALTER VIEW VW_HREmployees
AS
SELECT *
FROM Employee e
WHERE Department = 'HR'
WITH CHECK OPTION
GO
INSERT INTO VW_HREmployees(PersonId, JobTitle, Department, FullName)
VALUES (12, 'Senior Recuiter', 'HR', 'Sarah Doe')
GO
ALTER VIEW VW_HREmployees
WITH ENCRYPTION
AS
SELECT *
FROM Employee e
WHERE Department = 'HR'
WITH CHECK OPTION
GO
CREATE FUNCTION GetAge
(
	@BirthDate DATE
)
RETURNS TINYINT
AS
BEGIN
	RETURN YEAR(GETDATE()) - YEAR(@BirthDate)
END
GO
SELECT dbo.GetAge('1980/10/10')
GO
SELECT BusinessEntityId , dbo.GetAge(BirthDate), YEAR(HireDate)
FROM AdventureWorks.HumanResources.Employee
GO
CREATE FUNCTION GetDepartmentEmployees
(
	@DepartmentName NVARCHAR(50)
)
RETURNS TABLE
AS
	RETURN
	SELECT * FROM Employee
	WHERE Department = @DepartmentName

GO
SELECT *
FROM GetDepartmentEmployees('HR') e
--LEFT OUTER JOIN Person p
--ON e.PersonId = p.Id
GO
DECLARE @Name NVARCHAR(50)
--SET @Name = 'John Doe'
SELECT @Name = FirstName FROM AdventureWorks.Person.Person
WHERE BusinessEntityID = 5
SELECT @Name
GO
DECLARE @Score INT
SET @Score = 80
IF @Score > 70
BEGIN
	--SELECT 'Passed'
	RETURN 1
END
ELSE
BEGIN
	--SELECT 'Failed'
	RETURN 0
END
GO
USE AdventureWorks
GO
ALTER FUNCTION CanDeliverOrderedProduct
(
	@ProductId INT,
	@OrderQty INT,
	@DueDate DATE
)
RETURNS BIT
AS
BEGIN

	DECLARE @Result BIT
	DECLARE @AvailableQty INT
	SELECT @AvailableQty = SUM(Quantity)
	FROM Production.ProductInventory
	WHERE ProductID = @ProductId

	DECLARE @DaysToManufacture  INT
	SELECT @DaysToManufacture = DaysToManufacture 
	FROM Production.Product
	WHERE ProductID = @ProductId
	
	IF (@AvailableQty >= @OrderQty)
	BEGIN
		SET @Result = 1
	END

	ELSE 
	BEGIN
		IF (DATEDIFF(DAY, GETDATE(), @DueDate) >= @DaysToManufacture)
			BEGIN
				SET @Result = 1
			END
		ELSE 
			BEGIN
				SET @Result = 0
			END
	END

	RETURN @Result
END

GO
SELECT dbo.CanDeliverOrderedProduct(777, 2500, DATEADD(DAY, 1, GETDATE()))
GO
SELECT SUM(Quantity)
FROM Production.ProductInventory
WHERE ProductID = 777