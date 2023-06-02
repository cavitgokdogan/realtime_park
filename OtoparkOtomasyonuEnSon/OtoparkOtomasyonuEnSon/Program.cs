using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    internal static class Program
    {
        internal static FormGirisYap mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var splash = new FormSplash(5000);
            mainForm = new FormGirisYap();
#if !DEBUG
            splash.ShowDialog();
#endif
            Application.Run(mainForm);
        }
    }
}