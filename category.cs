using ProductCategory.Data;
using ProductCategory.Models;
using ProductCategory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategory
{
    public partial class category : Form
    {
        BookStoreDbContext db = new BookStoreDbContext();
        CategoryBusiness CategoryBusiness = new CategoryBusiness();
        Category selectedCategory = null;
        public category()
        {
            InitializeComponent();
        }

        private void category_Load(object sender, EventArgs e)
        {
            ShowCategories();
            ShowCategoriesComboBox();
        }

        private void ShowCategoriesComboBox()
        {
            comboBoxcategories.DataSource = db.Categories.ToList();
            comboBoxcategories.DisplayMember = "Name";
            comboBoxcategories.ValueMember = "Id";
        }

        private void ShowCategories()
        {
            dataGridView1.DataSource = CategoryBusiness.GetCategories();
         

        }

        private void buttoncatadd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = textBoxcatname.Text;
            CategoryBusiness.AddCategory(category);

            ShowCategories();
            ShowCategoriesComboBox();
        }

        private void buttoncatupdate_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textBoxcatname.Text;
            CategoryBusiness.UpdateCategory(selectedCategory);

            ShowCategories();
            ShowCategoriesComboBox();
        }

        private void comboBoxcategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxcategories.SelectedValue;
            selectedCategory = CategoryBusiness.GetCategoriesById(selectedCategoryId);
            textBoxcatname.Text = selectedCategory.Name;
            buttoncatdelete.Enabled = true;
            buttoncatupdate.Enabled = true;

        }

        private void buttoncatdelete_Click(object sender, EventArgs e)
        {
            CategoryBusiness.DeleteCategory(selectedCategory);

            ShowCategories();
            ShowCategoriesComboBox();
        }


    }
}
