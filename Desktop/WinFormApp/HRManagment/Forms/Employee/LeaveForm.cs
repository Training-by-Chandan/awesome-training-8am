using HRManagment.Models;
using HRManagment.Service;
using HRManagment.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagment.Forms.Employee
{
    public partial class LeaveForm : Form
    {
        private LeaveService leaveService = new LeaveService();

        public LeaveForm()
        {
            InitializeComponent();
            comboLeave.DataSource = Enum.GetValues(typeof(LeaveType));
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void Apply()
        {
            var apply = new ApplyLeaveViewModel()
            {
                From = fromDate.Value,
                To = toDate.Value,
                LeaveType = (LeaveType)comboLeave.SelectedItem,
                Reason = txtReason.Text
            };
            var res = leaveService.ApplyForLeave(apply);
            if (res.Item1)
            {
                //successful
            }
            else
            {
                MessageBox.Show(res.Item2);
            }
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            toDate.Value = fromDate.Value;
        }
    }
}