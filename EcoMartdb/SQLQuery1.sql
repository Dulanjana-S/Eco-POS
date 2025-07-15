-- Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50),
    Password NVARCHAR(50),
    --Role NVARCHAR(20) -- Admin or Cashier
    -- Sample Admin User


);

-- Products table
CREATE TABLE ProductManager (
    ProductID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Category NVARCHAR(50),
    Price DECIMAL(10, 2),
    Quantity INT
);

-- Sales table
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY,
    SaleDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2),
    --Cashier NVARCHAR(50)
);

-- SalesHistory table
CREATE TABLE SalesHistory (
    SaleDetailID INT PRIMARY KEY IDENTITY,
    SaleID INT FOREIGN KEY REFERENCES Sales(SaleID),
    ProductID INT FOREIGN KEY REFERENCES ProductManager(ProductID),
    Quantity INT,
    Price DECIMAL(10,2),
    Total DECIMAL(10,2)
);
