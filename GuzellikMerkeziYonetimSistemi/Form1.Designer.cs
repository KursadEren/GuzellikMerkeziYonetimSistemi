namespace GuzellikMerkeziYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMusteriEkle = new System.Windows.Forms.TabPage();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.tabCalisanEkle = new System.Windows.Forms.TabPage();
            this.btnCalisanGuncelle = new System.Windows.Forms.Button();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.txtCalisanTCNo = new System.Windows.Forms.TextBox();
            this.lblCalisanTCNo = new System.Windows.Forms.Label();
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyad = new System.Windows.Forms.TextBox();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblCalisanSoyad = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.TabPage();
            this.btnHizmetGuncelle = new System.Windows.Forms.Button();
            this.btnHizmetSil = new System.Windows.Forms.Button();
            this.lstHizmetler = new System.Windows.Forms.ListBox();
            this.btnHizmetEkle = new System.Windows.Forms.Button();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtHizmetAd = new System.Windows.Forms.TextBox();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHizmetAd = new System.Windows.Forms.Label();
            this.tabRandevuEkle = new System.Windows.Forms.TabPage();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.btnRandevuGuncelle = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lstRandevular = new System.Windows.Forms.ListBox();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.lblHizmet = new System.Windows.Forms.Label();
            this.lblCalisan = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMusteriEkle.SuspendLayout();
            this.tabCalisanEkle.SuspendLayout();
            this.lblUcret.SuspendLayout();
            this.tabRandevuEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMusteriEkle);
            this.tabControl.Controls.Add(this.tabCalisanEkle);
            this.tabControl.Controls.Add(this.lblUcret);
            this.tabControl.Controls.Add(this.tabRandevuEkle);
            this.tabControl.Location = new System.Drawing.Point(5, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 435);
            this.tabControl.TabIndex = 0;
            // 
            // tabMusteriEkle
            // 
            this.tabMusteriEkle.Controls.Add(this.btnMusteriGuncelle);
            this.tabMusteriEkle.Controls.Add(this.btnMusteriSil);
            this.tabMusteriEkle.Controls.Add(this.txtTCNo);
            this.tabMusteriEkle.Controls.Add(this.lblTCNo);
            this.tabMusteriEkle.Controls.Add(this.lstMusteriler);
            this.tabMusteriEkle.Controls.Add(this.btnMusteriEkle);
            this.tabMusteriEkle.Controls.Add(this.txtEmail);
            this.tabMusteriEkle.Controls.Add(this.txtTelefon);
            this.tabMusteriEkle.Controls.Add(this.txtSoyad);
            this.tabMusteriEkle.Controls.Add(this.txtAd);
            this.tabMusteriEkle.Controls.Add(this.lblEmail);
            this.tabMusteriEkle.Controls.Add(this.lblTelefon);
            this.tabMusteriEkle.Controls.Add(this.lblSoyad);
            this.tabMusteriEkle.Controls.Add(this.lblAd);
            this.tabMusteriEkle.Location = new System.Drawing.Point(4, 25);
            this.tabMusteriEkle.Name = "tabMusteriEkle";
            this.tabMusteriEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusteriEkle.Size = new System.Drawing.Size(726, 406);
            this.tabMusteriEkle.TabIndex = 0;
            this.tabMusteriEkle.Text = "Musteri";
            this.tabMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(498, 353);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(187, 35);
            this.btnMusteriGuncelle.TabIndex = 13;
            this.btnMusteriGuncelle.Text = "Musteri Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click_1);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(263, 353);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(187, 35);
            this.btnMusteriSil.TabIndex = 12;
            this.btnMusteriSil.Text = "Musteri Sil ";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click_1);
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(125, 170);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(141, 22);
            this.txtTCNo.TabIndex = 11;
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(36, 170);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(43, 16);
            this.lblTCNo.TabIndex = 10;
            this.lblTCNo.Text = "TC no";
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 16;
            this.lstMusteriler.Location = new System.Drawing.Point(313, 6);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(397, 340);
            this.lstMusteriler.TabIndex = 9;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(39, 353);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(187, 35);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "Musteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 310);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(125, 238);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(141, 22);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(125, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(141, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(141, 22);
            this.txtAd.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 310);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(36, 238);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(36, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(36, 32);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // tabCalisanEkle
            // 
            this.tabCalisanEkle.Controls.Add(this.btnCalisanGuncelle);
            this.tabCalisanEkle.Controls.Add(this.btnCalisanSil);
            this.tabCalisanEkle.Controls.Add(this.txtCalisanTCNo);
            this.tabCalisanEkle.Controls.Add(this.lblCalisanTCNo);
            this.tabCalisanEkle.Controls.Add(this.lstCalisanlar);
            this.tabCalisanEkle.Controls.Add(this.btnCalisanEkle);
            this.tabCalisanEkle.Controls.Add(this.txtPozisyon);
            this.tabCalisanEkle.Controls.Add(this.txtCalisanSoyad);
            this.tabCalisanEkle.Controls.Add(this.txtCalisanAd);
            this.tabCalisanEkle.Controls.Add(this.lblPozisyon);
            this.tabCalisanEkle.Controls.Add(this.lblCalisanSoyad);
            this.tabCalisanEkle.Controls.Add(this.lblCalisanAd);
            this.tabCalisanEkle.Location = new System.Drawing.Point(4, 25);
            this.tabCalisanEkle.Name = "tabCalisanEkle";
            this.tabCalisanEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalisanEkle.Size = new System.Drawing.Size(726, 406);
            this.tabCalisanEkle.TabIndex = 1;
            this.tabCalisanEkle.Text = "Calisan";
            this.tabCalisanEkle.UseVisualStyleBackColor = true;
            this.tabCalisanEkle.Click += new System.EventHandler(this.tabCalisanEkle_Click);
            // 
            // btnCalisanGuncelle
            // 
            this.btnCalisanGuncelle.Location = new System.Drawing.Point(479, 348);
            this.btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            this.btnCalisanGuncelle.Size = new System.Drawing.Size(192, 35);
            this.btnCalisanGuncelle.TabIndex = 23;
            this.btnCalisanGuncelle.Text = "Çalişan Güncelle";
            this.btnCalisanGuncelle.UseVisualStyleBackColor = true;
            this.btnCalisanGuncelle.Click += new System.EventHandler(this.btnCalisanGuncelle_Click_1);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.Location = new System.Drawing.Point(252, 348);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(192, 35);
            this.btnCalisanSil.TabIndex = 22;
            this.btnCalisanSil.Text = "Çalişan Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = true;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click_1);
            // 
            // txtCalisanTCNo
            // 
            this.txtCalisanTCNo.Location = new System.Drawing.Point(112, 187);
            this.txtCalisanTCNo.Name = "txtCalisanTCNo";
            this.txtCalisanTCNo.Size = new System.Drawing.Size(141, 22);
            this.txtCalisanTCNo.TabIndex = 21;
            // 
            // lblCalisanTCNo
            // 
            this.lblCalisanTCNo.AutoSize = true;
            this.lblCalisanTCNo.Location = new System.Drawing.Point(23, 187);
            this.lblCalisanTCNo.Name = "lblCalisanTCNo";
            this.lblCalisanTCNo.Size = new System.Drawing.Size(41, 16);
            this.lblCalisanTCNo.TabIndex = 20;
            this.lblCalisanTCNo.Text = "Tc no";
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.ItemHeight = 16;
            this.lstCalisanlar.Location = new System.Drawing.Point(297, 25);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(374, 308);
            this.lstCalisanlar.TabIndex = 19;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(26, 348);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(192, 35);
            this.btnCalisanEkle.TabIndex = 18;
            this.btnCalisanEkle.Text = "Çalişan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Location = new System.Drawing.Point(112, 276);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(141, 22);
            this.txtPozisyon.TabIndex = 16;
            // 
            // txtCalisanSoyad
            // 
            this.txtCalisanSoyad.Location = new System.Drawing.Point(112, 98);
            this.txtCalisanSoyad.Name = "txtCalisanSoyad";
            this.txtCalisanSoyad.Size = new System.Drawing.Size(141, 22);
            this.txtCalisanSoyad.TabIndex = 15;
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.Location = new System.Drawing.Point(112, 25);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(141, 22);
            this.txtCalisanAd.TabIndex = 14;
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Location = new System.Drawing.Point(23, 276);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(62, 16);
            this.lblPozisyon.TabIndex = 12;
            this.lblPozisyon.Text = "Pozisyon";
            // 
            // lblCalisanSoyad
            // 
            this.lblCalisanSoyad.AutoSize = true;
            this.lblCalisanSoyad.Location = new System.Drawing.Point(23, 101);
            this.lblCalisanSoyad.Name = "lblCalisanSoyad";
            this.lblCalisanSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblCalisanSoyad.TabIndex = 11;
            this.lblCalisanSoyad.Text = "Soyad";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(23, 25);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(75, 16);
            this.lblCalisanAd.TabIndex = 10;
            this.lblCalisanAd.Text = "Çalişan Adı";
            // 
            // lblUcret
            // 
            this.lblUcret.Controls.Add(this.btnHizmetGuncelle);
            this.lblUcret.Controls.Add(this.btnHizmetSil);
            this.lblUcret.Controls.Add(this.lstHizmetler);
            this.lblUcret.Controls.Add(this.btnHizmetEkle);
            this.lblUcret.Controls.Add(this.txtIcerik);
            this.lblUcret.Controls.Add(this.txtUcret);
            this.lblUcret.Controls.Add(this.txtHizmetAd);
            this.lblUcret.Controls.Add(this.lblIcerik);
            this.lblUcret.Controls.Add(this.label2);
            this.lblUcret.Controls.Add(this.lblHizmetAd);
            this.lblUcret.Location = new System.Drawing.Point(4, 25);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Padding = new System.Windows.Forms.Padding(3);
            this.lblUcret.Size = new System.Drawing.Size(726, 406);
            this.lblUcret.TabIndex = 2;
            this.lblUcret.Text = "Hizmet ";
            this.lblUcret.UseVisualStyleBackColor = true;
            // 
            // btnHizmetGuncelle
            // 
            this.btnHizmetGuncelle.Location = new System.Drawing.Point(453, 343);
            this.btnHizmetGuncelle.Name = "btnHizmetGuncelle";
            this.btnHizmetGuncelle.Size = new System.Drawing.Size(202, 35);
            this.btnHizmetGuncelle.TabIndex = 29;
            this.btnHizmetGuncelle.Text = "Hizmet Guncelle";
            this.btnHizmetGuncelle.UseVisualStyleBackColor = true;
            this.btnHizmetGuncelle.Click += new System.EventHandler(this.btnHizmetGuncelle_Click_1);
            // 
            // btnHizmetSil
            // 
            this.btnHizmetSil.Location = new System.Drawing.Point(245, 343);
            this.btnHizmetSil.Name = "btnHizmetSil";
            this.btnHizmetSil.Size = new System.Drawing.Size(202, 35);
            this.btnHizmetSil.TabIndex = 28;
            this.btnHizmetSil.Text = "Hizmet Sil";
            this.btnHizmetSil.UseVisualStyleBackColor = true;
            this.btnHizmetSil.Click += new System.EventHandler(this.btnHizmetSil_Click_1);
            // 
            // lstHizmetler
            // 
            this.lstHizmetler.FormattingEnabled = true;
            this.lstHizmetler.ItemHeight = 16;
            this.lstHizmetler.Location = new System.Drawing.Point(288, 22);
            this.lstHizmetler.Name = "lstHizmetler";
            this.lstHizmetler.Size = new System.Drawing.Size(367, 308);
            this.lstHizmetler.TabIndex = 27;
            // 
            // btnHizmetEkle
            // 
            this.btnHizmetEkle.Location = new System.Drawing.Point(30, 343);
            this.btnHizmetEkle.Name = "btnHizmetEkle";
            this.btnHizmetEkle.Size = new System.Drawing.Size(202, 35);
            this.btnHizmetEkle.TabIndex = 26;
            this.btnHizmetEkle.Text = "Hizmet Ekle";
            this.btnHizmetEkle.UseVisualStyleBackColor = true;
            this.btnHizmetEkle.Click += new System.EventHandler(this.btnHizmetEkle_Click);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(116, 200);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(141, 22);
            this.txtIcerik.TabIndex = 25;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(116, 106);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(141, 22);
            this.txtUcret.TabIndex = 24;
            // 
            // txtHizmetAd
            // 
            this.txtHizmetAd.Location = new System.Drawing.Point(116, 22);
            this.txtHizmetAd.Name = "txtHizmetAd";
            this.txtHizmetAd.Size = new System.Drawing.Size(141, 22);
            this.txtHizmetAd.TabIndex = 23;
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(27, 200);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(39, 16);
            this.lblIcerik.TabIndex = 22;
            this.lblIcerik.Text = "İçerik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ücret";
            // 
            // lblHizmetAd
            // 
            this.lblHizmetAd.AutoSize = true;
            this.lblHizmetAd.Location = new System.Drawing.Point(27, 22);
            this.lblHizmetAd.Name = "lblHizmetAd";
            this.lblHizmetAd.Size = new System.Drawing.Size(71, 16);
            this.lblHizmetAd.TabIndex = 20;
            this.lblHizmetAd.Text = "Hizmet Adı";
            // 
            // tabRandevuEkle
            // 
            this.tabRandevuEkle.Controls.Add(this.dtpSaat);
            this.tabRandevuEkle.Controls.Add(this.btnRandevuGuncelle);
            this.tabRandevuEkle.Controls.Add(this.btnRandevuSil);
            this.tabRandevuEkle.Controls.Add(this.dtpTarih);
            this.tabRandevuEkle.Controls.Add(this.cmbHizmet);
            this.tabRandevuEkle.Controls.Add(this.cmbCalisan);
            this.tabRandevuEkle.Controls.Add(this.cmbMusteri);
            this.tabRandevuEkle.Controls.Add(this.lblTarih);
            this.tabRandevuEkle.Controls.Add(this.lstRandevular);
            this.tabRandevuEkle.Controls.Add(this.btnRandevuEkle);
            this.tabRandevuEkle.Controls.Add(this.lblHizmet);
            this.tabRandevuEkle.Controls.Add(this.lblCalisan);
            this.tabRandevuEkle.Controls.Add(this.lblMusteri);
            this.tabRandevuEkle.Location = new System.Drawing.Point(4, 25);
            this.tabRandevuEkle.Name = "tabRandevuEkle";
            this.tabRandevuEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandevuEkle.Size = new System.Drawing.Size(726, 406);
            this.tabRandevuEkle.TabIndex = 3;
            this.tabRandevuEkle.Text = "Randevu";
            this.tabRandevuEkle.UseVisualStyleBackColor = true;
            this.tabRandevuEkle.Click += new System.EventHandler(this.tabRandevuEkle_Click);
            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(67, 320);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.Size = new System.Drawing.Size(200, 22);
            this.dtpSaat.TabIndex = 46;
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(471, 346);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(205, 35);
            this.btnRandevuGuncelle.TabIndex = 45;
            this.btnRandevuGuncelle.Text = "Randevu Güncelle";
            this.btnRandevuGuncelle.UseVisualStyleBackColor = true;
            this.btnRandevuGuncelle.Click += new System.EventHandler(this.btnRandevuGuncelle_Click_1);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(249, 346);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(216, 35);
            this.btnRandevuSil.TabIndex = 44;
            this.btnRandevuSil.Text = "Randevu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click_1);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(67, 292);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 43;
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.Location = new System.Drawing.Point(112, 203);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(121, 24);
            this.cmbHizmet.TabIndex = 42;
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(112, 109);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(121, 24);
            this.cmbCalisan.TabIndex = 39;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(112, 25);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 24);
            this.cmbMusteri.TabIndex = 38;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(23, 297);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 36;
            this.lblTarih.Text = "Tarih";
            // 
            // lstRandevular
            // 
            this.lstRandevular.FormattingEnabled = true;
            this.lstRandevular.ItemHeight = 16;
            this.lstRandevular.Location = new System.Drawing.Point(288, 25);
            this.lstRandevular.Name = "lstRandevular";
            this.lstRandevular.Size = new System.Drawing.Size(388, 292);
            this.lstRandevular.TabIndex = 35;
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Location = new System.Drawing.Point(26, 346);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(207, 35);
            this.btnRandevuEkle.TabIndex = 34;
            this.btnRandevuEkle.Text = "Randevu Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // lblHizmet
            // 
            this.lblHizmet.AutoSize = true;
            this.lblHizmet.Location = new System.Drawing.Point(23, 203);
            this.lblHizmet.Name = "lblHizmet";
            this.lblHizmet.Size = new System.Drawing.Size(48, 16);
            this.lblHizmet.TabIndex = 30;
            this.lblHizmet.Text = "Hizmet";
            // 
            // lblCalisan
            // 
            this.lblCalisan.AutoSize = true;
            this.lblCalisan.Location = new System.Drawing.Point(23, 112);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(52, 16);
            this.lblCalisan.TabIndex = 29;
            this.lblCalisan.Text = "Calisan";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(23, 25);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(50, 16);
            this.lblMusteri.TabIndex = 28;
            this.lblMusteri.Text = "Musteri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMusteriEkle.ResumeLayout(false);
            this.tabMusteriEkle.PerformLayout();
            this.tabCalisanEkle.ResumeLayout(false);
            this.tabCalisanEkle.PerformLayout();
            this.lblUcret.ResumeLayout(false);
            this.lblUcret.PerformLayout();
            this.tabRandevuEkle.ResumeLayout(false);
            this.tabRandevuEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMusteriEkle;
        private System.Windows.Forms.TabPage tabCalisanEkle;
        private System.Windows.Forms.TabPage lblUcret;
        private System.Windows.Forms.TabPage tabRandevuEkle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ListBox lstCalisanlar;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.TextBox txtCalisanSoyad;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblCalisanSoyad;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.ListBox lstHizmetler;
        private System.Windows.Forms.Button btnHizmetEkle;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtHizmetAd;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHizmetAd;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ListBox lstRandevular;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.Label lblHizmet;
        private System.Windows.Forms.Label lblCalisan;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.TextBox txtCalisanTCNo;
        private System.Windows.Forms.Label lblCalisanTCNo;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnCalisanGuncelle;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Button btnHizmetGuncelle;
        private System.Windows.Forms.Button btnHizmetSil;
        private System.Windows.Forms.Button btnRandevuGuncelle;
        private System.Windows.Forms.DateTimePicker dtpSaat;
    }
}

