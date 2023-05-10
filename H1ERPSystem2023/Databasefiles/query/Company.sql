USE H1PD021123_Gruppe5;
DROP TABLE IF EXISTS Company;

CREATE TABLE Company
(
    ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CompanyName VARCHAR(30),
    Street VARCHAR(30),
    StreetNumber INT,
    PostalCode INT,
    City VARCHAR(30),
    Country VARCHAR(30),
    Currency VARCHAR(3)
);

INSERT INTO Company (CompanyName, Street, StreetNumber, PostalCode, City, Country, Currency)
VALUES ('FiskeKutter', 'Fiskegade', 20, 9900, 'Frederikshavn', 'Denmark', 'DKK'),
('dårligtTalene', 'djævlegade', 900, 1050, 'Djævleøen', 'Denmark', 'DKK');

SELECT * FROM Company
