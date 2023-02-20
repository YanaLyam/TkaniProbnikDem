using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TkaniProbnikDem
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLogin.Text) && !string.IsNullOrEmpty(tbPass.Text))
            {
                DataTable table = BD.Instance.SqlZapros($"SELECT * FROM `User` WHERE `UserLogin`= '{tbLogin.Text}' AND `UserPassword` = '{tbPass.Text}'");

                if (table.Rows.Count > 0)
                {
                    User.localuser = new User(table.Rows[0]);
                    ProfileUserForm profileUserf = new ProfileUserForm();
                    profileUserf.Show();
                    Hide();

                }
            }
        }
    }
}
