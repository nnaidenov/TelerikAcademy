/* 1 */
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', e.Salary
FROM Employees e
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)
	
/* 2 */
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', e.Salary
FROM Employees e
WHERE Salary >= 
	(SELECT MIN(Salary)*1.1 FROM Employees)

/* 3 */
SELECT e.FirstName + ' ' + e.LastName AS 'Employee Name', e.Salary, d.Name
FROM Employees e 
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
		(SELECT MIN(Salary) FROM Employees
		WHERE e.DepartmentID = DepartmentID)
		
/* 4 */
SELECT  AVG(Salary)
FROM Employees e
WHERE e.DepartmentID = 1
	
/* 5 */
SELECT AVG(Salary)
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
	
/* 6 */
SELECT COUNT(EmployeeID)
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
	
/* 7 */
SELECT COUNT(EmployeeID)
FROM Employees e
WHERE e.ManagerID IS NOT NULL
	
/* 8 */
SELECT COUNT(EmployeeID)
FROM Employees e
WHERE e.ManagerID IS NULL
	
/* 9 */
SELECT AVG(Salary), d.Name
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
	
/* 10 */
SELECT COUNT(e.DepartmentID), d.Name, t.Name
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
	  ON e.AddressID = a.AddressID
	JOIN Towns t
	  ON a.TownID = t.TownID
GROUP BY d.Name, a.TownID, t.Name
	
/* 11 */
SELECT m.FirstName + ' ' + m.LastName, COUNT(e.FirstName)
FROM Employees e
	JOIN Employees m
	  ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName + ' ' + m.LastName
HAVING COUNT(e.FirstName) = 5
	
/* 12 */
SELECT e.FirstName + ' ' + e.LastName AS 'Empl Name', COALESCE( m.FirstName + ' ' + m.LastName, 'no manager')  AS 'Manager Name'
FROM Employees e
	LEFT JOIN Employees m
	  ON e.ManagerID = m.EmployeeID
	
/* 13 */
SELECT e.FirstName + ' ' + e.LastName AS 'Empl Name'
FROM Employees e
WHERE LEN(e.LastName) = 5
	
/* 14 */
SELECT CONVERT(varchar(20), GETDATE(), 113)
	
/* 15 */
CREATE TABLE Users(
UserId int IDENTITY PRIMARY KEY,
Username nvarchar(20) NOT NULL,
UserPassword nvarchar(64) NOT NULL CHECK (LEN(UserPassword) > 5),
LastLogin smalldatetime NOT NULL  DEFAULT GETDATE(),
CONSTRAINT AK_Username UNIQUE(Username)
)
	
/* 16 */
CREATE VIEW [Users that have been in the system today] AS
SELECT u.Username, u.LastLogin
FROM Users u
WHERE 
	YEAR(u.LastLogin) = YEAR(GETDATE()) AND 
	MONTH(u.LastLogin) = MONTH(GETDATE()) AND 
	DAY(u.LastLogin) = DAY(GETDATE())
	
SELECT * FROM [Users that have been in the system today]
	
/* 17 */	
CREATE TABLE Groups(
GroupId int IDENTITY PRIMARY KEY,
Name nvarchar(50) UNIQUE(Name)
)

/* 18 */	
ALTER TABLE Users
ADD [GroupId] int NOT NULL DEFAULT ((0))

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Group FOREIGN KEY(GroupId) References Groups(GroupId)

/* 19 */
INSERT INTO Groups (Name) VALUES('SQL')
INSERT INTO Groups (Name) VALUES('C#')
INSERT INTO Groups (Name) VALUES('HTML5')
INSERT INTO Groups (Name) VALUES('JS')
INSERT INTO Groups (Name) VALUES('DB')
INSERT INTO Groups (Name) VALUES('MySQL')

INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('nakov', '12548925fsdfdas', 2)
INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('doncho', '12548925fsdfdas', 1)
INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('niki', '12548925fsdfdas', 1)
INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('joro', '12548925fsdfdas', 4)
INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('vanko', '12548925fsdfdas', 5)
INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('theHunter', '12548925fsdfdas', 2)
INSERT INTO Users (Username, UserPassword, GroupID) 
VALUES('vladko', '12548925fsdfdas', 2)
	
/* 20 */
UPDATE Groups 
SET Name = 'New SQL'
WHERE GroupId = 1

UPDATE Users 
SET GroupID = 6
WHERE Username = 'werew'
	
/* 21 */	
DELETE FROM Users
WHERE GroupId = 2

DELETE FROM Groups
WHERE GroupId = 2

/* 22 */
INSERT INTO Users (Username, UserPassword)
(SELECT FirstName + ' ' + LastName,
LOWER(SUBSTRING(FirstName, 0, 1) + LastName + 'passs') 
FROM Employees)
	
/* 23 */
UPDATE Users
SET UserPassword = 'default'
WHERE LastLogin > '10.03.2010'
--Because in my table all users is new
	
/* 24 */
DELETE FROM Users
WHERE UserPassword = 'default'
	
/* 25 */	
SELECT AVG(e.Salary), d.Name, e.JobTitle
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

/* 26 */	
SELECT MIN(e.Salary), d.Name, e.JobTitle, e.LastName
FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.LastName
ORDER BY d.Name

/* 27 */	
SELECT TOP 1 COUNT(t.Name) AS 'PersonInTown', t.Name
FROM Employees e
	JOIN Addresses a
	  ON e.AddressID = a.AddressID
	JOIN Towns t
	  ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [PersonInTown] DESC

/* 28 */	
SELECT COUNT(e.EmployeeID) AS 'PersonInTown', t.Name
FROM Employees e
	JOIN Addresses a
	  ON e.AddressID = a.AddressID
	JOIN Towns t
	  ON a.TownID = t.TownID
WHERE e.ManagerID IS NULL
GROUP BY t.Name

/* 29 */	
CREATE TABLE WorkHours(
WorkHoursId int NOT NULL IDENTITY PRIMARY KEY,
EmployeeId int NOT NULL,
WorkDate date NOT NULL,
Task nvarchar(200),
WorkHours int,
Comments text
CONSTRAINT FK_Employee_WorkHour FOREIGN KEY(EmployeeId) REFERENCES Employees(EmployeeId)
)

INSERT INTO WorkHours (EmployeeId, WorkDate, Task, WorkHours, Comments) 
VALUES(5, GETDATE(), 'Task 1', 8, 'Very good')
INSERT INTO WorkHours (EmployeeId, WorkDate, Task, WorkHours, Comments) 
VALUES(5, GETDATE(), 'Task 5', 5, 'Good')
INSERT INTO WorkHours (EmployeeId, WorkDate, Task, WorkHours, Comments) 
VALUES(43, GETDATE(), 'Task 43', 18, 'Excellent')
INSERT INTO WorkHours (EmployeeId, WorkDate, Task)
VALUES(1, GETDATE(), 'Task 42')
INSERT INTO WorkHours (EmployeeId, WorkDate, Task, WorkHours) 
VALUES(210, GETDATE(), 'Task 12', 8)
INSERT INTO WorkHours (EmployeeId, WorkDate, Task, WorkHours, Comments) 
VALUES(5, GETDATE(), 'Task 111', 128, 'Poor')

/* 23 */	
/* 23 */

