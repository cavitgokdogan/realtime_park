using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace OtoparkOtomasyonuEnSon
{
    public class Dbo_arabalar
    {
        string plaka;
        string telefon_no;
        DateTime giris_saati;
        DateTime cikis_saati;
        float tutar;

        public Dbo_arabalar(string plaka, string telefon_no, DateTime giris_saati) {
            this.plaka = plaka;
            this.telefon_no = telefon_no;
            this.giris_saati = DateTime.Now;
            
        }


    }
}
