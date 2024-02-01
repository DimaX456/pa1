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
using static pa1.TradepaDataSet;
using pa1.TradepaDataSetTableAdapters;

namespace pa1
{
    public partial class Form_log_in : Form
    {
        DataBase database = new DataBase();
        public Form_log_in()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            var LoginUser = textBoxUsername.Text;
            var LoginPassword = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            ////UserRole

            string querystring = $"select UserID, UserLogin, UserPassword, from User where UserLogin = '{LoginUser}' and UserPassword = {LoginPassword}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вы вошли на свой аккаунт!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Form1 frm1 = new Form1(user);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Вы указали неправильный Логин или Пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=C40312\\SQLEXPRESS;Initial Catalog=Tradepa;Integrated Security=True";
            //con.Open();
            //string LoginUser = textBoxUsername.Text;
            //string LoginPassword = textBoxPassword.Text;
            //SqlCommand cmd = new SqlCommand("select");
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("");
            //    System.Diagnostics.Process.Start("");
            //}
            //else
            //{
            //    MessageBox.Show("");
            //}

        }

        private void Form_log_in_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=C40312\\SQLEXPRESS;Initial Catalog=Tradepa;Integrated Security=True");
            //con.Open();
            //textBoxPassword.PasswordChar = '●';
            //buttonNotVisible.Visible = false;
            textBoxUsername.MaxLength = 50;
            textBoxPassword.MaxLength = 50;
        }

        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_sign_up frmsignup = new Form_sign_up();
            frmsignup.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonVisible_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            buttonVisible.Visible= false;
            buttonNotVisible.Visible= true;
        }

        private void buttonNotVisible_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            buttonVisible.Visible = true;
            buttonNotVisible.Visible = false;
        }

        private void buttonEnterNotLogIn_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
