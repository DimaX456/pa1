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
            if (checkUser())
            {
                return;
            }

            var login = textBoxUsername1.Text;
            var password = textBoxPassword1.Text;

            string querystring = $"insert into User(UserLogin, UserPassword) values('{login}','{password}')";

            SqlCommand command= new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("");
                Form_log_in frm_log_in= new Form_log_in();
                this.Hide();
                frm_log_in.ShowDialog();
            }
            else
            {
                MessageBox.Show("");
            }
            dataBase.closeConnection();
        }
        private Boolean checkUser()
        {
            var loginUser = textBoxUsername1.Text;
            var passwordUser = textBoxPassword1.Text;

            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table= new DataTable();
            string querystring = $"select UserID, UserLogin, UserPassword from User where UserLogin = '{loginUser}' and UserPassword = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand= command;
            adapter.Fill(table);
            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("");
                return true;
            }
            else
            {
                return false;
            }
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
