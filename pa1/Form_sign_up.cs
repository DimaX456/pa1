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
        DataBase dataBase = new DataBase();
        public Form_sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            //if (checkUser())
            //{
            //    return;
            //}

            var login = textBoxUsername1.Text;
            var password = textBoxPassword1.Text;

            
        }
    }
}
