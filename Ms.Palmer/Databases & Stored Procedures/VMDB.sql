USE MASTER;

CREATE DATABASE VirtualMachineConfigurations;
USE VirtualMachineConfigurations; 

CREATE TABLE VMConfigurations (
UseCase VARCHAR (10) NOT NULL PRIMARY KEY,
OperatingSystem VARCHAR (15) NOT NULL,
Size INT NOT NULL,
OperatingSystemLicense VARCHAR (30) NULL,
GuestAdditions BIT NOT NULL
);

SELECT * FROM VMConfigurations;
