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
        }
        private void FormView_ImageChanged(object sender, (Perfume, byte[]) e)
        {
            using (var db = new pa1Context(DBOptions.Options()))
            {
                db.Entry(e.Item1).State = EntityState.Modified;
                e.Item1.ImagePreview = e.Item2;
                db.SaveChanges();
            }
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            //using (var db = new pa1Context(DBOptions.Options()))
            //{
            //    var frmshp = db.FormShop.Include(nameof(Perfume.Types)).ToList();
            //    foreach (var perfume in frmshp)
            //    {
            //        var shopinfo = new FormView(perfume);
            //        shopinfo.Parent = flowLayoutPanel1;
            //        shopinfo.ImageChanged += FormView_ImageChanged;
            //    }
            //}
        }
    }
}
