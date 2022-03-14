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
            gridStudent.SelectionChanged += GridStudent_SelectionChanged;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                var result = MessageBox.Show("Do you want to update it?", "Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    var res = studentService.Edit(Convert.ToInt32(lblId.Text), txtFName.Text, txtLName.Text, txtEmail.Text);
                    if (res.Item1)
                    {
                        LoadData();
                        ClearForm();
                        ResetButtons();
                    }
                    else
                    {
                        MessageBox.Show(res.Item2);
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete it?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                var res = studentService.Delete(Convert.ToInt32(lblId.Text));
                if (res.Item1)
                {
                    LoadData();
                    ClearForm();
                    ResetButtons();
                }
                else
                {
                    MessageBox.Show(res.Item2);
                }
            }
        }

        private void GridStudent_SelectionChanged(object sender, EventArgs e)
        {
            //extract the data of selected row
            var selectedRows = gridStudent.SelectedRows;
            if (selectedRows != null && selectedRows.Count > 0)
            {
                var row = selectedRows[0];
                txtFName.Text = row.Cells["FirstName"].Value.ToString();
                txtLName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                lblId.Text = row.Cells["Id"].Value.ToString();

                btnCreate.Visible = false;
                btnReset.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                ClearForm();
                ResetButtons();
            }
        }

        private void ResetButtons()
        {
            btnCreate.Visible = true;
            btnReset.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
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
            if (Validation())
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
        }

        private bool Validation()
        {
            var res = true;
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                res = false;
                lblFnamevalid.Text = "* First name is required";
                txtFName.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                lblFnamevalid.Text = "*";
                txtFName.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                res = false;
                lblLnameValid.Text = "* Last name is required";
                txtLName.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                lblLnameValid.Text = "*";
                txtLName.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                res = false;
                lblEmailValid.Text = "* Email is required";
                txtEmail.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                lblEmailValid.Text = "*";
                txtEmail.BackColor = Color.White;
            }

            return res;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            lblId.Text = string.Empty;
        }
    }
}