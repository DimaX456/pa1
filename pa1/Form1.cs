using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void авторизоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_log_in fli = new Form_log_in();
            fli.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct prd = new FormProduct();
            prd.Show();
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder ord = new FormOrder();
            ord.Show();
        }

        private void пунктВыдачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPUP pup = new FormPUP();
            pup.Show();
        }
    }
}
