CREATE DATABASE Session11
GO
USE Session11
GO
SELECT * 
INTO Product
FROM AdventureWorks.Production.Product
GO
--1.تعریف متغییر به تعداد ستون های خروجی
DECLARE @ProductId INT
DECLARE @Name NVARCHAR(50)
DECLARE @Color NVARCHAR(50)
--2.تعریف کرسر بر اساس دستور سلکت
DECLARE product_cursor CURSOR 
FOR SELECT ProductId, Name, Color
FROM Product
--3.باز کردن کرسر
OPEN product_cursor
--4.دریافت اولین رکورد
FETCH NEXT FROM product_cursor
INTO @ProductId, @Name, @Color
--5.حلقه برای پیمایش
WHILE @@FETCH_STATUS = 0
BEGIN
	--6.انجام عملیات داخل حلقه
	FETCH NEXT FROM product_cursor
	INTO @ProductId, @Name, @Color
	PRINT @ProductId
	PRINT @Name
	PRINT @Color
END
--7.بستن کرسر
CLOSE product_cursor
--8.تخلیه کرسر از حافظه
DEALLOCATE product_cursor
GO--One By One
--1.تعریف متغییر به تعداد ستون های خروجی
DECLARE @ProductId INT
DECLARE @Name NVARCHAR(50)
DECLARE @Color NVARCHAR(50)
--2.تعریف کرسر بر اساس دستور سلکت
DECLARE product_cursor CURSOR 
FOR SELECT ProductId, Name, Color
FROM Product
--3.باز کردن کرسر
--OPEN product_cursor
--4.دریافت اولین رکورد
--DECLARE @ProductId INT
--DECLARE @Name NVARCHAR(50)
--DECLARE @Color NVARCHAR(50)

FETCH NEXT FROM product_cursor
INTO @ProductId, @Name, @Color
--PRINT @@FETCH_STATUS
--PRINT @ProductId
--PRINT @Name
--PRINT @Color
--5.حلقه برای پیمایش
WHILE @@FETCH_STATUS = 0
BEGIN
	--6.انجام عملیات داخل حلقه
	FETCH NEXT FROM product_cursor
	INTO @ProductId, @Name, @Color
	PRINT @ProductId
	PRINT @Name
	PRINT @Color
END
--7.بستن کرسر
CLOSE product_cursor
--8.تخلیه کرسر از حافظه
DEALLOCATE product_cursor
GO
USE Blogging
GO
DECLARE @TableFullName NVARCHAR(100)
DECLARE @TableName NVARCHAR(100)
DECLARE tables_cursor CURSOR
FOR
SELECT TABLE_NAME 'TableName',TABLE_SCHEMA + '.' + TABLE_NAME 'TableFullName'
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'

OPEN tables_cursor

FETCH NEXT FROM tables_cursor
INTO @TableName,@TableFullName

DECLARE @query_text NVARCHAR(2000)

	SET @query_text = N'CREATE PROC USP_Insert_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

	SET @query_text = N'CREATE PROC USP_Select_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

	SET @query_text = N'CREATE PROC USP_Update_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

	SET @query_text = N'CREATE PROC USP_Delete_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text


WHILE @@FETCH_STATUS = 0
BEGIN
	FETCH NEXT FROM tables_cursor
	INTO @TableName,@TableFullName


	SET @query_text = N'CREATE PROC USP_Insert_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

	SET @query_text = N'CREATE PROC USP_Select_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

	SET @query_text = N'CREATE PROC USP_Update_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

	SET @query_text = N'CREATE PROC USP_Delete_' + @TableName + N' (@SampleParam INT) AS BEGIN SELECT @SampleParam END'
	EXEC sp_executesql @query_text

END
CLOSE tables_cursor
DEALLOCATE tables_cursor
GO