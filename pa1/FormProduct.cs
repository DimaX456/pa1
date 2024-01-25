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

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
