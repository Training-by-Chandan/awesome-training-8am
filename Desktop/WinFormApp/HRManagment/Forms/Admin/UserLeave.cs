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
    public partial class UserLeave : Form
    {
        private LeaveService leaveService = new LeaveService();

        public UserLeave()
        {
            InitializeComponent();
        }

        private void UserLeave_Load(object sender, EventArgs e)
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(LeaveStatus));
            LoadData();
        }

        private void LoadData()
        {
            gridLeaves.DataSource = leaveService.GetAllList();
            gridLeaves.Refresh();
        }

        private void gridLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gridLeaves_SelectionChanged(object sender, EventArgs e)
        {
            var row = gridLeaves.SelectedRows;
            if (row.Count > 0)
            {
                lblId.Visible = true;
                cmbStatus.Visible = true;
                btnConfirm.Visible = true;

                lblId.Text = row[0].Cells["Id"].Value.ToString();
                cmbStatus.SelectedIndex = cmbStatus.FindStringExact(row[0].Cells["LeaveStatus"].Value.ToString());
            }
            else
            {
                Reset();
            }
        }

        private void Reset()
        {
            lblId.Visible = false;
            cmbStatus.Visible = false;
            btnConfirm.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var res = leaveService.ChangeLeaveStatus(Convert.ToInt32(lblId.Text), (LeaveStatus)cmbStatus.SelectedItem);
            if (res.Item1)
            {
                LoadData();
                Reset();
            }
        }
    }
}