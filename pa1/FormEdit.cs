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
    public partial class FormEdit : Form
    {
        private readonly Product product1;
        public Product product => product1;
        public FormEdit()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Text = "Добавить продукт";
            buttonAdd.Text = "Добавить продукт";
            this.product1 = new Product();
        }
        public FormEdit(Product product) : this()
        {
            Text = "Изменить продукт";
            buttonAdd.Text = "Изменить ";

            this.product1 = product;
            textBox1.Text = product.ProductArticleNumber;
            textBox2.Text = product.ProductName;
            textBox3.Text = product.ProductDescription;
            comboBox1.Text = product.ProductCategory;
            textBox4.Text = product.ProductManufacturer;
            textBox5.Text = product.ProductCost.ToString();
            textBox6.Text = product.ProductDiscountAmount.ToString();
            textBox7.Text = product.ProductQuantityInStock.ToString();
            checkBox1.Checked = product.ProductStatus;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            product.ProductArticleNumber = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            product.ProductName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            product.ProductDescription = textBox3.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            product.ProductDescription = comboBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            product.ProductManufacturer = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            product.ProductCost = Convert.ToInt32(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            product.ProductDiscountAmount = Convert.ToDecimal(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            product.ProductQuantityInStock = Convert.ToInt32(textBox7.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            product.ProductStatus = checkBox1.Checked;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new TradeContext(DataBaseHelper.Option()))
            {
                Product product = new Product
                {
                    ProductArticleNumber = textBox1.Text,
                    ProductName = textBox2.Text,
                    ProductDescription = textBox3.Text,
                    ProductCategory = (string)comboBox1.SelectedItem,
                    ProductManufacturer = textBox4.Text,
                    ProductCost = Convert.ToInt32(textBox5.Text),
                    ProductDiscountAmount = Convert.ToDecimal(textBox6.Text),
                    ProductQuantityInStock = Convert.ToInt32(textBox7.Text),
                    ProductStatus = checkBox1.Checked,
                };

                db.Product.Add(product);
                db.SaveChanges();
                this.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
