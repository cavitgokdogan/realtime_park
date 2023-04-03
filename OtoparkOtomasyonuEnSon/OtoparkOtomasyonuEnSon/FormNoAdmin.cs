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
    public partial class FormNoAdmin : Form
    {
        public FormNoAdmin()
        {
            InitializeComponent();
        }

        private void FormNoAdmin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet7.arabalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arabalarTableAdapter.Fill(this.otoparkDataSet7.arabalar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
