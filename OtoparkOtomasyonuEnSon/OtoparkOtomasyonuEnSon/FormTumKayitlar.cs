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
            this.Text = "OtoOto";
        }

        private void FormTumKayitlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tumKayitlar.logArabalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.logArabalarTableAdapter.Fill(this.tumKayitlar.logArabalar);
            // TODO: Bu kod satırı 'otoparkDataSet.arabalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arabalarTableAdapter1.Fill(this.otoparkDataSet.arabalar);
            // TODO: Bu kod satırı 'otoparkDataSet4.arabalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arabalarTableAdapter.Fill(this.otoparkDataSet4.arabalar);

        }

        private void pnlCikisYap_Paint(object sender, PaintEventArgs e)
        {

        }


        private void picCikisYap_Click(object sender, EventArgs e)
        {
            FormKayitlar formKayitlar = new FormKayitlar();
            this.Hide();
            formKayitlar.ShowDialog();
        }

        private void picCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void picCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void lblCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void lblCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void pnlCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void pnlCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);
    }
}
