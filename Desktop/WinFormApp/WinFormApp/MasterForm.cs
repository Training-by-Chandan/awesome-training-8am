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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.MdiParent = this;
            l.Show();
        }

        private void rtBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBox rt = new RTBox();
            rt.MdiParent = this;
            rt.Show();
        }
    }
}