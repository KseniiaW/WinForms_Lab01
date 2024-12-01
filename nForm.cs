using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_L1
{
    public partial class nForm : Form
    {
        private bool nclose = false; 
        
        public nForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(nForm_FormClosing);
        }

        public new void Close()
        {
            nclose = true;
            base.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                Hide();
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
