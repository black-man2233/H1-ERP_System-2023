----� Kevin Bamwesa 2023,  Feel free to use it

-- Drop Table IF EXISTS Customers;
-- Drop Table If EXISTS Addresses;

----// Address
Create Table Addresses
(
    AddressId    int Primary Key IDENTITY (1,1) Not NUll,
    Street       varChar(20),
    StreetNumber varChar(20),
    City         varChar(20),
    PostalCode   varChar(20),
    Country      varChar(20),
);

----// Customer
CREATE TABLE Customers
(
    CustomerNumber   int Primary Key IDENTITY (1,1) NOT NULL,
    LastPurchaseDate datetime NULL,
    FirstName        varChar(20),
    LastName         varChar(20),
    PhoneNumber      varchar(15),
    EmailAddress     varChar(20),
    AddressID        int NOT NULL FOREIGN KEY REFERENCES dbo.Addresses (AddressId)
);

----//Insertation of Items
-- Addesses
Insert into Addresses (Street, StreetNumber, City, PostalCode, Country)
Values ('Main Street', '900', 'New York', '10001', 'USA'),
       ('Java Lane', '1858', 'Copenhagen', '900', 'DK'),
       ('Oxford Street', '513', 'London', '8965', 'UK'),
       ('Horizon Circle', '2946', 'London', '865', 'UK'),
       ('Champs-Élysées', '865', 'Paris', '75008', 'France');

--Customers
INSERT INTO dbo.Customers
(LastPurchaseDate, FirstName, LastName, PhoneNumber, EmailAddress, AddressId)
VALUES
    ('2023-02-01 10:30:00', 'John', 'Nig', '123-456-7890', 'johndoe@example.com', 1),
    ('2022-01-10 14:45:00', 'Jane', 'Ga', '987-654-3210', 'janedoe@example.com', 2),
    ('2022-03-5 14:45:00', 'Mathias', 'Schaltz', '987-654-3210', 'janedoe@example.com', 3),
    ('2022-05-25 14:45:00', 'Kevin', 'Doe', '987-654-3210', 'janedoe@example.com', 4),
    (NULL, 'Zilas', 'Smith', '555-123-4567', 'bobsmith@example.com', 5);


SELECT *
FROM Customers
         INNER JOIN dbo.Addresses ON Customers.AddressID = dbo.Addresses.AddressId;
