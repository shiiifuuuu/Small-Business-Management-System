CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;


CREATE TABLE Sales
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(11) UNIQUE NOT NULL,
Customer VARCHAR(30)  NOT NULL,
SalesDate    Date,
LoyalityPoint FLOAT,
Category VARCHAR(30) NOT NULL,
Product VARCHAR(30) NOT NULL,
AvabileQuantity INT(11),
Quantity INT(11) ,
MRP FLOAT,
TotalMRP FLOAT,
GrandTotal FLOAT,
Discount FLOAT,
DiscountAmount FLOAT,
PayableAmount FLOAT,

)