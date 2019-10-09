CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;

CREATE TABLE Category
(Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Code VARCHAR(4) UNIQUE NOT NULL,
Name VARCHAR(20) UNIQUE NOT NULL);

DROP TABLE Category;
DELETE FROM Category WHERE Id=2;

SELECT * FROM Category;

INSERT INTO Category (Code, Name)
VALUES
('0001', 'Electronics');

SELECT Code FROM Category WHERE Code = 0001;

SELECT * FROM Category WHERE Code LIKE '10%' OR Name LIKE 'Cam%'