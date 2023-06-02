using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormGiris : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-UNTJT3U;Initial Catalog=otopark;Integrated Security=True";

        public FormGiris()
        {
            InitializeComponent();
        }
        
        private void manualFormButton_Click(object sender, EventArgs e)
        {
            ManualForm ManualForm = new ManualForm();
            this.Hide();
            ManualForm.ShowDialog();
            //Manuel Giriş Sayfasına Geçiş
        }

        private void automaticEntranceButton_Click(object sender, EventArgs e)
        {
            // Start a new process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    // Replace with your python script path
                    Arguments = "..\\..\\..\\..\\plaka_tanima\\cam_plaka.py",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
                }
            };
            process.Start();

            // Read the python script output
            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    // Store the detected text
                    string detectedText = line;
                    MessageBox.Show(detectedText + " plakalı cihaz kaydedildi");
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            connection.Open();
                            string insertArabalar = "insert into dbo.arabalar (plaka, telefon_no,giris_saati) values (@p1,@p2,@p3)";
                            using (SqlCommand command = new SqlCommand(insertArabalar, connection))
                            {
                                command.Parameters.AddWithValue("@p1", detectedText);
                                command.Parameters.AddWithValue("@p2", "-");
                                command.Parameters.AddWithValue("@p3", DateTime.Now);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bağlantı Kurulamadı !\n" + ex.Message);
                    }
                }
            }
        }

        private void registriesButton_Click(object sender, EventArgs e)
        {
            FormKayitlar formKayitlar = new FormKayitlar();
            this.Hide();
            formKayitlar.ShowDialog();
            //Kayıtlar Sayfasına Geçiş
        }


        private void loginPageButton_Click(object sender, EventArgs e)
        {
            FormGirisYap form1 = new FormGirisYap();
            this.Hide();
            form1.ShowDialog();
        }
        private void automaticExitButton_Click(object sender, EventArgs e)
        {
            // Start a new process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    // Replace with your python script path
                    Arguments = "..\\..\\..\\..\\plaka_tanima\\cam_plaka.py",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
                }
            };
            process.Start();

            // Read the python script output
            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    string detectedText = line;
                    MessageBox.Show(detectedText);
                    
                }
            }
        }

        private void costManagerButton_Click(object sender, EventArgs e)
        {
            FiyatTarifeForm fiyatTarifeForm = new FiyatTarifeForm();
            this.Hide();
            fiyatTarifeForm.ShowDialog();
        }
    }
}
