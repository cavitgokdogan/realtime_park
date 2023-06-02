using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonuEnSon
{
    public partial class ManualForm : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-UNTJT3U;Initial Catalog=otopark;Integrated Security=True";

        public ManualForm()
        {
            InitializeComponent();
        }

        private void createRegistryButtonClick(object sender, EventArgs e)
        {
            DateTime secilenZaman = dateTimePicker1.Value;
            TimeSpan secilenVakit = secilenZaman.TimeOfDay;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(ConnectionString))
                {
                    baglanti.Open();

                    string insertArabalar = "insert into dbo.arabalar (plaka, telefon_no,giris_saati) values (@p1,@p2,@p3)";
                    using (SqlCommand komut = new SqlCommand(insertArabalar, baglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", textBox1.Text);
                        komut.Parameters.AddWithValue("@p2", textBox2.Text);
                        komut.Parameters.AddWithValue("@p3", secilenZaman.Date.ToString("yyyy-MM-dd") + " " + secilenVakit);
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kayıt Oluşturuldu!");
            }
            catch (Exception ex)
            {
                // anlamsız - exception log'lanabilir - (en azından başarısız olduğu kullanıcıya bildirilmiş)
                MessageBox.Show("Bağlantı Kurulamadı !\n" + ex.Message);
            }
        }

        private void goBackButtonClick(object sender, EventArgs e)
        {
            using (FormGiris formGiris = new FormGiris())
            {
                this.Hide();
                formGiris.ShowDialog();
            }
            this.Show();
            //Form Giriş Sayfasına Geçiş
        }

        private void registryPageButtonClick(object sender, EventArgs e)
        {
            using (FormKayitlar formKayitlar = new FormKayitlar())
            {
                this.Hide();
                formKayitlar.ShowDialog();
            }
            this.Show();

            //Form Kayıtlar Sayfasına Geçiş
        }

        private void entranceDateValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            // Date Time Picker üzerinden Alınan Verinin Tarih ve Saat Formatına Çevrilmesi
        }
    }
}
