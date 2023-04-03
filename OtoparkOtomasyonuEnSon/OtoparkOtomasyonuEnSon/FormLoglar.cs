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
    public partial class FormLoglar : Form
    {
        public FormLoglar()
        {
            InitializeComponent();
        }

        private void FormLoglar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otoparkDataSet6.log' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.logTableAdapter.Fill(this.otoparkDataSet6.log);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
