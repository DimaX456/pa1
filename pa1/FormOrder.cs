using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pa1
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradepaDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.tradepaDataSet.Order);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonsort.Enabled = true;
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private void buttonsort_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = orderIDDataGridViewTextBoxColumn; break;
                case 1:
                    COL = orderCompositionDataGridViewTextBoxColumn; break;
                case 2:
                    COL = orderDateDataGridViewTextBoxColumn; break;
                case 3:
                    COL = orderDeliveryDateDataGridViewTextBoxColumn; break;
                case 4:
                    COL = orderPickupPointDataGridViewTextBoxColumn; break;
                case 5:
                    COL = fIOClientDataGridViewTextBoxColumn; break;
                case 6:
                    COL = codeGiveDataGridViewTextBoxColumn; break;
                case 7:
                    COL = orderStatusDataGridViewTextBoxColumn; break;
            }
            if (radioButton1.Checked)
                dataGridView1.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView1.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            orderBindingSource.Filter = "";
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount- 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

    }
}
