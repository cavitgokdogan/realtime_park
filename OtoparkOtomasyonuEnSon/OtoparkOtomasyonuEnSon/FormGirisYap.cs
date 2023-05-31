using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormGirisYap : Form
    {
        public FormGirisYap()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKullaniciAdi.Text == "admin" && txtParola.Text == "admin")
                {
                    FormGiris formGiris = new FormGiris();
                    this.Hide();
                    formGiris.Show();

                }
                
                if(txtKullaniciAdi.Text == "kullanıcı" && txtParola.Text == "kullanıcı")
                {
                    FormNoAdmin formNoAdmin = new FormNoAdmin();
                    this.Hide();
                    formNoAdmin.ShowDialog();
                }
                
            }
            catch (Exception) 
                {
                    MessageBox.Show("Hatalı Bilgi Girdiniz!");
                }
        }
    }
}