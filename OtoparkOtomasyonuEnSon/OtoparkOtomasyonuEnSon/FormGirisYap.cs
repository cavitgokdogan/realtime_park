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