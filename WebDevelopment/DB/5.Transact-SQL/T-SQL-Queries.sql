/* 1 */	
CREATE TABLE Persons(
Id int IDENTITY PRIMARY KEY,
FirstName nvarchar(20) NOT NULL,
LastName nvarchar(30) NOT NULL,
SSN nvarchar(100) NOT NULL
)
GO

CREATE TABLE Accounts(
Id int IDENTITY PRIMARY KEY,
PersonId int NOT NULL,
Balance money NOT NULL DEFAULT 0
CONSTRAINT FK_Acconuts_Persons FOREIGN KEY(PersonId) References Persons(Id)
)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Svetlin', 'Nakov', '8965821582')
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Niki', 'Kostov', '4258965214')
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Doncho', 'Minkov', '8521589657')
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Georgi', 'Georgiev', '8963258964')

INSERT INTO Accounts(PersonId, Balance)
VALUES(1, 254852)
INSERT INTO Accounts(PersonId, Balance)
VALUES(2, 12589)
INSERT INTO Accounts(PersonId, Balance)
VALUES(3, 5236)
INSERT INTO Accounts(PersonId, Balance)
VALUES(4, 15000)

USE Bank

GO

CREATE PROC usp_DisplayFullName
AS
	SELECT FirstName + ' ' + LastName
	FROM Persons

GO

EXEC usp_DisplayFullName

/* 2 */
CREATE PROC usp_DisplayPersonsBalance(
	@balanceValue money)
AS 
	SELECT FirstName + ' ' + LastName,  a.Balance
	FROM Persons p
		JOIN Accounts a
		  ON p.Id = a.PersonId
	WHERE a.Balance >= @balanceValue

GO

EXEC usp_DisplayPersonsBalance 6000

/* 3 */
CREATE FUNCTION ufn_CalculateInterestForMonths(@sum money, @rate money, @months int)
	returns money
AS
BEGIN
	DECLARE @currentRate money;
	SET @currentRate = (@rate / 12) * @months;
	RETURN (CAST(@sum as money) * @currentRate/100);
END


SELECT Balance, dbo.ufn_CalculateInterestForMonths(Balance, 10, 12) as Bonus
FROM Accounts

/* 4 */
CREATE PROC usp_CalculateInterestForMonth(@personId int, @rate money)
AS
	SELECT Balance, dbo.ufn_CalculateInterestForMonths(Balance, 10, 12)
	FROM Accounts
	WHERE PersonId = @personId

EXEC usp_CalculateInterestForMonth 2, 10

/* 5 */
CREATE PROC usp_WithdrawMoney( @accountId int, @withdrawMoney money)
AS
	UPDATE Accounts
	SET Balance = Balance - @withdrawMoney
	WHERE Id = @accountId

GO

CREATE PROC usp_DepositMoney( @accountId int, @depositMoney money)
AS
	UPDATE Accounts
	SET Balance = Balance + @depositMoney
	WHERE Id = @accountId

GO

/* 6 */
CREATE TABLE Logs(
	LogId int IDENTITY PRIMARY KEY NOT NULL,
	AccountId int NOT NULL,
	OldSum money NOT NULL,
	NewSum money NOT NULL
CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountId) REFERENCES Accounts(Id)
)

GO

ALTER TRIGGER tr_InsertNewRecord ON Accounts AFTER INSERT
AS
BEGIN
	DECLARE @transId int;
	SELECT @transId = MAX(id) FROM Accounts;
    INSERT INTO Logs
	SELECT  @transId, 0, Balance FROM inserted
END

GO

Create TRIGGER tr_DeleteAccount ON Accounts AFTER DELETE
AS
BEGIN
	DECLARE @transId int;
	SELECT @transId = id FROM Deleted;
    INSERT INTO Logs
	SELECT  @transId, Balance, 0 FROM Deleted
END

GO

CREATE TRIGGER tr_UpdateAccount ON Accounts AFTER UPDATE
AS
BEGIN
	DECLARE @transId int;
	SELECT @transId = id FROM Deleted;

	DECLARE @oldBalance money;
	SELECT @oldBalance = Balance FROM deleted;

	DECLARE @newBalance money;
	SELECT @newBalance = Balance FROM inserted;

    INSERT INTO Logs
	SELECT  @transId, @oldBalance, @newBalance
END

GO

UPDATE Accounts 
	SET Balance = 21 
WHERE PersonId = 3

INSERT INTO Accounts(PersonId, Balance)
VALUES(1, 254852)

DELETE FROM Accounts WHERE id = 5

/* 7 */

/* 23 */

/* 23 */

/* 23 */

/* 23 */

/* 23 */

/* 23 */	