using System;
using System.Collections.Generic;
using System.IO;

namespace GuzellikMerkeziYonetimSistemi
{
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
    public static class Veritabani
    {
        public static List<Musteri> Musteriler { get; set; } = new List<Musteri>();
        public static List<Calisan> Calisanlar { get; set; } = new List<Calisan>();
        public static List<Hizmet> Hizmetler { get; set; } = new List<Hizmet>();
        public static List<Randevu> Randevular { get; set; } = new List<Randevu>();

        private static string MusteriDosyaYolu = "musteriler.txt";
        private static string CalisanDosyaYolu = "calisanlar.txt";
        private static string HizmetDosyaYolu = "hizmetler.txt";
        private static string RandevuDosyaYolu = "randevular.txt";

        public static void MusteriEkle(Musteri musteri)
        {
            int maxID = Musteriler.Count > 0 ? Musteriler[Musteriler.Count - 1].ID : 0;
            musteri.ID = maxID + 1;
            Musteriler.Add(musteri);
            DosyayaYaz(MusteriDosyaYolu, Musteriler);
        }

        public static void CalisanEkle(Calisan calisan)
        {
            int maxID = Calisanlar.Count > 0 ? Calisanlar[Calisanlar.Count - 1].ID : 0;
            calisan.ID = maxID + 1;
            Calisanlar.Add(calisan);
            DosyayaYaz(CalisanDosyaYolu, Calisanlar);
        }

        public static void HizmetEkle(Hizmet hizmet)
        {
            int maxID = Hizmetler.Count > 0 ? Hizmetler[Hizmetler.Count - 1].ID : 0;
            hizmet.ID = maxID + 1;
            Hizmetler.Add(hizmet);
            DosyayaYaz(HizmetDosyaYolu, Hizmetler);
        }

        public static void RandevuEkle(Randevu randevu)
        {
            if (!Randevular.Exists(r => r.Tarih == randevu.Tarih &&
                                        ((r.Saat <= randevu.Saat && r.Saat.Add(new TimeSpan(0, 30, 0)) > randevu.Saat) ||
                                         (randevu.Saat <= r.Saat && randevu.Saat.Add(new TimeSpan(0, 30, 0)) > r.Saat))))
            {
                int maxID = Randevular.Count > 0 ? Randevular[Randevular.Count - 1].ID : 0;
                randevu.ID = maxID + 1;
                Randevular.Add(randevu);
                DosyayaYaz(RandevuDosyaYolu, Randevular, r => r.ToFileString());
            }
            else
            {
                throw new InvalidOperationException("Bu saat aralığında başka bir randevu bulunmaktadır.");
            }
        }

        public static void MusteriSil(Musteri musteri)
        {
            Musteriler.Remove(musteri);
            DosyayaYaz(MusteriDosyaYolu, Musteriler);
        }

        public static void CalisanSil(Calisan calisan)
        {
            Calisanlar.Remove(calisan);
            DosyayaYaz(CalisanDosyaYolu, Calisanlar);
        }

        public static void HizmetSil(Hizmet hizmet)
        {
            Hizmetler.Remove(hizmet);
            DosyayaYaz(HizmetDosyaYolu, Hizmetler);
        }

        public static void RandevuSil(Randevu randevu)
        {
            Randevular.Remove(randevu);
            DosyayaYaz(RandevuDosyaYolu, Randevular, r => r.ToFileString());
        }

        public static void MusteriGuncelle(Musteri musteri)
        {
            var eskiMusteri = Musteriler.Find(m => m.ID == musteri.ID);
            if (eskiMusteri != null)
            {
                eskiMusteri.Ad = musteri.Ad;
                eskiMusteri.Soyad = musteri.Soyad;
                eskiMusteri.Telefon = musteri.Telefon;
                eskiMusteri.Email = musteri.Email;
                eskiMusteri.TCNo = musteri.TCNo;
                DosyayaYaz(MusteriDosyaYolu, Musteriler);
            }
        }

        public static void CalisanGuncelle(Calisan calisan)
        {
            var eskiCalisan = Calisanlar.Find(c => c.ID == calisan.ID);
            if (eskiCalisan != null)
            {
                eskiCalisan.Ad = calisan.Ad;
                eskiCalisan.Soyad = calisan.Soyad;
                eskiCalisan.Pozisyon = calisan.Pozisyon;
                eskiCalisan.TCNo = calisan.TCNo;
                DosyayaYaz(CalisanDosyaYolu, Calisanlar);
            }
        }

