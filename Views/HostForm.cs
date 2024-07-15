using ReaLTaiizor.Forms;
using System.Data;

namespace Guest_Shabbat_Host_App.Views
{
    public partial class HostForm : MaterialForm
    {
        private DataTable Categories;
        public HostForm()
        {
            InitializeComponent();
            Categories = new();
            Categories.Columns.Add("categories");
            Categories.Rows.Add("טונה");
            LoadCategories(Categories);
        }

        private void LoadCategories(DataTable categories)
        {
            listView_categoryList.Items.Clear(); // Clear existing items

            if (categories.Columns.Count > 0)
            {
                // Add new items from DataTable, concatenating all column values for each row
                foreach (DataRow row in categories.Rows)
                {
                    List<string> values = new List<string>();
                    foreach (DataColumn column in categories.Columns)
                    {
                        if (row[column] != DBNull.Value)
                        {
                            values.Add(row[column].ToString());
                        }
                    }
                    ListViewItem item = new ListViewItem(String.Join(" - ", values)); // Concatenate values with a separator
                    listView_categoryList.Items.Add(item);
                }
            }
            else
            {
                // Handle the case where there are no columns
                MessageBox.Show("No columns available in the DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_changePassword_Click(object sender, EventArgs e)
        {
            string category = textbox_category.Text.Trim();
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("נא להכניס קטגוריה להוספה");
                return;
            }

            // Check if the category already exists in the DataTable
            if (Categories.AsEnumerable().Any(row => row["categories"].ToString().Equals(category, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("הקטגוריה כבר קיימת");
                return;
            }

            // Add the new category
            Categories.Rows.Add(category);
            LoadCategories(Categories);  // Refresh the list view
        }
    }
}
