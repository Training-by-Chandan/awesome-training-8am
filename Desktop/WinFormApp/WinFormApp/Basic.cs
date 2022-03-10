using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Model;
using WinFormApp.Services;

namespace WinFormApp
{
    public partial class Basic : Form
    {
        private StudentService studentService = new StudentService();

        public Basic()
        {
            InitializeComponent();
            this.Load += Basic_Load;
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            //load the data
            LoadData();
        }

        private void LoadData()
        {
            gridStudent.DataSource = studentService.GetAll();
            gridStudent.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.FirstName = txtFName.Text;
            student.LastName = txtLName.Text;
            student.Email = txtEmail.Text;

            var result = studentService.Create(student);
            if (!result)
            {
                MessageBox.Show("Some error occured");
            }
            else
            {
                //reset the form
                ClearForm();
                LoadData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmail.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
        }
    }
}