-- Harjoitus 2a
SELECT COUNT(CustomerID) AS 'Lukum‰‰r‰'
FROM Customers

-- Harjoitus 2b
/*
SELECT ProductName, UnitPrice, UnitsInStock, UnitPrice * UnitsInStock
FROM Products
*/

SELECT SUM(UnitPrice * UnitsInStock)
FROM Products

-- Harjoitus 2c
SELECT UnitPrice, Quantity, UnitPrice * Quantity
FROM [Order Details]
WHERE ProductID = 14

/*
SELECT SUM(UnitPrice * Quantity)
FROM [Order Details]
WHERE ProductID = 14
*/

SELECT SUM(UnitPrice * Quantity * (1 - Discount))
FROM [Order Details]
WHERE ProductID = 14

SELECT *
FROM Products

SELECT SUM(UnitPrice * Quantity)
FROM [Order Details]
WHERE (ProductID = 14) OR (ProductID = 74)

SELECT SUM(UnitPrice * Quantity * (1 - Discount))
FROM [Order Details]
WHERE (ProductID = 14) OR (ProductID = 74)

SELECT SUM(UnitPrice * Quantity * (1 - Discount))
FROM [Order Details]
WHERE ProductID IN (14, 74)


SELECT SUM(UnitPrice * Quantity * (1 - Discount))
FROM [Order Details]
WHERE ProductID = (SELECT ProductID
                   FROM Products
				   WHERE ProductName = 'Tofu')

SELECT SUM(UnitPrice * Quantity * (1 - Discount))
FROM [Order Details]
WHERE ProductID IN (SELECT ProductID
                    FROM Products
				    WHERE ProductName LIKE '%Tofu%')
