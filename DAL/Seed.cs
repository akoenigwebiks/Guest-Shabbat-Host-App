using System.Data;

namespace Guest_Shabbat_Host_App.DAL
{
    internal class SeedService
    {
        private DBContext _dbContext;
        private string DBName;
        public SeedService(DBContext dBContext,string dBName)
        {
            _dbContext = dBContext;
            DBName = dBName;
        }
        public void EnsureTablesAndSeedData()
        {
            string sqlScript = @$"USE {DBName};

                                DECLARE @TableCreated INT = 0;

                                BEGIN TRANSACTION;

                                BEGIN TRY

                                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Food' AND type = 'U')
                                    BEGIN
                                        CREATE TABLE Food
                                        (
                                            CategoryID INT PRIMARY KEY IDENTITY(1,1),
                                            CategoryName NVARCHAR(255) NOT NULL UNIQUE
                                        );
                                        INSERT INTO Food (CategoryName)
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
            DataTable result = _dbContext.ExecuteQuery("SELECT COUNT(*) as test FROM Food;", null);
            if (result.Rows.Count<=0) {
                throw new Exception("Food Seed failed...");
            }
        }
    }

}
