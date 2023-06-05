using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormGirisYap : Form
    {
        public FormGirisYap()
        {
            InitializeComponent();
            this.Text = "OtoOto";
        }

        private void PicGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string parola = txtParola.Text.Trim();

            switch (kullaniciAdi)
            {
                case "admin" when parola == "1234":
                    FormGiris form0 = new FormGiris();
                    form0.Show();
                    Hide();
                    break;
                   

                case "kullanici" when parola == "1234":
                    FormNoAdmin form1 = new FormNoAdmin();
                    form1.Show();
                    Hide();
                    break;

                default:
                    lblHata.Visible = true;
                    break;
            }
        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (lblHata.Visible)
                lblHata.Visible = false;
        }

        private void TxtParola_TextChanged(object sender, EventArgs e)
        {
            if (lblHata.Visible)
                lblHata.Visible = false;
        }

        private void FormGirisYap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                PicGirisYap_Click(sender, e);
        }

        private void TxtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                PicGirisYap_Click(sender, e);
        }

        private void TxtParola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                PicGirisYap_Click(sender, e);
        }
    }
}