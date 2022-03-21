using HRManagment.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "HR Management | " + ConfigurationManager.AppSettings["CompanyName"].ToString();
            Login l = new Login();
            l.MdiParent = this;
            l.Show();
            Singleton.Instance.UserChangeEvent += Instance_UserChangeEvent;
        }

        private void Instance_UserChangeEvent()
        {
            switch (Singleton.Instance.UserType)
            {
                case Models.UserType.Employee:
                    this.MainMenuStrip = employeeMenuStrip;
                    this.MainMenuStrip.Visible = true;
                    break;

                case Models.UserType.Manager:
                    break;

                case Models.UserType.Admin:
                    this.MainMenuStrip = adminMainMenu;
                    this.MainMenuStrip.Visible = true;
                    break;

                default:
                    this.MainMenuStrip = null;
                    break;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HRManagment.Forms.Admin.UserForm u = new Forms.Admin.UserForm();
            u.MdiParent = this;
            u.Show();
        }
    }
}