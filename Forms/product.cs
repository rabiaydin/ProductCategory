using ProductCategory.Data;
using ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductCategory.Services;

namespace ProductCategory
{
    public partial class product : Form
    {
        BookStoreDbContext db = new BookStoreDbContext();        
        ProductBusiness productBusiness = new ProductBusiness();
        Product selectedProduct = null;
        public product()
        {
            InitializeComponent();
        }
        private void comboBoxproducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxproducts.SelectedValue;
            var product= productBusiness.GetProductsById(selectedProductId);
            selectedProduct = product;
            textBoxproname.Text = product.Name;
            textBoxauthor.Text = product.Author;
            comboBoxprocat.SelectedItem = product.CategoryName;
            buttonprodelete.Enabled = true;
            buttonproupdate.Enabled = true;
        }
        private void buttonproadd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBoxproname.Text;
            product.Author = textBoxauthor.Text;
            product.CategoryId =(int) comboBoxprocat.SelectedValue;
            var Varmi = productBusiness.GetProductByName(product.Name);
            if (Varmi)
            {
                DialogResult dialog = new DialogResult();
                dialog=MessageBox.Show($"{product.Name} book is on the list.Would you like doing adding? ","",MessageBoxButtons.YesNo);
                if (dialog==DialogResult.Yes)
                {
                    productBusiness.AddProduct(product);
                    ShowProducts();
                    ShowProductsComboBox();
                }
                else
                {
                    textBoxproname.Clear();
                    textBoxauthor.Clear();
                }
            }
            else
            {
                productBusiness.AddProduct(product);
                ShowProducts();
                ShowProductsComboBox();
                
            }

        }

        private void ShowProductsComboBox()
        {
            comboBoxproducts.DataSource = db.Products.ToList();
            comboBoxproducts.DisplayMember = "Name";
            comboBoxproducts.ValueMember = "Id";

        }

        private void ShowProducts()
        {
            dataGridView1.DataSource = productBusiness.GetProducts();
            this.dataGridView1.Columns["CategoryId"].Visible = false;
            this.dataGridView1.Columns["Category"].Visible = false;

        }

        private void buttonproupdate_Click(object sender, EventArgs e)
        {
            selectedProduct.Name= textBoxproname.Text;
            selectedProduct.Author= textBoxauthor.Text;
            selectedProduct.CategoryName=comboBoxprocat.Text;

            productBusiness.UpdateProduct(selectedProduct);

            ShowProducts();
            ShowProductsComboBox();
        
        }

        private void buttonprodelete_Click(object sender, EventArgs e)
        {

            productBusiness.DeleteProduct(selectedProduct);
            ShowProducts();
            ShowProductsComboBox();
          
        }

      

        private void product_Load(object sender, EventArgs e)
        {
            ShowProducts();
            

            comboBoxprocat.DataSource = db.Categories.ToList();
            comboBoxprocat.DisplayMember = "Name";
            comboBoxprocat.ValueMember = "Id";
            ShowProductsComboBox();
        }



    }
}
