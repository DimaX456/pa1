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
    public partial class FormChange : Form
    {
        public FormChange()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tradepaDataSet);

        }

        private void FormChange_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradepaDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradepaDataSet.Product);

        }

        private void Change()
        {
            //int price;
            //if (int.TryParse(productCostTextBox.Text).ToString() != string.Empty)
            //{

            //}
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }
    }
}
