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

        private void createRegistryButton_Click(object sender, EventArgs e)
        {
            DateTime chosenTime = entranceDatePicker.Value;
            TimeSpan chosenTimeSpan = chosenTime.TimeOfDay;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string insertArabalar = "insert into dbo.arabalar (plaka, telefon_no,giris_saati) values (@p1,@p2,@p3)";
                    using (SqlCommand command = new SqlCommand(insertArabalar, connection))
                    {
                        command.Parameters.AddWithValue("@p1", numberPlateTextBox.Text);
                        command.Parameters.AddWithValue("@p2", telNoTextBox.Text);
                        command.Parameters.AddWithValue("@p3", chosenTime.Date.ToString("yyyy-MM-dd") + " " + chosenTimeSpan);
                        command.ExecuteNonQuery();
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
    }
}
