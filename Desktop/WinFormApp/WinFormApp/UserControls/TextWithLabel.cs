using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp.UserControls
{
    public partial class TextWithLabel : UserControl
    {
        public TextWithLabel()
        {
            InitializeComponent();
        }

        public string txtLabelText
        {
            get
            {
                return lblText.Text;
            }
            set
            {
                lblText.Text = value;
            }
        }

        public string txtTextBoxText
        {
            get
            {
                return txtText.Text;
            }
            set
            {
                txtText.Text = value;
            }
        }
    }
}