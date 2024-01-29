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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradepaDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradepaDataSet.Product);

        }

        private void radioButtonUbiv_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUbiv.Checked)
                dataGridView1.Sort(productCostDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView1.Sort(productCostDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i, j].Value.ToString().IndexOf(textBoxFind.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }
    }
}
