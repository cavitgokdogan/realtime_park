using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormTumKayitlar : Form
    {
        public FormTumKayitlar()
        {
            InitializeComponent();
        }

        private void FormTumKayitlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet.arabalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arabalarTableAdapter.Fill(this.otoparkDataSet.arabalar);

        }
    }
}
