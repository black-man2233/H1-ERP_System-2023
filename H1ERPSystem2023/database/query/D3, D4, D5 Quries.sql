--© Kevin Bamwesa 2023,  Feel free to use it


----// Address
Create Table Addres(
AddressId int Primary Key Not NUll,
Street varChar(20),  
City varChar(20),
PostalCode varChar(20),
);

---- // Person 
Create table Person(
PersonId int NOT NULL Primary Key,
FirstName varChar(20),
LastName varChar(20),
Addres int NOT NULL FOREIGN KEY REFERENCES dbo.Addres(AddressId),
PhoneNumber varchar(15),
Email varChar(20)
);

----// Customer
CREATE TABLE Customer (
    customerNumber int NOT NULL Primary Key,
    OrderNumber int NOT NULL,
    PersonId int NOT NULL FOREIGN KEY REFERENCES dbo.Person(PersonId)
);
