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
        }

        public void AnaMenuButtonClick(object sender,EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void FormFiyatTarife_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM dbo.fiyatlar";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    label1.Text = reader[0].ToString() + " TL";
                    label2.Text = reader[1].ToString() + " TL";
                    label3.Text = reader[2].ToString() + " TL";
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
    }
}
