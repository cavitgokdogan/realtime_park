using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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

        private  void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
