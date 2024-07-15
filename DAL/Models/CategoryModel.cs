using System.Data;

namespace Guest_Shabbat_Host_App.DAL.Models
{
    internal class CategoryModel
    {
        public string CategoryName { get; set; }
        public int? CategoryID { get; set; }

        public CategoryModel(string categoryName, int? categoryID)
        {
            CategoryName = categoryName;
            CategoryID = categoryID;
        }

        // ctor from datarow
        public CategoryModel(DataRow row)
        {
            if (row == null || row["CategoryName"] == null)
            {
                throw new System.ArgumentNullException(nameof(row));
            }
            CategoryName = row["CategoryName"].ToString()!;
            CategoryID = (int)row["CategoryID"];
        }
    }
}
