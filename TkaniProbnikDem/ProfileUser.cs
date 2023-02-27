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
                int i = dataGridView.Rows.Add(product.ProductName,product.ProductDescription,product.ProductManufacturer,product.ProductCost);
                dataGridView.Rows[i].Tag = product;
            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }
    }
}



