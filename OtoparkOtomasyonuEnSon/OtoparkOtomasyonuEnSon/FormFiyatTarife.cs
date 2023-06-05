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
    public partial class FormFiyatTarife : Form
    {
        
        private const string ConnectionString = "Data Source=DESKTOP-UNTJT3U;Initial Catalog=otopark;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnectionString);

        public FormFiyatTarife()
        {
            InitializeComponent();
            this.Text = "OtoOto";
        }

        public void goBackClick()
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void FormFiyatTarife_Load(object sender, EventArgs e)
        {
            yukle();
            Timer_Tick(this, new EventArgs());
            timer.Start();
        }

        private void yukle()
        {
            try
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM dbo.fiyatlar";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtBoxBirSaat.Text = reader[0].ToString();
                    txtBoxSaatlik.Text = reader[1].ToString();
                    txtBoxGunluk.Text = reader[2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantıda hata oluştu! " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void kaydet()
        {
            try
            {
                connection.Open();
                string sqlQuery = "DELETE FROM dbo.fiyatlar";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();

                sqlQuery = "INSERT INTO dbo.fiyatlar VALUES (" + txtBoxBirSaat.Text + "," + txtBoxSaatlik.Text + "," + txtBoxGunluk.Text + ")";
                command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Başarıyla Kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantıda hata oluştu! " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            yukle();
        }

        private void pnlKaydet_Click(object sender, EventArgs e) => kaydet();

        private void picKaydet_Click(object sender, EventArgs e) => kaydet();

        private void lblKaydet_Click(object sender, EventArgs e) => kaydet();

        private void pnlGeriDon_Click(object sender, EventArgs e) => goBackClick();

        private void lblGeriDon_Click(object sender, EventArgs e) => goBackClick();

        private void picGeriDon_Click(object sender, EventArgs e) => goBackClick();

        private void lblGeriDon_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlGeriDon);

        private void lblGeriDon_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlGeriDon);

        private void pnlGeriDon_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlGeriDon);

        private void pnlGeriDon_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlGeriDon);
 
        private void picGeriDon_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlGeriDon);

        private void picGeriDon_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlGeriDon);

        private void lblKaydet_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKaydet);

        private void lblKaydet_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKaydet);

        private void pnlKaydet_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKaydet);

        private void pnlKaydet_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKaydet);

        private void picKaydet_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlKaydet);

        private void picKaydet_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlKaydet);

        private void Timer_Tick(object sender, EventArgs e) => stripSaat.Text = $"{DateTime.Now:HH:mm}";
    }
}
