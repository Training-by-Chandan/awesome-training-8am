using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Button is clicked", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
                MessageBox.Show("Yes is clicked");
            else if (res == DialogResult.No)
                MessageBox.Show("No is clicked");

            //this.txtName.Text = "Sample Text";
            listName.Items.Add(txtName.Text);
            cmbName.Items.Add(txtName.Text);
            txtName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basic basic = new Basic();
            basic.Show();
        }
    }
}