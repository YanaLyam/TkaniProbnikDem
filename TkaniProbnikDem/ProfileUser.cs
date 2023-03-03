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

            RefreshDataTovar();
            
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }
        public void RefreshDataTovar()
        {
            dataGridView.Rows.Clear();
            List<Product> list = SortBy(Product.GetProduct(tbSearch.Text));
            foreach (Product product in list)
            {
                int i = dataGridView.Rows.Add(product.ProductName, product.ProductDescription, product.ProductManufacturer, product.ProductCost, product.ProductQuantityInStock);
                dataGridView.Rows[i].Tag = product;
            }
            
        }
        private void tbSource_TextChanged(object sender, EventArgs e)
        {
            RefreshDataTovar();
        }
        public bool SortPrice(Product p)
        {
            if (cbSort.SelectedIndex == -1 || cbSort.SelectedIndex == 0)
            {
                return true;
            }
            Product products= (cbSort.SelectedItem as Product);
            if (products != null)
            {
                return p.ProductCost==products.ProductCost;
            }
            return false;
        }
        public List<Product> SortBy (List<Product> list)
        {
            if (ckbSort.Checked)
            {
                if (cbSort.SelectedIndex == -1)
                    return list.OrderBy(p => p.ProductId).ToList();
                else if (cbSort.SelectedItem.ToString() == "Название")
                    return list.OrderBy(p => p.ProductName).ToList();
                else if (cbSort.SelectedItem.ToString() == "Цена")
                    return list.OrderBy(p => p.ProductCost).ToList();
            }
            else
            {
                if (cbSort.SelectedIndex == -1)
                    return list.OrderByDescending(p => p.ProductId).ToList();
                else if (cbSort.SelectedItem.ToString() == "Название")
                    return list.OrderByDescending(p => p.ProductName).ToList();
                else if (cbSort.SelectedItem.ToString() == "Цена")
                    return list.OrderByDescending(p => p.ProductCost).ToList();
            }
            return list;
            
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataTovar();
        }

        private void ckbSort_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataTovar();
        }
        public void RefreshDataUsers()
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProfileUser_Load(object sender, EventArgs e)
        {

        }
    }
}



