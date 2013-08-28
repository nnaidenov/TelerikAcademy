/* 4 */
SELECT * FROM Departments

/* 5 */
SELECT Name FROM Departments

/* 6 */
SELECT Salary FROM Employees

/* 7 */
SELECT FirstName + ' ' + LastName AS FullName FROM Employees

/* 8 */
SELECT FirstName + LastName + '@telerik.com' AS [Full Email Addresses] FROM Employees

/* 9 */
SELECT DISTINCT Salary FROM Employees

/* 10 */
SELECT * FROM Employees 
WHERE JobTitle = 'Sales Representative'

/* 11 */
SELECT FirstName + ' ' + LastName FROM Employees 
WHERE FirstName LIKE 'SA%'

/* 12 */
SELECT FirstName + ' ' + LastName FROM Employees 
WHERE LastName LIKE '%ei%'

/* 13 */
SELECT Salary FROM Employees 
WHERE Salary BETWEEN 20000 AND 30000

/* 14 */
SELECT FirstName + ' ' + LastName FROM Employees 
WHERE Salary IN (25000, 14000, 12500, 23600)

/* 15 */
SELECT FirstName + ' ' + LastName FROM Employees 
WHERE ManagerID IS NULL

/* 16 */
SELECT Salary FROM Employees 
WHERE Salary > 50000
ORDER BY Salary DESC

/* 17 */
SELECT TOP 5 Salary FROM Employees ORDER BY Salary DESC

/* 18 */
SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', a.AddressText
FROM Employees e  JOIN Addresses a
ON e.AddressID = a.AddressID

/* 19 */
SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', a.AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

/* 20 */
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', m.FirstName + ' ' +  m.LastName AS 'Manager Name'
FROM Employees e JOIN Employees m
ON e.ManagerID = m.EmployeeID

/* 21 */
SELECT e.LastName, a.AddressText, m.LastName, ma.AddressText
	FROM Employees e 
		LEFT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
		JOIN Addresses a
		ON e.AddressID = a.AddressID
		JOIN Addresses ma
		ON m.AddressID = ma.AddressID

/* 22 */
SELECT Name
FROM Departments d
UNION
	SELECT a.AddressText
	FROM Addresses a 
UNION
	SELECT t.Name
	FROM Towns t

/* 23 */
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', m.FirstName + ' ' +  m.LastName AS 'Manager Name'
FROM Employees e LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', m.FirstName + ' ' +  m.LastName AS 'Manager Name'
FROM Employees e RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

/* 24 */
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', d.Name, e.HireDate
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance') AND YEAR(e.HireDate) BETWEEN 1990 AND 2005

