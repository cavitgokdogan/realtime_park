using System;
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
            // Bu kod satırı 'otoparkDataSet7.arabalar' tablosuna veri yükler.
            // Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arabalarTableAdapter.Fill(this.otoparkDataSet7.arabalar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormGirisYap form1 = new FormGirisYap())
            {
                this.Hide();
                form1.ShowDialog();
            }
        }
    }
}
