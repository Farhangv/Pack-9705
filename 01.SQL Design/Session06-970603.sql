USE Session05
-------------------
SELECT * FROM Person
-------------------
UPDATE Person SET Job = 'Web Developer', Name = 'David Doe'
WHERE Id = 1
-------------------
CREATE DATABASE Session06
GO
USE Session06
GO
SELECT 10
GO 5
CREATE DATABASE Session062
GO
USE master
GO
DROP DATABASE Session06
GO
DROP DATABASE Session062
GO
USE model
GO
CREATE TABLE TestTable
(
	Id INT,
	Name NVARCHAR(50)
)
GO
CREATE DATABASE Session06
GO
DROP TABLE TestTable
GO
DROP DATABASE Session06
GO
CREATE DATABASE Session06
ON -- MDF
(
	NAME= 'Session06_Data',
	FILENAME = 'D:\DbFiles\Session06_Data.mdf',
	SIZE = 10 MB,
	MAXSIZE = 25MB,
	FILEGROWTH = 10%
)
LOG ON
(
	NAME= 'Session06_Log',
	FILENAME = 'D:\DbLogFiles\Session06_Log.ldf',
	SIZE = 15 MB,
	MAXSIZE = 30MB,
	FILEGROWTH = 2MB
)
GO
SELECT NEWID()
GO
USE Session06
GO
CREATE TABLE Person
(
	--Id INT PRIMARY KEY IDENTITY(1000,2),
	Id INT IDENTITY(1000,2),
	Name NVARCHAR(50) NOT NULL,
	Family NVARCHAR(50) NOT NULL,
	Username VARCHAR(25) NOT NULL UNIQUE,
	[Password] NVARCHAR(50) NOT NULL,
	NationalCode CHAR(12) NOT NULL UNIQUE ,
		--CHECK (NationalCode LIKE '__________'),
	CellPhone CHAR(11), --UNIQUE 
		--CHECK (CellPhone LIKE '09_________'),
	Email VARCHAR(50), --UNIQUE 
		--CHECK (Email LIKE '%@%.%'),
	BirthDate DATE,
	RowGuid UNIQUEIDENTIFIER NOT NULL UNIQUE DEFAULT NEWID(),
	CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
	ModifiedDate DATETIME,
	[RowVersion] TIMESTAMP,
	--PRIMARY KEY(Id),
	CONSTRAINT PK_Person_Id PRIMARY KEY(Id),
	UNIQUE(Email),
	CONSTRAINT UQ_CellPhone UNIQUE(CellPhone),
	CONSTRAINT CHK_NationalCode CHECK(NationalCode LIKE '___-______-_'),
	CONSTRAINT CHK_Email CHECK(Email LIKE '%@%.%'),
	CONSTRAINT CHK_CellPhone CHECK(CellPhone LIKE '09_________')
)
GO
SELECT NEWSEQUENTIALID()
