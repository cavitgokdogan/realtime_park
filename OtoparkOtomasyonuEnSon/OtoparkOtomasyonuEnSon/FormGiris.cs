using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;

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
            FormFiyatTarife fiyatTarifeForm = new FormFiyatTarife();
            this.Hide();
            fiyatTarifeForm.ShowDialog();
        }

        #region Çıkışla Alakalı Metot ve Olaylar
        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e) => Program.mainForm.Show();

        private void LblCikisYap_Click(object sender, EventArgs e) => Close();

        private void PicCikisYap_Click(object sender, EventArgs e) => Close();

        private void PanCikisYap_Click(object sender, EventArgs e) => Close();
        #endregion

        #region FormFiyatTarife Formuna Geçiş
        private void FormFiyatTarifeAc()
        {
            Hide();
            FormFiyatTarife form = new FormFiyatTarife();
            form.ShowDialog();
        }

        private void PicFiyatTarifesi_Click(object sender, EventArgs e) => FormFiyatTarifeAc();

        private void LblFiyatTarifesi_Click(object sender, EventArgs e) => FormFiyatTarifeAc();

        private void PnlFiyatTarifesi_Click(object sender, EventArgs e) => FormFiyatTarifeAc();
        #endregion

        #region Eyecandy Sağlayan Metotlar ve Olaylar
        private void HoverOldu(Control kontrol) => kontrol.BackColor = Color.FromArgb(63, 28, 158);

        private void HoverBitti(Control kontrol) => kontrol.BackColor = Color.FromArgb(74, 33, 184);

        private void PanCikisYap_MouseEnter(object sender, EventArgs e) => HoverOldu(panCikisYap);

        private void PanCikisYap_MouseLeave(object sender, EventArgs e) => HoverBitti(panCikisYap);

        private void LblFiyatTarifesi_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlFiyatTarifesi);

        private void LblFiyatTarifesi_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlFiyatTarifesi);

        private void PicFiyatTarifesi_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlFiyatTarifesi);

        private void PicFiyatTarifesi_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlFiyatTarifesi);

        private void PnlFiyatTarifesi_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlFiyatTarifesi);

        private void PnlFiyatTarifesi_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlFiyatTarifesi);
        #endregion
    }
}
