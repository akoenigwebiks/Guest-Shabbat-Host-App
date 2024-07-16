USE Shabbat;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Food' AND type = 'U')
BEGIN
    CREATE TABLE Food
    (
        CategoryID INT PRIMARY KEY IDENTITY(1,1),
        CategoryName NVARCHAR(255) NOT NULL UNIQUE
    )
END
GO

-- Insert categories, only if they do not already exist
-- No need for NOT EXISTS checks due to the UNIQUE constraint
TRUNCATE TABLE Food;
INSERT INTO Food (CategoryName)
VALUES (N'דגים'), (N'בשר'), (N'משקאות'), (N'סלטים'), (N'קינוחים');
