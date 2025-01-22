USE Dotnet_Generic_Repository;
GO

CREATE TABLE Customers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NULL,
    Identification NVARCHAR(100) NULL
);
GO

CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NULL,
    Price FLOAT NOT NULL
);
GO
