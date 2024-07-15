using Guest_Shabbat_Host_App.DAL.Models;
using Guest_Shabbat_Host_App.DAL.Repositories;
using ReaLTaiizor.Forms;
using System.Data;

namespace Guest_Shabbat_Host_App.Views
{
    internal partial class HostForm : MaterialForm
    {
        private CategoryRepository _categoryRepository;
        private DataTable Categories;
        public HostForm(CategoryRepository? categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            LoadCategories(_categoryRepository.FindAll());
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

        private void LoadCategories(List<CategoryModel> categories)
        {
            listView_categoryList.Items.Clear(); // Clear existing items
            listView_categoryList.Items.AddRange(categories.Select(category => new ListViewItem(category.CategoryName)).ToArray());
        }

        private void label_addCategory_Click(object sender, EventArgs e)
        {
            string category = textbox_category.Text.Trim();
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("נא להכניס קטגוריה להוספה");
                return;
            }

            bool sucess = _categoryRepository.Insert(new CategoryModel(category, null));
            if (!sucess)
            {
                MessageBox.Show("לא ניתן להוסיף קטגוריה");
            }
  
            LoadCategories(_categoryRepository.FindAll());
            textbox_category.Text = "";
        }
    }
}
