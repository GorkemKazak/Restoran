namespace Restoran.Yetkili
{
    partial class frmCalisanIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanIslemleri));
            this.txKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtgvListe = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txAdSoyad = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txAdres = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.msktxTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonNO = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.pictureKapat = new System.Windows.Forms.PictureBox();
            this.chxCikisDurumu = new System.Windows.Forms.CheckBox();
            this.chxIstenCikanlariListele = new System.Windows.Forms.CheckBox();
            this.pictureGeri = new System.Windows.Forms.PictureBox();
            this.pictureAltaAl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // txKullaniciAdi
            // 
            this.txKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txKullaniciAdi.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txKullaniciAdi.Location = new System.Drawing.Point(122, 223);
            this.txKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txKullaniciAdi.Name = "txKullaniciAdi";
            this.txKullaniciAdi.Size = new System.Drawing.Size(135, 33);
            this.txKullaniciAdi.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(598, 255);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 62);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txSifre
            // 
            this.txSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txSifre.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txSifre.Location = new System.Drawing.Point(294, 221);
            this.txSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txSifre.Name = "txSifre";
            this.txSifre.Size = new System.Drawing.Size(135, 33);
            this.txSifre.TabIndex = 4;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(12, 19);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(192, 33);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Çalışan İşlemleri";
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Yetkili\t",
            "Garson",
            "Kasiyer"});
            this.cmbRol.Location = new System.Drawing.Point(458, 221);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(135, 35);
            this.cmbRol.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(598, 333);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 62);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(598, 414);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 62);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtgvListe
            // 
            this.dtgvListe.AllowUserToAddRows = false;
            this.dtgvListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.dtgvListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListe.Location = new System.Drawing.Point(113, 383);
            this.dtgvListe.Name = "dtgvListe";
            this.dtgvListe.ReadOnly = true;
            this.dtgvListe.RowHeadersWidth = 51;
            this.dtgvListe.Size = new System.Drawing.Size(481, 141);
            this.dtgvListe.TabIndex = 10;
            this.dtgvListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListe_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Transparent;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(113, 524);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(481, 64);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txAdSoyad
            // 
            this.txAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txAdSoyad.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txAdSoyad.Location = new System.Drawing.Point(122, 285);
            this.txAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txAdSoyad.Name = "txAdSoyad";
            this.txAdSoyad.Size = new System.Drawing.Size(135, 33);
            this.txAdSoyad.TabIndex = 12;
            // 
            // txEmail
            // 
            this.txEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txEmail.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txEmail.Location = new System.Drawing.Point(459, 286);
            this.txEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(135, 33);
            this.txEmail.TabIndex = 14;
            // 
            // txAdres
            // 
            this.txAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txAdres.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txAdres.Location = new System.Drawing.Point(167, 348);
            this.txAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txAdres.Name = "txAdres";
            this.txAdres.Size = new System.Drawing.Size(426, 33);
            this.txAdres.TabIndex = 15;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(117, 196);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(137, 27);
            this.lblKullaniciAdi.TabIndex = 16;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(333, 189);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(51, 27);
            this.lblSifre.TabIndex = 17;
            this.lblSifre.Text = "Şifre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRol.Location = new System.Drawing.Point(502, 189);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 27);
            this.lblRol.TabIndex = 18;
            this.lblRol.Text = "Rol";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(120, 258);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(93, 27);
            this.lblAdSoyad.TabIndex = 19;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // msktxTelefonNo
            // 
            this.msktxTelefonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.msktxTelefonNo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxTelefonNo.Location = new System.Drawing.Point(294, 286);
            this.msktxTelefonNo.Mask = "(999) 000-0000";
            this.msktxTelefonNo.Name = "msktxTelefonNo";
            this.msktxTelefonNo.Size = new System.Drawing.Size(135, 33);
            this.msktxTelefonNo.TabIndex = 20;
            // 
            // lblTelefonNO
            // 
            this.lblTelefonNO.AutoSize = true;
            this.lblTelefonNO.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonNO.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNO.Location = new System.Drawing.Point(308, 258);
            this.lblTelefonNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonNO.Name = "lblTelefonNO";
            this.lblTelefonNO.Size = new System.Drawing.Size(98, 27);
            this.lblTelefonNO.TabIndex = 21;
            this.lblTelefonNO.Text = "Telefon No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(475, 259);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 27);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(89, 351);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(63, 27);
            this.lblAdres.TabIndex = 23;
            this.lblAdres.Text = "Adres:";
            // 
            // pictureKapat
            // 
            this.pictureKapat.BackColor = System.Drawing.Color.Transparent;
            this.pictureKapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureKapat.Image")));
            this.pictureKapat.Location = new System.Drawing.Point(676, 12);
            this.pictureKapat.Name = "pictureKapat";
            this.pictureKapat.Size = new System.Drawing.Size(50, 40);
            this.pictureKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKapat.TabIndex = 24;
            this.pictureKapat.TabStop = false;
            this.pictureKapat.Click += new System.EventHandler(this.pictureKapat_Click);
            // 
            // chxCikisDurumu
            // 
            this.chxCikisDurumu.AutoSize = true;
            this.chxCikisDurumu.BackColor = System.Drawing.Color.Transparent;
            this.chxCikisDurumu.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxCikisDurumu.Location = new System.Drawing.Point(291, 322);
            this.chxCikisDurumu.Name = "chxCikisDurumu";
            this.chxCikisDurumu.Size = new System.Drawing.Size(138, 26);
            this.chxCikisDurumu.TabIndex = 26;
            this.chxCikisDurumu.Text = "Çıkış Durumu:";
            this.chxCikisDurumu.UseVisualStyleBackColor = false;
            // 
            // chxIstenCikanlariListele
            // 
            this.chxIstenCikanlariListele.AutoSize = true;
            this.chxIstenCikanlariListele.BackColor = System.Drawing.Color.Transparent;
            this.chxIstenCikanlariListele.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxIstenCikanlariListele.Location = new System.Drawing.Point(248, 593);
            this.chxIstenCikanlariListele.Name = "chxIstenCikanlariListele";
            this.chxIstenCikanlariListele.Size = new System.Drawing.Size(196, 26);
            this.chxIstenCikanlariListele.TabIndex = 27;
            this.chxIstenCikanlariListele.Text = "İşten Çıkanları Listele";
            this.chxIstenCikanlariListele.UseVisualStyleBackColor = false;
            // 
            // pictureGeri
            // 
            this.pictureGeri.BackColor = System.Drawing.Color.Transparent;
            this.pictureGeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureGeri.Image")));
            this.pictureGeri.Location = new System.Drawing.Point(576, 12);
            this.pictureGeri.Name = "pictureGeri";
            this.pictureGeri.Size = new System.Drawing.Size(50, 40);
            this.pictureGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGeri.TabIndex = 48;
            this.pictureGeri.TabStop = false;
            this.pictureGeri.Click += new System.EventHandler(this.pictureGeri_Click);
            // 
            // pictureAltaAl
            // 
            this.pictureAltaAl.BackColor = System.Drawing.Color.Transparent;
            this.pictureAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("pictureAltaAl.Image")));
            this.pictureAltaAl.Location = new System.Drawing.Point(626, 12);
            this.pictureAltaAl.Name = "pictureAltaAl";
            this.pictureAltaAl.Size = new System.Drawing.Size(50, 40);
            this.pictureAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAltaAl.TabIndex = 47;
            this.pictureAltaAl.TabStop = false;
            this.pictureAltaAl.Click += new System.EventHandler(this.pictureAltaAl_Click);
            // 
            // frmCalisanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 720);
            this.Controls.Add(this.pictureGeri);
            this.Controls.Add(this.pictureAltaAl);
            this.Controls.Add(this.chxIstenCikanlariListele);
            this.Controls.Add(this.chxCikisDurumu);
            this.Controls.Add(this.pictureKapat);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefonNO);
            this.Controls.Add(this.msktxTelefonNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txAdres);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txAdSoyad);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtgvListe);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txSifre);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txKullaniciAdi);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalisanIslemleri";
            this.Load += new System.EventHandler(this.frmCalisanIslemleri_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txKullaniciAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dtgvListe;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txAdSoyad;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txAdres;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.MaskedTextBox msktxTelefonNo;
        private System.Windows.Forms.Label lblTelefonNO;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.PictureBox pictureKapat;
        private System.Windows.Forms.CheckBox chxCikisDurumu;
        private System.Windows.Forms.CheckBox chxIstenCikanlariListele;
        private System.Windows.Forms.PictureBox pictureGeri;
        private System.Windows.Forms.PictureBox pictureAltaAl;
    }
}