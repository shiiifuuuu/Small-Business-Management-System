CREATE DATABASE SmallBusinessManagementSystem;
USE SmallBusinessManagementSystem;

CREATE TABLE Purchase
(
Id INT IDENTITY (1,1) PRIMARY KEY,
PurchaseDate Date,
InvoiceNo VARCHAR(10) NOT NULL UNIQUE,
Supplier VARCHAR(30) NOT NULL,
Category VARCHAR(30) NOT NULL,
Product VARCHAR(30) NOT NULL,
ProductCode VARCHAR(5) NOT NULL,
AvailableQuantity INT,
ManufactureDate VARCHAR(12) NOT NULL,
ExpireDate VARCHAR(12) NOT NULL,
Quantity INT,
UnitPrice FLOAT,
TotalPrice FLOAT,
PreviousUnitPrice FLOAT,
PreviousMRP FLOAT,
MRP Float,
Remarks VARCHAR(100)
)

SELECT * FROM Purchase
DELETE FROM Purchase
DROP TABLE Purchase

EXEC sp_rename 'Purchase.InvoidNo', 'InvoiceNo', 'COLUMN'

SELECT * FROM Product WHERE Category = 'Mobile'

INSERT INTO Purchase(PurchaseDate, InvoiceNo, Supplier, Category, Product, ProductCode, AvailableQuantity,
ManufactureDate, ExpireDate, Quantity, UnitPrice, TotalPrice, PreviousUnitPrice, PreviousMRP, MRP, Remarks)
VALUES('','','','','','',0,'','',0,0,0,0,0,0,'')