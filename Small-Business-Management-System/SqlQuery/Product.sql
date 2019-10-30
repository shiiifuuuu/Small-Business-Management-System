CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;

CREATE TABLE Product
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(4) UNIQUE NOT NULL,
Name VARCHAR(30) UNIQUE NOT NULL,
Category VARCHAR(30) NOT NULL,
ReorderLevel INT,
Description VARCHAR(100) NOT NULL
)

DROP TABLE Product;
DELETE FROM Product;
SELECT * FROM Product

SELECT * FROM Product LEFT JOIN Category ON CategoryId=Category.Id

INSERT INTO Product (Code, Name, ReorderLevel, Description)
VALUES
('sdf','fs','s','s');

INSERT [dbo].[Product] ([Id], [Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (1, N'H81M', N'Asrock', N'Motherboard', 10, N'4th Gen')
INSERT [dbo].[Product] ([Id], [Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (2, N'B250', N'MSI', N'Motherboard', 10, N'4th Gen')
INSERT [dbo].[Product] ([Id], [Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (3, N'3220', N'Intel', N'Processor', 25, N'Pentium dual core 4th gen')
INSERT [dbo].[Product] ([Id], [Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (5, N'CR10', N'Creative', N'Speaker', 10, N'Creative Sterio')
INSERT [dbo].[Product] ([Id], [Code], [Name], [Category], [ReorderLevel], [Description]) VALUES (6, N'B150', N'Gigabyte', N'Motherboard', 10, N'4th Gen')

UPDATE Customer 
Set Name='',Address=''
WHERE Id=2;

SELECT * FROM Customer WHERE Name='' OR Email='';

SELECT * FROM Product WHERE Category = 'Mobile'
SELECT * FROM Purchase