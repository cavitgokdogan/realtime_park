using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormManual : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-UNTJT3U;Initial Catalog=otopark;Integrated Security=True";

        public FormManual()
        {
            InitializeComponent();
            this.Text = "OtoOto";
            timer_Tick(this, new EventArgs());
            timer.Start();
        }

        private void createRegistryButton_Click(object sender, EventArgs e)
        {
            if (numberPlateTextBox.Text.Length == 0 || telNoTextBox.Text.Length == 0)
            {
                MessageBox.Show("İlgili alanlar doldurulmadan kayıt yapılamaz.");
                return;
            }


            DateTime chosenTime = entranceDatePicker.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string insertArabalar = "insert into dbo.arabalar (plaka, telefon_no,giris_saati) values (@p1,@p2,@p3)";
                    using (SqlCommand command = new SqlCommand(insertArabalar, connection))
                    {
                        command.Parameters.AddWithValue("@p1", numberPlateTextBox.Text.Replace(" ", ""));
                        command.Parameters.AddWithValue("@p2", telNoTextBox.Text);
                        command.Parameters.AddWithValue("@p3", chosenTime);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kayıt Oluşturuldu!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Aynı plaka ile çıkış yapmadan tekrar giriş yapılamaz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Sağlanamadı !\n" + ex.Message);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            using (FormGiris formGiris = new FormGiris())
            {
                this.Hide();
                formGiris.ShowDialog();
            }
            //Form Girişo Sayfasına Geçiş
        }

        private void registryPageButton_Click(object sender, EventArgs e)
        {
            using (FormKayitlar formKayitlar = new FormKayitlar())
            {
                this.Hide();
                formKayitlar.ShowDialog();
            }
            //Form Kayıtlar Sayfasına Geçiş
        }

        private void entranceDate_ValueChanged(object sender, EventArgs e)
        {
            entranceDatePicker.Format = DateTimePickerFormat.Custom;
            entranceDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            // Date Time Picker üzerinden Alınan Verinin Tarih ve Saat Formatına Çevrilmesi
        }

        private void lblCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void lblCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void pnlCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void pnlCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void picCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void picCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void lblKayitOlustur_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKayitOlustur);

        private void lblKayitOlustur_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKayitOlustur);

        private void picKayitOlustur_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKayitOlustur);

        private void picKayitOlustur_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKayitOlustur);

        private void pnlKayitOlustur_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKayitOlustur);

        private void pnlKayitOlustur_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKayitOlustur);

        private void pnlKayitlar_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKayitlar);

        private void pnlKayitlar_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKayitlar);

        private void lblKayitlar_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKayitlar);

        private void lblKayitlar_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKayitlar);

        private void picKayitlar_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKayitlar);

        private void picKayitlar_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKayitlar);

        private void FormManual_Load(object sender, EventArgs e)
        {
            entranceDatePicker.Format = DateTimePickerFormat.Custom;
            entranceDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void pnlKayitOlustur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e) => stripSaat.Text = $"{DateTime.Now:HH:mm}";
    }
}
