using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManuel formManuel = new FormManuel();
            this.Hide();
            formManuel.ShowDialog();
            //Manuel Giriş Sayfasına Geçiş
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string komut = "cd C:\\Users\\kosee\\anaconda3\\envs\\plaka_tanima python cam_plaka.py";
            try
            {
                Process.Start("cmd.exe", "/c" + "cd C:\\Users\\kosee\\anaconda3\\envs\\plaka_tanima &python cam_plaka.py");

            }
            catch (Exception) 
            {
                MessageBox.Show("Tekrar Deneyiniz !");
            }

           // Plaka Okuma Programını CMD üzerinden çalıştırıyoruz


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKayitlar formKayitlar = new FormKayitlar();
            this.Hide();
            formKayitlar.ShowDialog();
            //Kayıtlar Sayfasına Geçiş
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLoglar formloglar = new FormLoglar();
            this.Hide();
            formloglar.ShowDialog();
            //Loglar Sayfasına Geçiş


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGirisYap form1 = new FormGirisYap();
            this.Hide();
            form1.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string komut = "cd C:\\Users\\kosee\\anaconda3\\envs\\plaka_tanima python cam_plaka.py";
            try
            {
                Process.Start("cmd.exe", "/c" + "cd C:\\Users\\kosee\\anaconda3\\envs\\plaka_tanima &python cam_plaka.py");

            }
            catch (Exception)
            {
                MessageBox.Show("Tekrar Deneyiniz !");
            }

            // Plaka Okuma Programını CMD üzerinden çalıştırıyoruz
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FiyatTarifeForm fiyatTarifeForm = new FiyatTarifeForm();
            this.Hide();
            fiyatTarifeForm.ShowDialog();
        }
    }
}
