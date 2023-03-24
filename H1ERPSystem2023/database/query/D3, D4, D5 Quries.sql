----� Kevin Bamwesa 2023,  Feel free to use it

--Drop Table Addres;
--Drop Table Customer;
--Drop Table Person;


----// Address
Create Table Addres(
    AddressId int Primary Key Not NUll,
    Street varChar(20),
    City varChar(20),
    PostalCode varChar(20),
    Country varChar(20),
);
----// Customer
CREATE TABLE Customer (
    CustomerNumber int NOT NULL Primary Key,
    LastPurchaseDate datetime NULL,
);
---- // Person 
Create table Person(
    PersonId int NOT NULL Primary Key,
    FirstName varChar(20),
    LastName varChar(20),
    PhoneNumber varchar(15),
    EmailAddress varChar(20),
    Addres int NOT NULL FOREIGN KEY REFERENCES dbo.Addres(AddressId),
    CustomerNumber int NOT NULL FOREIGN KEY REFERENCES dbo.Customer(CustomerNumber),
);


----//Insertation of Items
--Customer
INSERT INTO Customer (CustomerNumber, LastPurchaseDate) 
VALUES 
(101, '2022-02-01 10:30:00'),
(102, '2022-03-15 14:45:00'),
(103, NULL);

--Adress
INSERT INTO Addres (AddressId, Street, City, PostalCode, Country)
VALUES
(1, 'Main Street', 'New York', '10001', 'USA'),
(2, 'Oxford Street', 'London', 'W1D 1BS', 'UK'),
(3, 'Champs-Élysées', 'Paris', '75008', 'France');

--Persons
Insert Into Person (PersonId,FirstName,LastName,PhoneNumber,EmailAddress,Addres,CustomerNumber )
Values(1, 'John', 'Doe', '123-456-7890', 'johndoe@example.com', 1, 101),
(2, 'Jane', 'Doe', '987-654-3210', 'janedoe@example.com', 2, 102),
(3, 'Bob', 'Smith', '555-123-4567', 'bobsmith@example.com', 3, 103);


SELECT *
FROM Person
INNER JOIN dbo.Addres ON Person.Addres = dbo.Addres.AddressId;
