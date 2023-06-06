using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormKayitlar : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-UNTJT3U;Initial Catalog=otopark;Integrated Security=True";

        public FormKayitlar()
        {
            InitializeComponent();
            Text = "OtoOto";
        }

        SqlConnection connection = new SqlConnection(ConnectionString);
        //Server Bağlantısı

        private void manualFormButton_Click(object sender, EventArgs e)
        {
            FormManual formManuel = new FormManual();
            Hide();
            formManuel.ShowDialog();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            Hide();
            formGiris.ShowDialog();
        }

        private void loadRegistryForm(object sender, EventArgs e)
        {
            // DataGridView içerisine veri çekme
            arabalarTableAdapter1.Fill(this.otoparkDataSet4.arabalar);
            Timer_Tick(this, new EventArgs());
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) => stripSaat.Text = $"{DateTime.Now:HH:mm}";

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                arabalarTableAdapter.FillBy(otoparkDataSet.arabalar);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void carExitButton_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();  //Server Bağlantısı Açıldı

                DateTime giris_saati;

                SqlCommand command;
                command = new SqlCommand($"select giris_saati from arabalar where plaka = '{numberPlateTextBox.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                giris_saati = DateTime.Parse(reader[0].ToString());
                reader.Close();

                command = new SqlCommand("delete from arabalar where plaka = @selected", connection);  // Veritabanından veri silme komutu (Araç Çıkışı)
                command.Parameters.AddWithValue("@selected", numberPlateTextBox.Text);

                TimeSpan harcananVakit = DateTime.Now - giris_saati;
                int harcananSaat = harcananVakit.Minutes / 60;

                if (command.ExecuteNonQuery() > 0)   // sql sorgusu çalıştırıldı
                {
                    MessageBox.Show("Araç Çıkışı Yapıldı!");
                } 
                else
                {
                    MessageBox.Show("Şuanda bir araç seçmediniz. Çıkışını yapmak istediğiniz araca tıklayınız.");
                }

                arabalarTableAdapter1.Fill(otoparkDataSet4.arabalar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Kurulamadı!" + ex.Message);
            }  
            finally
            {
                connection.Close(); // Server Bağlantısı Kapandı
            }


        }


        private void manualRegistry_label_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlManuelGiris);

        private void manualRegistry_label_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlManuelGiris);

        private void manualRegistry_panel_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlManuelGiris);

        private void manualRegistry_panel_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlManuelGiris);

        private void manualRegistry_pictureBox1_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlManuelGiris);

        private void manualRegistry_pictureBox1_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlManuelGiris);

        private void pnlCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void pnlCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void lblCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void lblCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void picCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void picCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void pnlAracCikis_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlManuelDelete);

        private void pnlAracCikis_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlManuelDelete);

        private void lblManuelDelete_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlManuelDelete);

        private void lblManuelDelete_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlManuelDelete);

        private void picManuelDelete_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlManuelDelete);

        private void picManuelDelete_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlManuelDelete);

        private void registryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = registryGridView.SelectedCells[0].RowIndex;
            numberPlateTextBox.Text = registryGridView.Rows[secilen].Cells[0].Value.ToString();
            telNoTextBox.Text = registryGridView.Rows[secilen].Cells[1].Value.ToString();
            entranceDateTextBox.Text = registryGridView.Rows[secilen].Cells[2].Value.ToString();
        }

        private void tumKayitlar_Click(object sender, EventArgs e)
        {

            FormTumKayitlar formTumKayitlar = new FormTumKayitlar();
            Hide();
            formTumKayitlar.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCikisYap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTumKayitlar_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlTumKayitlar);

        private void panelTumKayitlar_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlTumKayitlar);

        private void picTumKayitlar_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlTumKayitlar);

        private void picTumKayitlar_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlTumKayitlar);

        private void lblTumKayitlar_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlTumKayitlar);

        private void lblTumKayitlar_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlTumKayitlar);

    }
}
