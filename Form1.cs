using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductCategory.Models;
using ProductCategory.Data;
using ProductCategory.Services;

namespace ProductCategory.Models
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            LoginBusiness loginBusiness = new LoginBusiness();  
            var kullanıcıadı = textBoxusername.Text;
            var sifre = textBoxpassword.Text;
            bool correct = loginBusiness.loginControl(kullanıcıadı,sifre);
            if (correct)
            {
                mainpage mainpage = new mainpage();
                mainpage.Show();
            }
            else
            {
                label3.Show();
                textBoxpassword.Clear();
                textBoxusername.Clear();
            }            
        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {
            textBoxpassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
