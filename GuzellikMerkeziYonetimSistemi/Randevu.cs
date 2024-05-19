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
using GuzellikMerkeziYonetimSistemi;
using System;

public class Randevu
{
    public int ID { get; set; }
    public int MusteriID { get; set; }
    public int CalisanID { get; set; }
    public int HizmetID { get; set; }
    public DateTime Tarih { get; set; }
    public TimeSpan Saat { get; set; }

    public Randevu(int id, int musteriID, int calisanID, int hizmetID, DateTime tarih, TimeSpan saat)
    {
        ID = id;
        MusteriID = musteriID;
        CalisanID = calisanID;
        HizmetID = hizmetID;
        Tarih = tarih;
        Saat = saat;
    }

    public override string ToString()
    {
        var musteri = Veritabani.Musteriler.Find(m => m.ID == MusteriID);
        var calisan = Veritabani.Calisanlar.Find(c => c.ID == CalisanID);
        var hizmet = Veritabani.Hizmetler.Find(h => h.ID == HizmetID);

        return $"{musteri.Ad} {musteri.Soyad} - {calisan.Ad} {calisan.Soyad} - {hizmet.Ad} - {Tarih.ToShortDateString()} {Saat:hh\\:mm}";
    }

    public string ToFileString()
    {
        return $"{ID} - {MusteriID} - {CalisanID} - {HizmetID} - {Tarih.ToShortDateString()} - {Saat:hh\\:mm}";
    }
}
