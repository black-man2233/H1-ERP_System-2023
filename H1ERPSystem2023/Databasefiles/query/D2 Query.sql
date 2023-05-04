USE H1PD021123_Gruppe5;
DROP TABLE IF EXISTS Products;


CREATE TABLE Products
(
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(20),
    Descriptionn TEXT,
    SalePrice NUMERIC,
    BuyPrice NUMERIC,
    Locationn VARCHAR(20),
    StorageAmount FLOAT,
    Avance AS SalePrice - BuyPrice,
    AvanceProcent AS (SalePrice - BuyPrice) / BuyPrice * 100
);
	


INSERT INTO Products (ProductName, Descriptionn, SalePrice, BuyPrice, Locationn, StorageAmount)
VALUES
('Computer', 'Good pc for work' , 4000, 2500, 'Denmark' , 20),
('vandflasker', 'Good pc for work' , 20, 5, 'Denmark' , 200);

SELECT * FROM Products;
