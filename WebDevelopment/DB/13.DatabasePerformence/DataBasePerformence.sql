---------------------------------------------------------------------
-- Create database HomeWorkPerformanceDB
---------------------------------------------------------------------

USE master
GO

CREATE DATABASE HomeWorkPerformanceDB
GO

USE HomeWorkPerformanceDB
GO

---------------------------------------------------------------------
-- Ex1
---------------------------------------------------------------------
---------------------------------------------------------------------
-- Create table Books and populate 10 000 000 rows in it  - 2min 37sec
---------------------------------------------------------------------

CREATE TABLE Books(
  BookId int NOT NULL PRIMARY KEY IDENTITY,
  BookName varchar(100),
  BookTime date,
  SomeText text,
)
SET NOCOUNT ON
DECLARE @AuthorsCount int = (SELECT COUNT(*) FROM Books)
DECLARE @RowCount int = 10000000
WHILE @RowCount > 0
BEGIN
  DECLARE @Text nvarchar(100) = 
    'Text ' + CONVERT(nvarchar(100), @RowCount) + ': ' +
    CONVERT(nvarchar(100), newid())
  DECLARE @Date datetime = 
	DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
  INSERT INTO Books(BookName, BookTime)
  VALUES(@Text, @Date)
  SET @RowCount = @RowCount - 1
END
SET NOCOUNT OFF

WHILE (SELECT COUNT(*) FROM Books) < 10000000
BEGIN
  INSERT INTO Books(BookName, BookTime)
  SELECT BookName, BookTime FROM Books
END

---------------------------------------------------------------------
-- Ex2
---------------------------------------------------------------------
---------------------------------------------------------------------
-- Search with index
---------------------------------------------------------------------

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Books
WHERE BookTime > '31-Dec-2011' and BookTime < '1-Jan-2015'

CREATE INDEX IDX_Books_BookName ON Books(BookName)

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Books
WHERE BookTime > '31-Dec-2011' and BookTime < '1-Jan-2015'

DROP INDEX IDX_Books_BookName ON Books

---------------------------------------------------------------------
-- Ex3
---------------------------------------------------------------------
---------------------------------------------------------------------
-- Add full-text index and search by indexed text column (left LIKE)
---------------------------------------------------------------------

CREATE FULLTEXT CATALOG MessagesFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Books(SomeText)
KEY INDEX PK_Messages_MsgId
ON MessagesFullTextCatalog
WITH CHANGE_TRACKING AUTO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Books
WHERE CONTAINS(SomeText, '123')

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

-- This is still slow
SELECT COUNT(*) FROM Books
WHERE SomeText LIKE '%123%'

DROP FULLTEXT INDEX ON Books
DROP FULLTEXT CATALOG MessagesFullTextCatalog

---------------------------------------------------------------------
-- Ex4
---------------------------------------------------------------------
---------------------------------------------------------------------
-- Table partitioning in MySQL
---------------------------------------------------------------------

CREATE DATABASE BookDB;

USE BookDB;

CREATE TABLE Authors(
  AuthorId int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  AuthorName varchar(100)
);

INSERT INTO Authors(AuthorName) VALUES
  ('Svetlin Nakov'), ('Doncho Minkov'), ('Nikolay Kostov'), ('George Georgiev');

CREATE TABLE Messages(
  MsgId int NOT NULL AUTO_INCREMENT,
  AuthorId int NOT NULL,
  MsgText nvarchar(300),
  MsgDate datetime,
  PRIMARY KEY (MsgId, AuthorId)
) PARTITION BY HASH(AuthorId) PARTITIONS 3;

INSERT INTO Messages(AuthorId, MsgText, MsgDate) VALUES
  (1, 'Some text', NOW()), (2, 'Another text', NOW()),
  (3, 'Third msg', NOW()), (2, 'Fourth msg', NOW());

SELECT * FROM Messages
WHERE AuthorId = 2;

EXPLAIN PARTITIONS SELECT * FROM Messages;

EXPLAIN PARTITIONS SELECT * FROM Messages WHERE AuthorId = 2;

DROP TABLE Messages;

CREATE TABLE Messages(
  MsgId int NOT NULL AUTO_INCREMENT,
  MsgText nvarchar(300),
  MsgDate datetime,
  PRIMARY KEY (MsgId, MsgDate)
) PARTITION BY RANGE(YEAR(MsgDate)) (
    PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p1 VALUES LESS THAN (1995),
    PARTITION p2 VALUES LESS THAN (2000),
    PARTITION p3 VALUES LESS THAN (2005),
    PARTITION p4 VALUES LESS THAN MAXVALUE
);

INSERT INTO Messages(MsgText, MsgDate) VALUES
  ('Some text', '2003-8-11'),
  ('Some text', '1985-7-25'),
  ('Some text', '2011-3-31'),
  ('Some text', '1992-1-1'),
  ('Some text', '1994-9-21'),
  ('Some text', '2013-1-31'),
  ('Some text', '2012-1-31'),
  ('Some text', '2004-7-27'),
  ('Some text', '2008-1-24');

SELECT * FROM Messages PARTITION (p0);
SELECT * FROM Messages PARTITION (p1);
SELECT * FROM Messages PARTITION (p2);
SELECT * FROM Messages PARTITION (p3);
SELECT * FROM Messages PARTITION (p4);

-- Select from all partittions
SELECT * FROM Messages;

-- Select from a single partition
SELECT * FROM Messages WHERE YEAR(MsgDate) > 2005;