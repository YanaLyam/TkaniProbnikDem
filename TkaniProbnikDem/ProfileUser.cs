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
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Rows.Add(e.RowIndex, e.ColumnIndex);
            //Product.GetProduct();
            //foreach (Product p in DataGrid)
            //{
            //    //p.ProductName = NameTovar;
            //}
        }
    }
}

