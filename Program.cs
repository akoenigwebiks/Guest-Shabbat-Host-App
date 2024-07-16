using Microsoft.Extensions.Configuration;
using Guest_Shabbat_Host_App.Views;
using Guest_Shabbat_Host_App.DAL;
using Guest_Shabbat_Host_App.DAL.Repositories;


namespace Guest_Shabbat_Host_App
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                      .AddUserSecrets<Program>()
                      .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];

            if (string.IsNullOrEmpty(conn) || string.IsNullOrEmpty(dbName))
            {
                throw new ArgumentNullException("Connection string or database name is missing");
            }

            DBContext dbCtx = new DBContext(conn);
            dbCtx.CheckConnectionToDefaultDB(dbName);
            SeedService seedService = new SeedService(dbCtx,dbName);
            seedService.EnsureTablesAndSeedData();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainForm = new HostForm(new CategoryRepository(dbCtx));

            Application.Run(mainForm);
        }
    }
}