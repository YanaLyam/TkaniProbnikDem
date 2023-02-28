using Microsoft.Build.Framework.XamlTypes;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TkaniProbnikDem
{
    public partial class ProfileUser : Form
    {

        public ProfileUser()
        {
            InitializeComponent();
            lbSurname.Text = $"Фамилия: {User.localuser.UserSurname}";
            lbName.Text = $"Имя: {User.localuser.UserName}";
            lbPatronymic.Text = $"Отчество: {User.localuser.UserPatronymic}";
            lbRole.Text = $"Роль: {User.GetRoleName(User.localuser.UserRole)}";

            List<Product> list = Product.GetProduct();
            foreach (Product product in list)
            {
                int i = dataGridView.Rows.Add(product.ProductName,product.ProductDescription,product.ProductManufacturer,product.ProductCost,product.ProductQuantityInStock);
                dataGridView.Rows[i].Tag = product;
            }

            List<Product> sortlist = Product.SortingASC();
            foreach (Product product in sortlist)
            {
                int s=cbSort.Items.Add(product);
                dataGridView.Rows[s].Tag= product;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }

        private void cbSort_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}



