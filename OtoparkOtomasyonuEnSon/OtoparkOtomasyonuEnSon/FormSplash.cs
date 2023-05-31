using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormSplash : Form
    {
        /// <summary>
        /// Splash penceresini başlatır.
        /// </summary>
        /// <param name="timeout">Milisaniye cinsinden, splash penceresinin kaç saniye açık kalacağını belirler.</param>
        public FormSplash(int timeout)
        {
            InitializeComponent();
            splashTimer.Interval = timeout;
            splashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();
            // Bu pencereyi kapat
            Close();
        }
    }
}
