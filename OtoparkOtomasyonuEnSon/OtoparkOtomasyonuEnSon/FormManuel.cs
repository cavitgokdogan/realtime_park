using OtoparkOtomasyonuEnSon.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormManuel : Form
    {
        public FormManuel()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR;Initial Catalog=otopark;Integrated Security=True");
        //SqlClient sınıfından nesne oluşturuluyor



        private void FormManuel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime secilenZaman = dateTimePicker1.Value;
            TimeSpan secilenVakit = secilenZaman.TimeOfDay;
            try 
            {
                baglanti.Open(); 
            }
            catch(Exception) 
            {
                MessageBox.Show("Bağlantı Kurulamadı !");
            }
            

            string log = $"{secilenZaman.Date.ToString("yyyy-MM-dd")+" "+secilenVakit} Saatinde Otoparka {textBox1.Text} Tarafından Giriş Yapıldı";
            SqlCommand komut = new SqlCommand("insert into dbo.arabalar (plaka, telefon_no,giris_saati) values (@p1,@p2,@p3)",baglanti);
            
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", secilenZaman.Date.ToString("yyyy-MM-dd")+" "+secilenVakit);
            komut.ExecuteNonQuery();
            SqlCommand logkomut = new SqlCommand("insert into dbo.log (log) values (@k1)", baglanti);
            logkomut.Parameters.AddWithValue("@k1", log);
            logkomut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Oluşturuldu!");

            //TextBoxlara Girilen Verileirn Veritabanına Aktarılması


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
            //Form Giriş Sayfasına Geçiş
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKayitlar formKayitlar = new FormKayitlar();
            this.Hide();
            formKayitlar.ShowDialog();
            //Form Kayıtlar Sayfasına Geçiş
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            // Date Time Picker üzerinden Alınan Verinin Tarih ve Saat Formatına Çevrilmesi
        }
    }
}
