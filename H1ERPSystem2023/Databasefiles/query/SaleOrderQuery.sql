DROP TABLE SaleOrder;
DROP TABLE OrderLines;

-- Create SaleOrder table (we gonna use the table in "SaleOrder")
CREATE Table OrderLines(
        ID int IDENTITY(1,1) Primary Key,
        ProductName text,
        Descriptions text,
        SalePrice int,
        BuyPrice int,
        Locations varchar(20),
        Quantity int,
        Measure varchar(10)
);

-- Create SaleOrder table 
Create Table SaleOrder(
    OrderNumber int IDENTITY(1,1),
    CreationDate DateTime,
    CompleteDate DateTime,
    CustomerID int NOT NULL FOREIGN KEY REFERENCES dbo.Customer(CustomerNumber),
    Condition varchar(10),
    OrderLineId int NOT NULL FOREIGN KEY REFERENCES dbo.OrderLines(ID)
);

--these two ""
INSERT INTO dbo.OrderLines(ProductName, Descriptions, SalePrice, BuyPrice, Locations, Quantity, Measure)
Values
('kevin', 'kevin is butiful', 10000000, 1, 'congo', 1, 'meter'),
('zilas', 'kevin is butiful', 10000000, 1, 'congo', 1, 'meter'),
('mathias', 'kevin is butiful', 10000000, 1, 'congo', 1, 'meter'),
('lukas', 'kevin is butiful', 10000000, 1, 'congo', 1, 'meter');


INSERT INTO SaleOrder(CreationDate, CompleteDate, CustomerID, Condition, OrderLineId)
values
('2022-03-15 14:45:00', '2022-03-15 14:45:00', 101,'GOOD', 1 ),
('2022-03-15 14:45:00', '2022-03-15 14:45:00', 101,'GOOD', 1 ),
('2022-03-15 14:45:00', '2022-03-15 14:45:00', 102,'GOOD', 1 ),
('2022-03-15 14:45:00', '2022-03-15 14:45:00', 103,'GOOD', 1 );

SELECT ProductName FROM dbo.OrderLines
INNER JOIN dbo.OrderLines ON SaleOrder.OrderLineId = dbo.OrderLines.ID
INNER JOIN dbo.Customer ON SaleOrder.CustomerID= dbo.Customer.CustomerNumber;




--Select * From Customer