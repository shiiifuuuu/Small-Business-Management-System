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

SELECT * FROM Product LEFT JOIN Category ON CategoryId=Category.Id

INSERT INTO Product (Code, Name, ReorderLevel, Description)
VALUES
('sdf','fs','s','s');

UPDATE Customer 
Set Name='',Address=''
WHERE Id=2;

SELECT * FROM Customer WHERE Name='' OR Email='';

SELECT * FROM Product WHERE Category = 'Mobile'
SELECT * FROM Purchase