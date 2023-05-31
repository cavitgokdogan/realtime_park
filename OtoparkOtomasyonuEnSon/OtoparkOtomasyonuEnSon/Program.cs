using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var splash = new FormSplash(5000);
            var mainForm = new Form1();
            splash.ShowDialog();
            Application.Run(mainForm);
        }
    }
}