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

namespace pa1
{
    public partial class FormView : UserControl
    {
        private readonly Perfume formView;
        private EventHandler<(Perfume, byte[])> onImageChanged;
        public FormView()
        {
            InitializeComponent();
            this.formView = Perfume;
            InitPerfume(Perfume);
        }
        public Perfume Perfume => formView;

        private void InitPerfume(Perfume perfume )
        {
            labelName.Text = perfume.Name;
            labelPrice.Text = $"{perfume.Price}";
            labelisActual.Text = perfume.IsActual ? "Актуален" : "Не актуален";
            labelisActual.ForeColor = perfume.IsActual ? Color.Green : Color.Red;
            labelCount.Text = perfume.Count.ToString();
            if (perfume.ImagePreview!= null )
            {
                // pictureTour.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
            }
        }
        public event EventHandler<(Perfume, byte[])> ImageChanged
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //var perfumeedit = new 
        }
    }
}
