using System;

namespace OtoparkOtomasyonuEnSon
{
    public class ArabaDBObje
    {
        public string Plaka;
        public string TelefonNumarasi;
        public DateTime GirisSaati;
        public DateTime CikisSaati;
        public float Tutar;

        public ArabaDBObje(string plaka, string telefonNumarasi, DateTime girisSaati)
        {
            Plaka = plaka;
            TelefonNumarasi = telefonNumarasi;
            GirisSaati = girisSaati;
        }
    }
}
