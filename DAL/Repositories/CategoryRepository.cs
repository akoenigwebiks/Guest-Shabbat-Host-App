using Guest_Shabbat_Host_App.DAL.Models;
using System.Data;
using System.Data.SqlClient;

namespace Guest_Shabbat_Host_App.DAL.Repositories
{
    internal class CategoryRepository: IRepository<CategoryModel>
    {
        private readonly DBContext _dbContext;

        public CategoryRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CategoryModel> FindAll()
        {
            var categories = new List<CategoryModel>();
            string query = "SELECT CategoryID, CategoryName FROM Food";

            DataTable result = _dbContext.ExecuteQuery(query, null);
            foreach (DataRow row in result.Rows)
            {
                categories.Add(new CategoryModel(row));
            }

            return categories;
        }

        public CategoryModel FindById(int categoryId)
        {
            string query = "SELECT CategoryID, CategoryName FROM Food WHERE CategoryID = @CategoryID";
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };

            DataTable result = _dbContext.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
            {
                return null;
            }

            return new CategoryModel(result.Rows[0]);
        }

        public bool Insert(CategoryModel category)
        {
            string query = "INSERT INTO Food (CategoryName) VALUES (@CategoryName)";
            SqlParameter[] parameters = { new SqlParameter("@CategoryName", category.CategoryName) };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Update(CategoryModel category)
        {
            string query = "UPDATE Food SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID";
            SqlParameter[] parameters = {
                new SqlParameter("@CategoryName", category.CategoryName),
                new SqlParameter("@CategoryID", category.CategoryID)
            };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Delete(int categoryId)
        {
            string query = "DELETE FROM Food WHERE CategoryID = @CategoryID";
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
