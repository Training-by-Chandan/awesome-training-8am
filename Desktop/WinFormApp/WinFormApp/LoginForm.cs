using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Services;

namespace WinFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtUser.Text = String.Empty;
            txtPassword.Text = String.Empty; ;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            //validations
            var userService = new UserService();
            var res = userService.Login(txtUser.Text, txtPassword.Text);
            if (res.Item1)
            {
                Basic b = new Basic();
                b.MdiParent = this.MdiParent;
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}