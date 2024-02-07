using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pa1.DBContext;
using pa1.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace pa1
{
    public partial class FormView : UserControl
    {
        private readonly Product product1;
        private EventHandler<(Product, byte[])> onImageChanged;
        public FormView(Product product)
        {
            InitializeComponent();
            this.product1 = product;
            InitOrder(product);
            DostupButn();
        }
        //public Product Perfume => FormView;

        private void InitOrder(Product product)
        {
            labelName.Text = product.ProductName;
            DESC_lbl.Text = product.ProductDescription;
            Categ_LBL.Text = product.ProductCategory;
            MANUFlabel.Text = product.ProductManufacturer;
            labelPrice.Text = $"{product.ProductCost:C2}";
            DISCLABL.Text = product.ProductDiscountAmount.ToString();
            Instock.Text = product.ProductCost.ToString();
            ProdusctStatus.Text = product.ProductStatus ? "Есть в наличии" : "Нет в наличии";

            if (product.ProductPhoto != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(product.ProductPhoto));
            }
        }
        private void DostupButn()
        {
            if (Form_log_in.USER == null)
            {
            }
            else
            {
                if (Form_log_in.USER.UserRole == 1)
                {
                    buttonAdd.Enabled = true;
                }
                if (Form_log_in.USER.UserRole == 2)
                {
                    buttonAdd.Enabled = true;
                    buttonChange.Enabled = true;
                    Delbutton.Enabled = true;
                }
            }
        }
        //public event EventHandler<(Perfume, byte[])> ImageChanged
        //{
        //    add
        //    {
        //        onImageChanged += value;
        //    }
        //    remove
        //    {
        //        onImageChanged -= value;
        //    }
        //}

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //var perfumeedit = new 
            FormEdit FrmEdit = new FormEdit();
            FrmEdit.ShowDialog();
        }
    }
}
