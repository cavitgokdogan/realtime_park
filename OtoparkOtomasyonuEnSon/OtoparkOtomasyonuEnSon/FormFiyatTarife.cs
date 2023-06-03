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
    public partial class FormFiyatTarife : Form
    {
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
    }
}
