USE H1PD021123_Gruppe5;
DROP TABLE IF EXISTS Company;

CREATE TABLE Company
(
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CompanyName VARCHAR(30),
    Currency VARCHAR(3),
    AddressId int NOT NULL FOREIGN KEY references dbo.Addresses(AddressId),
);

INSERT INTO Company (CompanyName, Currency,AddressId)
VALUES ('FiskeKutter','DKK',1),
       ('dårligtTalene','DKK',3);

SELECT * FROM Company
