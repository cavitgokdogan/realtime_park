using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManualForm formManuel = new ManualForm();
            this.Hide();
            formManuel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void FormKayitlar_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.arabalarTableAdapter2.Fill(this.otoparkDataSet5.arabalar);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();  //Server Bağlantısı Açıldı
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Kurulamadı !");
            }  
            string log = $"Araç Çıkışı Yapıldı: {textBox1.Text}";

            SqlCommand komut = new SqlCommand("delete from arabalar where plaka = @selected", baglanti);  // Veritabanından veri silme komutu (Araç Çıkışı)
            SqlCommand logkomut = new SqlCommand("insert into dbo.log (log) values (@k1)", baglanti);     // Araç Çıkışı log kaydı
               
            komut.Parameters.AddWithValue("@selected",textBox1.Text);
            logkomut.Parameters.AddWithValue("@k1", log);
            komut.ExecuteNonQuery(); // sql sorgusu çalıştırıldı
            
            logkomut.ExecuteNonQuery(); // log tablosunda sql sorgusu çalıştırıldı
            baglanti.Close(); // Server Bağlantısı Kapandı
            MessageBox.Show("Araç Çıkışı Yapıldı!");

            //Araç Çıkışı İçin Yazılan Kodlar
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            //TextBoxları DataGridViewde tıklanılan kısma eşitliyoruz (verileri oradan silmek için)
        }

        private void numberPlateTextChanged(object sender, EventArgs e)
        {

        }

        private void telNoTextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
