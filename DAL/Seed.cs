using System.Data;

namespace Guest_Shabbat_Host_App.DAL
{
    internal class SeedService
    {
        private DBContext _dbContext;
        public SeedService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void EnsureTablesAndSeedData()
        {
            string sqlScript = @"USE Shabbat;
                                GO

                                DECLARE @TableCreated INT = 0;

                                BEGIN TRANSACTION;

                                BEGIN TRY

                                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FoodCategories' AND type = 'U')
                                    BEGIN
                                        CREATE TABLE FoodCategories
                                        (
                                            CategoryID INT PRIMARY KEY IDENTITY(1,1),
                                            CategoryName NVARCHAR(255) NOT NULL UNIQUE
                                        );
                                        INSERT INTO FoodCategories (CategoryName)
                                        VALUES (N'דגים'), (N'בשר'), (N'משקאות'), (N'סלטים'), (N'קינוחים');
                                        SET @TableCreated = 1; -- Set to 1 to indicate that the table was created
                                    END
                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH

                                    ROLLBACK TRANSACTION;
                                    SET @TableCreated = 0; -- Set to 0 to indicate an error or that the table was not created
                                END CATCH
                                SELECT @TableCreated AS IsCreated;";
            _dbContext.ExecuteNonQuery(sqlScript, null);
            DataTable result = _dbContext.ExecuteQuery("SELECT COUNT(*) as test FROM FoodCategories;", null);
            if (result.Rows.Count<=0) {
                throw new Exception("FoodCategories Seed failed...");
            }
        }
    }

}
