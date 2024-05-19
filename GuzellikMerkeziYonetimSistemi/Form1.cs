using System;
using System.Linq;
using System.Windows.Forms;

namespace GuzellikMerkeziYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Veritabani.Musteriler = Veritabani.MusterileriOku();
            Veritabani.Calisanlar = Veritabani.CalisanlariOku();
            Veritabani.Hizmetler = Veritabani.HizmetleriOku();
            Veritabani.Randevular = Veritabani.RandevulariOku();

            ListeleMusteriler();
            ListeleCalisanlar();
            ListeleHizmetler();
            ListeleRandevular();

            cmbMusteri.DataSource = Veritabani.Musteriler;
            cmbMusteri.DisplayMember = "Ad";

            cmbCalisan.DataSource = Veritabani.Calisanlar;
            cmbCalisan.DisplayMember = "Ad";

            cmbHizmet.DataSource = Veritabani.Hizmetler;
            cmbHizmet.DisplayMember = "Ad";
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTCNo.Text))
            {
                MessageBox.Show("Lütfen tüm müşteri bilgilerini doldurun.");
                return;
            }

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;
            string tcNo = txtTCNo.Text;

            if (Veritabani.Musteriler.Exists(m => m.TCNo == tcNo))
            {
                MessageBox.Show("Bu TC kimlik numarasına sahip bir müşteri zaten var.");
                return;
            }

            Musteri yeniMusteri = new Musteri(0, tcNo, ad, soyad, telefon, email);
            Veritabani.MusteriEkle(yeniMusteri);

            MessageBox.Show("Müşteri başarıyla eklendi.");
            ListeleMusteriler();
            cmbMusteri.DataSource = null;
            cmbMusteri.DataSource = Veritabani.Musteriler;
            cmbMusteri.DisplayMember = "Ad";

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtTCNo.Clear();
        }

        private void btnMusteriSil_Click_1(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi seçin.");
                return;
            }

            Musteri secilenMusteri = (Musteri)lstMusteriler.SelectedItem;
            Veritabani.MusteriSil(secilenMusteri);

            MessageBox.Show("Müşteri başarıyla silindi.");
            ListeleMusteriler();
            cmbMusteri.DataSource = null;
            cmbMusteri.DataSource = Veritabani.Musteriler;
            cmbMusteri.DisplayMember = "Ad";
        }

        private void btnMusteriGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTCNo.Text))
            {
                MessageBox.Show("Lütfen tüm müşteri bilgilerini doldurun.");
                return;
            }

            Musteri secilenMusteri = (Musteri)lstMusteriler.SelectedItem;
            secilenMusteri.Ad = txtAd.Text;
            secilenMusteri.Soyad = txtSoyad.Text;
            secilenMusteri.Telefon = txtTelefon.Text;
            secilenMusteri.Email = txtEmail.Text;
            secilenMusteri.TCNo = txtTCNo.Text;

            Veritabani.MusteriGuncelle(secilenMusteri);

            MessageBox.Show("Müşteri başarıyla güncellendi.");
            ListeleMusteriler();
            cmbMusteri.DataSource = null;
            cmbMusteri.DataSource = Veritabani.Musteriler;
            cmbMusteri.DisplayMember = "Ad";

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtTCNo.Clear();
        }

        private void ListeleMusteriler()
        {
            lstMusteriler.Items.Clear();
            foreach (var musteri in Veritabani.Musteriler)
            {
                lstMusteriler.Items.Add(musteri);
            }
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCalisanAd.Text) || string.IsNullOrWhiteSpace(txtCalisanSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtPozisyon.Text) || string.IsNullOrWhiteSpace(txtCalisanTCNo.Text))
            {
                MessageBox.Show("Lütfen tüm çalışan bilgilerini doldurun.");
                return;
            }

            string ad = txtCalisanAd.Text;
            string soyad = txtCalisanSoyad.Text;
            string pozisyon = txtPozisyon.Text;
            string tcNo = txtCalisanTCNo.Text;

            if (Veritabani.Calisanlar.Exists(c => c.TCNo == tcNo))
            {
                MessageBox.Show("Bu TC kimlik numarasına sahip bir çalışan zaten var.");
                return;
            }

            Calisan yeniCalisan = new Calisan(0, tcNo, ad, soyad, pozisyon);
            Veritabani.CalisanEkle(yeniCalisan);

            MessageBox.Show("Çalışan başarıyla eklendi.");
            ListeleCalisanlar();
            cmbCalisan.DataSource = null;
            cmbCalisan.DataSource = Veritabani.Calisanlar;
            cmbCalisan.DisplayMember = "Ad";

            txtCalisanAd.Clear();
            txtCalisanSoyad.Clear();
            txtPozisyon.Clear();
            txtCalisanTCNo.Clear();
        }

        private void btnCalisanSil_Click_1(object sender, EventArgs e)
        {
            if (lstCalisanlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek çalışanı seçin.");
                return;
            }

            Calisan secilenCalisan = (Calisan)lstCalisanlar.SelectedItem;
            Veritabani.CalisanSil(secilenCalisan);

            MessageBox.Show("Çalışan başarıyla silindi.");
            ListeleCalisanlar();
            cmbCalisan.DataSource = null;
            cmbCalisan.DataSource = Veritabani.Calisanlar;
            cmbCalisan.DisplayMember = "Ad";
        }

        private void btnCalisanGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstCalisanlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek çalışanı seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCalisanAd.Text) || string.IsNullOrWhiteSpace(txtCalisanSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtPozisyon.Text) || string.IsNullOrWhiteSpace(txtCalisanTCNo.Text))
            {
                MessageBox.Show("Lütfen tüm çalışan bilgilerini doldurun.");
                return;
            }

            Calisan secilenCalisan = (Calisan)lstCalisanlar.SelectedItem;
            secilenCalisan.Ad = txtCalisanAd.Text;
            secilenCalisan.Soyad = txtCalisanSoyad.Text;
            secilenCalisan.Pozisyon = txtPozisyon.Text;
            secilenCalisan.TCNo = txtCalisanTCNo.Text;

            Veritabani.CalisanGuncelle(secilenCalisan);

            MessageBox.Show("Çalışan başarıyla güncellendi.");
            ListeleCalisanlar();
            cmbCalisan.DataSource = null;
            cmbCalisan.DataSource = Veritabani.Calisanlar;
            cmbCalisan.DisplayMember = "Ad";

            txtCalisanAd.Clear();
            txtCalisanSoyad.Clear();
            txtPozisyon.Clear();
            txtCalisanTCNo.Clear();
        }

        private void ListeleCalisanlar()
        {
            lstCalisanlar.Items.Clear();
            foreach (var calisan in Veritabani.Calisanlar)
            {
                lstCalisanlar.Items.Add(calisan);
            }
        }

        private void btnHizmetEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHizmetAd.Text) || string.IsNullOrWhiteSpace(txtUcret.Text) ||
                string.IsNullOrWhiteSpace(txtIcerik.Text))
            {
                MessageBox.Show("Lütfen tüm hizmet bilgilerini doldurun.");
                return;
            }

            string ad = txtHizmetAd.Text;
            if (!double.TryParse(txtUcret.Text, out double ucret))
            {
                MessageBox.Show("Lütfen geçerli bir ücret girin.");
                return;
            }
            string icerik = txtIcerik.Text;

            Hizmet yeniHizmet = new Hizmet(0, ad, ucret, icerik);
            Veritabani.HizmetEkle(yeniHizmet);

            MessageBox.Show("Hizmet başarıyla eklendi.");
            ListeleHizmetler();
            cmbHizmet.DataSource = null;
            cmbHizmet.DataSource = Veritabani.Hizmetler;
            cmbHizmet.DisplayMember = "Ad";

            txtHizmetAd.Clear();
            txtUcret.Clear();
            txtIcerik.Clear();
        }

        private void btnHizmetSil_Click_1(object sender, EventArgs e)
        {
            if (lstHizmetler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek hizmeti seçin.");
                return;
            }

            Hizmet secilenHizmet = (Hizmet)lstHizmetler.SelectedItem;
            Veritabani.HizmetSil(secilenHizmet);

            MessageBox.Show("Hizmet başarıyla silindi.");
            ListeleHizmetler();
            cmbHizmet.DataSource = null;
            cmbHizmet.DataSource = Veritabani.Hizmetler;
            cmbHizmet.DisplayMember = "Ad";
        }

        private void btnHizmetGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstHizmetler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek hizmeti seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHizmetAd.Text) || string.IsNullOrWhiteSpace(txtUcret.Text) ||
                string.IsNullOrWhiteSpace(txtIcerik.Text))
            {
                MessageBox.Show("Lütfen tüm hizmet bilgilerini doldurun.");
                return;
            }

            Hizmet secilenHizmet = (Hizmet)lstHizmetler.SelectedItem;
            secilenHizmet.Ad = txtHizmetAd.Text;
            secilenHizmet.Ucret = double.Parse(txtUcret.Text);
            secilenHizmet.Icerik = txtIcerik.Text;

            Veritabani.HizmetGuncelle(secilenHizmet);

            MessageBox.Show("Hizmet başarıyla güncellendi.");
            ListeleHizmetler();
            cmbHizmet.DataSource = null;
            cmbHizmet.DataSource = Veritabani.Hizmetler;
            cmbHizmet.DisplayMember = "Ad";

            txtHizmetAd.Clear();
            txtUcret.Clear();
            txtIcerik.Clear();
        }

        private void ListeleHizmetler()
        {
            lstHizmetler.Items.Clear();
            foreach (var hizmet in Veritabani.Hizmetler)
            {
                lstHizmetler.Items.Add(hizmet);
            }
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem == null || cmbCalisan.SelectedItem == null || cmbHizmet.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm randevu bilgilerini seçin.");
                return;
            }

            Musteri secilenMusteri = (Musteri)cmbMusteri.SelectedItem;
            Calisan secilenCalisan = (Calisan)cmbCalisan.SelectedItem;
            Hizmet secilenHizmet = (Hizmet)cmbHizmet.SelectedItem;
            DateTime tarih = dtpTarih.Value;
            TimeSpan saat = dtpSaat.Value.TimeOfDay;

            try
            {
                Randevu yeniRandevu = new Randevu(0, secilenMusteri.ID, secilenCalisan.ID, secilenHizmet.ID, tarih, saat);
                Veritabani.RandevuEkle(yeniRandevu);

                MessageBox.Show("Randevu başarıyla eklendi.");
                ListeleRandevular();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRandevuSil_Click_1(object sender, EventArgs e)
        {
            if (lstRandevular.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek randevuyu seçin.");
                return;
            }

            Randevu secilenRandevu = (Randevu)lstRandevular.SelectedItem;
            Veritabani.RandevuSil(secilenRandevu);

            MessageBox.Show("Randevu başarıyla silindi.");
            ListeleRandevular();
        }

        private void btnRandevuGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstRandevular.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek randevuyu seçin.");
                return;
            }

            if (cmbMusteri.SelectedItem == null || cmbCalisan.SelectedItem == null || cmbHizmet.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm randevu bilgilerini seçin.");
                return;
            }

            Randevu secilenRandevu = (Randevu)lstRandevular.SelectedItem;
            secilenRandevu.MusteriID = ((Musteri)cmbMusteri.SelectedItem).ID;
            secilenRandevu.CalisanID = ((Calisan)cmbCalisan.SelectedItem).ID;
            secilenRandevu.HizmetID = ((Hizmet)cmbHizmet.SelectedItem).ID;
            secilenRandevu.Tarih = dtpTarih.Value;
            secilenRandevu.Saat = dtpSaat.Value.TimeOfDay;

            try
            {
                Veritabani.RandevuGuncelle(secilenRandevu);
                MessageBox.Show("Randevu başarıyla güncellendi.");
                ListeleRandevular();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListeleRandevular()
        {
            lstRandevular.Items.Clear();
            foreach (var randevu in Veritabani.Randevular)
            {
                lstRandevular.Items.Add(randevu);
            }
        }

        private void tabCalisanEkle_Click(object sender, EventArgs e)
        {
            // Bu alanı boş bırakabiliriz
        }

        private void tabRandevuEkle_Click(object sender, EventArgs e)
        {
            // Bu alanı boş bırakabiliriz
        }
    }
}
