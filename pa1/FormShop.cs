using Microsoft.EntityFrameworkCore;
using pa1.DBContext;
using pa1.Models;
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
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
            Dostup();
        }

        private void Dostup()
        {
            if (Form_log_in.USER == null)
            {
                labelName.Enabled= false;
            }
            else
            {
                labelName.Text = $"{Form_log_in.USER.UserSurname} {Form_log_in.USER.UserName} {Form_log_in.USER.UserPatronymic} {Form_log_in.USER.UserRole}";
            }
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            using (var TradeContext = new TradeContext(DataBaseHelper.Option()))
            {
                var products = TradeContext.Product.ToList();
                foreach (var product in products)
                {

                    var userControl = new UserControl1(product);
                    userControl.Parent = flowLayoutPanel1;
                    userControl.ImageChanged += UserControl_ImageChanged; ;
                }
            }
            //using (var TradeContext = new TradeContext(DataBaseHelper.Option()))
            //{
            //    var products = TradeContext.Product.Select(x => x.ProductName).ToList()
            //    foreach (var product in products)
            //    {
            //        var userControl = new UserControl1(product);
            //        userControl.Parent = flowLayoutPanel1;
            //        userControl.ImageChanged += UserControl_ImageChanged;
            //    }
            //}
        }
        private void UserControl_ImageChanged(object sender, (Product, byte[]) e)
        {
            throw new NotImplementedException();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
