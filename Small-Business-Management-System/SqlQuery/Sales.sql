CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;


CREATE TABLE Sales
(
Id INT IDENTITY(1,1) PRIMARY KEY,
PurchaseId INT FOREIGN KEY REFERENCES Purchase(Id),
CustomerId INT FOREIGN KEY REFERENCES Customer(Id),
Code VARCHAR(11) UNIQUE NOT NULL,
Customer VARCHAR(30)  NOT NULL,
SalesDate    Date,
LoyalityPoint FLOAT,
Category VARCHAR(30) NOT NULL,
Product VARCHAR(30) NOT NULL,
AvabileQuantity INT,
Quantity INT,
MRP FLOAT,
TotalMRP FLOAT,
GrandTotal FLOAT,
Discount FLOAT,
DiscountAmount FLOAT,
PayableAmount FLOAT,
);

Select * from Sales;