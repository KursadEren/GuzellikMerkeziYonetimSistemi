
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
    public class Calisan
    {
        public int ID { get; set; }
        public string TCNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }

        public Calisan(int id, string tcNo, string ad, string soyad, string pozisyon)
        {
            ID = id;
            TCNo = tcNo;
            Ad = ad;
            Soyad = soyad;
            Pozisyon = pozisyon;
        }

        public override string ToString()
        {
            return $"{ID} - {TCNo} - {Ad} - {Soyad} - {Pozisyon}";
        }
    }
}
