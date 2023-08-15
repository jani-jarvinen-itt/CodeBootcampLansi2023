-- Harjoitus 1a
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Harjoitus 1b, alikyselynä (subquery)
SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerID
                    FROM Customers
                    WHERE CompanyName = 'Que Delícia')

-- liitosesimerkki (join)
SELECT o.*
FROM Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE c.CompanyName = 'Que Delícia'

/*
SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'
*/

-- Harjoitus 1c
SELECT *
FROM Employees
WHERE City = 'London'
