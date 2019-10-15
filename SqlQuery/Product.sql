CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;

CREATE TABLE Product
(Id INT IDENTITY(1,1) PRIMARY KEY,
Category VARCHAR(50) NOT NULL,
Code VARCHAR(4) UNIQUE NOT NULL,
Name VARCHAR(30) NOT NULL,
ReorderLevel VARCHAR(100) NOT NULL,
Description VARCHAR(100) NOT NULL);

DROP TABLE Product;
DELETE FROM Product;

SELECT * FROM Product;

INSERT INTO Product (Code, Name, ReorderLevel, Description)
VALUES
('sdf','fs','s','s');

UPDATE Customer 
Set Name='',Address=''
WHERE Id=2;

SELECT * FROM Customer WHERE Name='' OR Email='';