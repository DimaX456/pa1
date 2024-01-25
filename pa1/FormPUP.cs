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
    public partial class FormPUP : Form
    {
        public FormPUP()
        {
            InitializeComponent();
        }

        private void FormPUP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradepaDataSet.PickUpPoint". При необходимости она может быть перемещена или удалена.
            this.pickUpPointTableAdapter.Fill(this.tradepaDataSet.PickUpPoint);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form();
            frm1.Show();
        }
    }
}
