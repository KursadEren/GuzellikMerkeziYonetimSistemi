/****************************************************************************

** SAKARYA ÜNİVERSİTESİ

** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ

** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ

** NESNEYE DAYALI PROGRAMLAMA DERSİ

** 2023-2024 BAHAR DÖNEMİ

**

** ÖDEV NUMARASI proje 1

** ÖĞRENCİ ADI:Kürşad Eren MADEN

** ÖĞRENCİ NUMARASI G211210049

** DERSİN ALINDIĞI GRUP  1/B

****************************************************************************/
namespace GuzellikMerkeziYonetimSistemi
{
    public class Hizmet
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public double Ucret { get; set; }
        public string Icerik { get; set; }

        public Hizmet(int id, string ad, double ucret, string icerik)
        {
            ID = id;
            Ad = ad;
            Ucret = ucret;
            Icerik = icerik;
        }

        public override string ToString()
        {
            return $"{ID} - {Ad} - {Ucret} - {Icerik}";
        }
    }
}
