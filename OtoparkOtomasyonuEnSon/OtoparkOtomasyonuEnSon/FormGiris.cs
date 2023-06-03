/*
 *          Ferit Yiğit BALABAN - 032190002
 */

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

        private void FormGiris_Load(object sender, EventArgs e)
        {
            Timer_Tick(this, EventArgs.Empty);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            stripSaat.Text = $"{DateTime.Now:HH:mm}";
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

        #region Otomatik Giriş Özelliği
        private void OtomatikGiris()
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

        private void PnlOtomatikGiris_Click(object sender, EventArgs e) => OtomatikGiris();

        private void LblOtomatikGiris_Click(object sender, EventArgs e) => OtomatikGiris();

        private void PicOtomatikGiris_Click(object sender, EventArgs e) => OtomatikGiris();
        #endregion

        #region Otomatik Çıkış Özelliği
        private void OtomatikCikis()
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

        private void PnlOtomatikCikis_Click(object sender, EventArgs e) => OtomatikCikis();

        private void LblOtomatikCikis_Click(object sender, EventArgs e) => OtomatikCikis();

        private void PicOtomatikCikis_Click(object sender, EventArgs e) => OtomatikCikis();
        #endregion

        #region Manuel Giriş Özelliği
        private void FormManualAc()
        {
            Hide();
            FormManual form = new FormManual();
            form.ShowDialog();
        }

        private void PnlManuelGiris_Click(object sender, EventArgs e) => FormManualAc();

        private void LblManuelGiris_Click(object sender, EventArgs e) => FormManualAc();

        private void PicManuelGiris_Click(object sender, EventArgs e) => FormManualAc();
        #endregion

        #region FormKayitlar Formuna Geçiş
        private void FormKayitlarAc()
        {
            Hide();
            FormKayitlar form = new FormKayitlar();
            form.ShowDialog();
        }

        private void PnlKayitlar_Click(object sender, EventArgs e) => FormKayitlarAc();

        private void LblKayitlar_Click(object sender, EventArgs e) => FormKayitlarAc();

        private void PicKayitlar_Click(object sender, EventArgs e) => FormKayitlarAc();
        #endregion

        #region Eyecandy Sağlayan Metotlar ve Olaylar
        private void HoverOldu(Control kontrol) => kontrol.BackColor = Color.FromArgb(63, 28, 158);

        private void HoverBitti(Control kontrol) => kontrol.BackColor = Color.FromArgb(74, 33, 184);

        private void PanCikisYap_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlCikisYap);

        private void PanCikisYap_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlCikisYap);

        private void LblCikisYap_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlCikisYap);

        private void LblCikisYap_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlCikisYap);

        private void PicCikisYap_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlCikisYap);

        private void PicCikisYap_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlCikisYap);

        private void LblFiyatTarifesi_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlFiyatTarifesi);

        private void LblFiyatTarifesi_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlFiyatTarifesi);

        private void PicFiyatTarifesi_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlFiyatTarifesi);

        private void PicFiyatTarifesi_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlFiyatTarifesi);

        private void PnlFiyatTarifesi_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlFiyatTarifesi);

        private void PnlFiyatTarifesi_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlFiyatTarifesi);

        private void PnlOtomatikGiris_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlOtomatikGiris);

        private void PnlOtomatikGiris_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlOtomatikGiris);

        private void LblOtomatikGiris_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlOtomatikGiris);

        private void LblOtomatikGiris_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlOtomatikGiris);

        private void PicOtomatikGiris_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlOtomatikGiris);

        private void PicOtomatikGiris_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlOtomatikGiris);

        private void PnlOtomatikCikis_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlOtomatikCikis);

        private void PnlOtomatikCikis_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlOtomatikCikis);

        private void LblOtomatikCikis_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlOtomatikCikis);

        private void LblOtomatikCikis_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlOtomatikCikis);

        private void PicOtomatikCikis_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlOtomatikCikis);

        private void PicOtomatikCikis_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlOtomatikCikis);

        private void PnlManuelGiris_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlManuelGiris);

        private void PnlManuelGiris_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlManuelGiris);

        private void LblManuelGiris_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlManuelGiris);

        private void LblManuelGiris_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlManuelGiris);

        private void PicManuelGiris_MouseEnter(object sender, EventArgs e) => HoverOldu(pnlManuelGiris);

        private void PicManuelGiris_MouseLeave(object sender, EventArgs e) => HoverBitti(pnlManuelGiris);
        #endregion
    }
}