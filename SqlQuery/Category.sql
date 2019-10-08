CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;

CREATE TABLE Category
(Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Code VARCHAR(4) UNIQUE NOT NULL,
Name VARCHAR(20) UNIQUE NOT NULL);

DROP TABLE Category;
DELETE FROM Category;

SELECT * FROM Category;

INSERT INTO Category (Code, Name)
VALUES
('0001', 'Electronics');