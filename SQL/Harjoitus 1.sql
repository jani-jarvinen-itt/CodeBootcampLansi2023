-- Harjoitus 1a
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Harjoitus 1b, alikyselyn� (subquery)
SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerID
                    FROM Customers
                    WHERE CompanyName = 'Que Del�cia')

-- liitosesimerkki (join)
SELECT o.*
FROM Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE c.CompanyName = 'Que Del�cia'

/*
SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'
*/

-- Harjoitus 1c
SELECT *
FROM Employees
WHERE City = 'London'
