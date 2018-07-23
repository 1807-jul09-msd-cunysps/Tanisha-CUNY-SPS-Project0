/*
CREATE TABLE Customers 
    ([CustomerID] int PRIMARY KEY IDENTITY(1,1),
     [FirstName] varchar(50),
     [LastName] varchar(50),
	 [CardNumber] varchar(255)
);

INSERT INTO Customers 
    (CardNumber,FirstName,LastName)
VALUES
    ('2345','Terry','Lewis'),
    ('6789','Pam','Greene'),
    ('0987','Tina','Smith');

CREATE TABLE Products
	([ProductID] int PRIMARY KEY IDENTITY(1,1),
	[ProductName] varchar(50),
	[Price] int
);
	

INSERT INTO Products
	(ProductName, Price)
VALUES
	('LG-V20','120'),
	('Samsung','20'),
	('iPhone','200');

CREATE TABLE Orders
	([OrderID] int PRIMARY KEY IDENTITY(1,1),
	 [PID] int,
	 [CustomerID] int, 
	 FOREIGN KEY (PID) REFERENCES Products(ProductID),
	 FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);


INSERT INTO Orders
Values
((SELECT ProductID FROM Products WHERE (ProductName = 'iphone')),
(SELECT CustomerID FROM Customers WHERE (FirstName = 'Tina'))); 
*/ 

SELECT * FROM Orders 

SELECT OrderID, ProductName, FirstName,LastName FROM Orders 
INNER JOIN Customers
ON Customers.CustomerID = Orders.CustomerID
INNER JOIN Products
ON PID = ProductID
Where FirstName = 'Tina'
;

SELECT SUM(Price) AS iPhoneRevenue FROM Products AS Price
JOIN Orders AS Orders 
ON ProductID = ProductID
GROUP BY ProductName
Having ProductName = 'iPhone';
;

UPDATE Products
SET Price = 249.99
WHERE ProductName = 'iPhone';







