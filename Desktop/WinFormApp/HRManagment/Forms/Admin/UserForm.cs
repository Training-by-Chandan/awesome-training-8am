using HRManagment.Models;
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

namespace HRManagment.Forms.Admin
{
    public partial class UserForm : Form
    {
        private readonly UserService userService = new UserService();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            cmbUserType.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void CreateUser()
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }
            var usertype = (UserType)cmbUserType.SelectedItem;

            //todo create user here
            var result = userService.CreateUser(txtUserName.Text, txtPassword.Text, usertype);
            if (result.Item1)
            {
                //successfully created
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }
    }
}