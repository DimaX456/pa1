using pa1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pa1.DBContext;
using Microsoft.Identity.Client;

namespace pa1
{
    public partial class UserControl1 : UserControl
    {
        private readonly Product product1;
        private EventHandler<(Product, byte[])> onImageChanged;
        public UserControl1(Product product)
        {
            InitializeComponent();
            this.product1 = product;
            InitOrder(product);
            DostupButn();
        }
        private void InitOrder(Product product)
        {
            labelName.Text = product.ProductName;
            DESC_lbl.Text = product.ProductDescription;
            Categ_LBL.Text = product.ProductCategory;
            MANUFlabel.Text = product.ProductManufacturer;
            PriceLBL.Text = $"{product.ProductCost:C2}";
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
                    buttonEdd.Enabled = true;
                    buttonDelete.Enabled = true;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (TradeContext db = new TradeContext(DataBaseHelper.Option()))
            {
                Product product = db.Product.FirstOrDefault();
                if (product != null)
                {
                    db.Product.Remove(product);
                    db.SaveChanges();
                    this.Hide();
                }
            }
            
        }

        private void buttonEdd_Click(object sender, EventArgs e)
        {
            using (var db = new TradeContext(DataBaseHelper.Option()))
            {
                var productDb = db.Product.FirstOrDefault(x => x.ProductArticleNumber == product1.ProductArticleNumber);
                var productEdit = new FormEdit(productDb);
                productEdit.ShowDialog();
            };
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            //var image = File.ReadAllBytes(openFileDialog1.FileName);
            //onImageChanged?.Invoke(product1, image);
            //pictureBox1.Image = Image.FromStream(new MemoryStream(image));
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }
        public event Action<Product, byte[]> OnImageChanged;
        public event EventHandler<(Product, byte[])> ImageChanged
        {
            add
            {
                onImageChanged += value;
            }
            remove
            {
                onImageChanged -= value;
            }
        }
    }
}
