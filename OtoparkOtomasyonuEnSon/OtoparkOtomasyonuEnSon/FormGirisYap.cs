using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormGirisYap : Form
    {
        public FormGirisYap()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    FormGiris formGiris = new FormGiris();
                    this.Hide();
                    formGiris.Show();

                }
                
                if(textBox1.Text == "kullanıcı" && textBox2.Text == "kullanıcı")
                {
                    FormNoAdmin formNoAdmin = new FormNoAdmin();
                    this.Hide();
                    formNoAdmin.ShowDialog();
                }
                
            }
            catch (Exception) 
                {
                    MessageBox.Show("Hatalı Bilgi Girdiniz!");
                }
        }
    }
}