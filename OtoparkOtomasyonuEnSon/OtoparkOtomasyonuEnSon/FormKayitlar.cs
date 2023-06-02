using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormKayitlar : Form
    {

        public FormKayitlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UNTJT3U;Initial Catalog=otopark;Integrated Security=True");
        //Server Bağlantısı

        private void manualFormButton_Click(object sender, EventArgs e)
        {
            ManualForm formManuel = new ManualForm();
            this.Hide();
            formManuel.ShowDialog();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void loadRegistryForm(object sender, EventArgs e)
        {
            // DataGridView içerisine veri çekme
            this.arabalarTableAdapter2.Fill(this.otoparkDataSet5.arabalar);
  

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.arabalarTableAdapter.FillBy(this.otoparkDataSet.arabalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
             
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.arabalarTableAdapter2.Fill(this.otoparkDataSet5.arabalar);

        }

        private void carExitButton_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();  //Server Bağlantısı Açıldı
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Kurulamadı !");
            }  
            string log = $"Araç Çıkışı Yapıldı: {numberPlateTextBox.Text}";

            SqlCommand komut = new SqlCommand("delete from arabalar where plaka = @selected", baglanti);  // Veritabanından veri silme komutu (Araç Çıkışı)
            SqlCommand logkomut = new SqlCommand("insert into dbo.log (log) values (@k1)", baglanti);     // Araç Çıkışı log kaydı
               
            komut.Parameters.AddWithValue("@selected",numberPlateTextBox.Text);
            logkomut.Parameters.AddWithValue("@k1", log);
            komut.ExecuteNonQuery(); // sql sorgusu çalıştırıldı
            
            logkomut.ExecuteNonQuery(); // log tablosunda sql sorgusu çalıştırıldı
            baglanti.Close(); // Server Bağlantısı Kapandı
            MessageBox.Show("Araç Çıkışı Yapıldı!");

            //Araç Çıkışı İçin Yazılan Kodlar
        }

        private void registryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = registryGridView.SelectedCells[0].RowIndex;
            numberPlateTextBox.Text = registryGridView.Rows[secilen].Cells[0].Value.ToString();
            telNoTextBox.Text = registryGridView.Rows[secilen].Cells[1].Value.ToString();
            entranceDateTextBox.Text = registryGridView.Rows[secilen].Cells[2].Value.ToString();
            //TextBoxları DataGridViewde tıklanılan kısma eşitliyoruz (verileri oradan silmek için)
        }
    }
}
