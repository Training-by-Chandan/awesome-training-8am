using HRManagment.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagment.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void ResetFields()
        {
            txtUser.Text = String.Empty;
            txtPassword.Text = String.Empty; ;
        }

        private void LoginUser()
        {
            //validations
            var userService = new UserService();
            var res = userService.Login(txtUser.Text, txtPassword.Text);
            if (res.Item1)
            {
                //logics
                this.MdiParent.Text = $"Welcome {Singleton.Instance.Username} to HR Management";
                Singleton.Instance.ApplyUserChange();
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}