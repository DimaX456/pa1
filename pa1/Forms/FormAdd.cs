using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa1
{
    public partial class FormAdd : Form
    {
        DataBase dataBase = new DataBase();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int price;
            if (int.TryParse(productCostTextBox.Text, out price))
            {
                var addQuery = $"";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("");
            }
            dataBase.closeConnection();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            productArticleNumberTextBox.Text = "";
            productCategoryTextBox.Text = "";
            productCostTextBox.Text = "";
            productDescriptionTextBox.Text = "";
            productDiscountAmountTextBox.Text = "";
            productManufacturerTextBox.Text = "";
            productMaxSizeDiscountAmountTextBox.Text = "";
            productNameTextBox.Text = "";
            productPhotoTextBox.Text = "";
            productQuantityInStockTextBox.Text = "";
            productStatusTextBox.Text = "";
            productUnitTextBox.Text = "";
        }
    }
}
