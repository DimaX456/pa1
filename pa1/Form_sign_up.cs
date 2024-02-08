using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pa1
{
    public partial class Form_sign_up : Form
    {
        
        public Form_sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonVisible_Click(object sender, EventArgs e)
        {
            textBoxPassword1.UseSystemPasswordChar = false;
            buttonVisible.Visible = false;
            buttonNotVisible.Visible = true;
        }

        private void buttonNotVisible_Click(object sender, EventArgs e)
        {
            textBoxPassword1.UseSystemPasswordChar = true;
            buttonVisible.Visible = true;
            buttonNotVisible.Visible = false;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_log_in frmlogin = new Form_log_in();
            frmlogin.Show();
            this.Hide();
        }
    }
}
