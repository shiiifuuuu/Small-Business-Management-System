CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;

CREATE TABLE Purchase
(
Id INT IDENTITY (1,1) PRIMARY KEY,
PurchaseDate DATE,
InvoiceNo VARCHAR(10) NOT NULL UNIQUE,
Supplier VARCHAR(30) NOT NULL,
Category VARCHAR(30) NOT NULL,
Products VARCHAR(30) NOT NULL,
Code VARCHAR(5) NOT NULL,
AvailableQuantity VARCHAR(10) NOT NULL,
ManufactureDate DATE,
ExpireDate DATE,
Quantity VARCHAR(10) NOT NULL,
UnitPrice FLOAT,
TotalPrice FLOAT,
PreviousUnitPrice FLOAT,
PreviousMRP FLOAT,
MRP Float,
Remarks VARCHAR(100)
)

SELECT * FROM Purchase
DROP TABLE Purchase

ALTER TABLE Purchase
ALTER InvoidNo InvoiceNo VARCHAR(10);