        public static void HizmetGuncelle(Hizmet hizmet)
        {
            var eskiHizmet = Hizmetler.Find(h => h.ID == hizmet.ID);
            if (eskiHizmet != null)
            {
                eskiHizmet.Ad = hizmet.Ad;
                eskiHizmet.Ucret = hizmet.Ucret;
                eskiHizmet.Icerik = hizmet.Icerik;
                DosyayaYaz(HizmetDosyaYolu, Hizmetler);
            }
        }

        public static void RandevuGuncelle(Randevu randevu)
        {
            var eskiRandevu = Randevular.Find(r => r.ID == randevu.ID);
            if (eskiRandevu != null)
            {
                eskiRandevu.MusteriID = randevu.MusteriID;
                eskiRandevu.CalisanID = randevu.CalisanID;
                eskiRandevu.HizmetID = randevu.HizmetID;
                eskiRandevu.Tarih = randevu.Tarih;
                eskiRandevu.Saat = randevu.Saat;
                DosyayaYaz(RandevuDosyaYolu, Randevular, r => r.ToFileString());
            }
        }

        public static void DosyayaYaz<T>(string dosyaYolu, List<T> liste, Func<T, string> toFileString = null)
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (var item in liste)
                {
                    sw.WriteLine(toFileString != null ? toFileString(item) : item.ToString());
                }
            }
        }

        public static List<Musteri> MusterileriOku()
        {
            return DosyadanOku<Musteri>(MusteriDosyaYolu);
        }

        public static List<Calisan> CalisanlariOku()
        {
            return DosyadanOku<Calisan>(CalisanDosyaYolu);
        }

        public static List<Hizmet> HizmetleriOku()
        {
            return DosyadanOku<Hizmet>(HizmetDosyaYolu);
        }

        public static List<Randevu> RandevulariOku()
        {
            return DosyadanOku<Randevu>(RandevuDosyaYolu);
        }

        public static List<T> DosyadanOku<T>(string dosyaYolu)
        {
            List<T> liste = new List<T>();

            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        try
                        {
                            if (typeof(T) == typeof(Musteri))
                            {
                                var veriler = satir.Split('-');
                                if (veriler.Length == 6)
                                {
                                    var musteri = new Musteri(int.Parse(veriler[0].Trim()), veriler[1].Trim(), veriler[2].Trim(), veriler[3].Trim(), veriler[4].Trim(), veriler[5].Trim());
                                    liste.Add((T)(object)musteri);
                                }
                            }
                            else if (typeof(T) == typeof(Calisan))
                            {
                                var veriler = satir.Split('-');
                                if (veriler.Length == 5)
                                {
                                    var calisan = new Calisan(int.Parse(veriler[0].Trim()), veriler[1].Trim(), veriler[2].Trim(), veriler[3].Trim(), veriler[4].Trim());
                                    liste.Add((T)(object)calisan);
                                }
                            }
                            else if (typeof(T) == typeof(Hizmet))
                            {
                                var veriler = satir.Split('-');
                                if (veriler.Length == 4)
                                {
                                    var hizmet = new Hizmet(int.Parse(veriler[0].Trim()), veriler[1].Trim(), double.Parse(veriler[2].Trim()), veriler[3].Trim());
                                    liste.Add((T)(object)hizmet);
                                }
                            }
                            else if (typeof(T) == typeof(Randevu))
                            {
                                var veriler = satir.Split('-');
                                if (veriler.Length == 6)
                                {
                                    var randevu = new Randevu(int.Parse(veriler[0].Trim()), int.Parse(veriler[1].Trim()), int.Parse(veriler[2].Trim()), int.Parse(veriler[3].Trim()), DateTime.Parse(veriler[4].Trim()), TimeSpan.Parse(veriler[5].Trim()));
                                    liste.Add((T)(object)randevu);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hata oluşursa buraya loglama yapılabilir
                            Console.WriteLine($"Hata: {ex.Message}");
                        }
                    }
                }
            }
            return liste;
        }
    }
}
