namespace Restoran.Yetkili
{
    partial class frmUrunIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunIslemleri));
            this.txUrunAdi = new System.Windows.Forms.TextBox();
            this.txUrunFiyati = new System.Windows.Forms.TextBox();
            this.lblYemekler = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunTuru = new System.Windows.Forms.Label();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dtgvUrunListesi = new System.Windows.Forms.DataGridView();
            this.cmbUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.pictureKapat = new System.Windows.Forms.PictureBox();
            this.pictureGeri = new System.Windows.Forms.PictureBox();
            this.pictureAltaAl = new System.Windows.Forms.PictureBox();
            this.cbSatisIptal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // txUrunAdi
            // 
            this.txUrunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txUrunAdi.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txUrunAdi.Location = new System.Drawing.Point(124, 236);
            this.txUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txUrunAdi.Name = "txUrunAdi";
            this.txUrunAdi.Size = new System.Drawing.Size(124, 31);
            this.txUrunAdi.TabIndex = 0;
            // 
            // txUrunFiyati
            // 
            this.txUrunFiyati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txUrunFiyati.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txUrunFiyati.Location = new System.Drawing.Point(420, 236);
            this.txUrunFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.txUrunFiyati.Name = "txUrunFiyati";
            this.txUrunFiyati.Size = new System.Drawing.Size(124, 31);
            this.txUrunFiyati.TabIndex = 2;
            // 
            // lblYemekler
            // 
            this.lblYemekler.AutoSize = true;
            this.lblYemekler.BackColor = System.Drawing.Color.Transparent;
            this.lblYemekler.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYemekler.Location = new System.Drawing.Point(11, 9);
            this.lblYemekler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYemekler.Name = "lblYemekler";
            this.lblYemekler.Size = new System.Drawing.Size(140, 37);
            this.lblYemekler.TabIndex = 5;
            this.lblYemekler.Text = "URUNLER";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunAdi.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(131, 207);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(98, 27);
            this.lblUrunAdi.TabIndex = 6;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblUrunTuru
            // 
            this.lblUrunTuru.AutoSize = true;
            this.lblUrunTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunTuru.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTuru.Location = new System.Drawing.Point(261, 207);
            this.lblUrunTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunTuru.Name = "lblUrunTuru";
            this.lblUrunTuru.Size = new System.Drawing.Size(146, 27);
            this.lblUrunTuru.TabIndex = 7;
            this.lblUrunTuru.Text = "Ürün Kategorisi";
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyati.Location = new System.Drawing.Point(425, 207);
            this.lblUrunFiyati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(113, 27);
            this.lblUrunFiyati.TabIndex = 8;
            this.lblUrunFiyati.Text = "Ürün Fiyatı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(548, 318);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 37);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(548, 277);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 37);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(548, 236);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 37);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Transparent;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(548, 359);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(85, 37);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dtgvUrunListesi
            // 
            this.dtgvUrunListesi.AllowUserToAddRows = false;
            this.dtgvUrunListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.dtgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUrunListesi.Location = new System.Drawing.Point(123, 276);
            this.dtgvUrunListesi.Name = "dtgvUrunListesi";
            this.dtgvUrunListesi.ReadOnly = true;
            this.dtgvUrunListesi.Size = new System.Drawing.Size(420, 217);
            this.dtgvUrunListesi.TabIndex = 14;
            this.dtgvUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUrunListesi_CellClick);
            // 
            // cmbUrunKategorisi
            // 
            this.cmbUrunKategorisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.cmbUrunKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunKategorisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUrunKategorisi.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunKategorisi.FormattingEnabled = true;
            this.cmbUrunKategorisi.Location = new System.Drawing.Point(266, 235);
            this.cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            this.cmbUrunKategorisi.Size = new System.Drawing.Size(135, 33);
            this.cmbUrunKategorisi.TabIndex = 15;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(548, 400);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 37);
            this.btnAra.TabIndex = 16;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // pictureKapat
            // 
            this.pictureKapat.BackColor = System.Drawing.Color.Transparent;
            this.pictureKapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureKapat.Image")));
            this.pictureKapat.Location = new System.Drawing.Point(619, 6);
            this.pictureKapat.Name = "pictureKapat";
            this.pictureKapat.Size = new System.Drawing.Size(50, 40);
            this.pictureKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKapat.TabIndex = 25;
            this.pictureKapat.TabStop = false;
            this.pictureKapat.Click += new System.EventHandler(this.pictureKapat_Click);
            // 
            // pictureGeri
            // 
            this.pictureGeri.BackColor = System.Drawing.Color.Transparent;
            this.pictureGeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureGeri.Image")));
            this.pictureGeri.Location = new System.Drawing.Point(522, 6);
            this.pictureGeri.Name = "pictureGeri";
            this.pictureGeri.Size = new System.Drawing.Size(50, 40);
            this.pictureGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGeri.TabIndex = 50;
            this.pictureGeri.TabStop = false;
            this.pictureGeri.Click += new System.EventHandler(this.pictureGeri_Click);
            // 
            // pictureAltaAl
            // 
            this.pictureAltaAl.BackColor = System.Drawing.Color.Transparent;
            this.pictureAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("pictureAltaAl.Image")));
            this.pictureAltaAl.Location = new System.Drawing.Point(572, 6);
            this.pictureAltaAl.Name = "pictureAltaAl";
            this.pictureAltaAl.Size = new System.Drawing.Size(50, 40);
            this.pictureAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAltaAl.TabIndex = 49;
            this.pictureAltaAl.TabStop = false;
            this.pictureAltaAl.Click += new System.EventHandler(this.pictureAltaAl_Click);
            // 
            // cbSatisIptal
            // 
            this.cbSatisIptal.AutoSize = true;
            this.cbSatisIptal.BackColor = System.Drawing.Color.Transparent;
            this.cbSatisIptal.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSatisIptal.Location = new System.Drawing.Point(197, 498);
            this.cbSatisIptal.Margin = new System.Windows.Forms.Padding(2);
            this.cbSatisIptal.Name = "cbSatisIptal";
            this.cbSatisIptal.Size = new System.Drawing.Size(284, 41);
            this.cbSatisIptal.TabIndex = 51;
            this.cbSatisIptal.Text = "Satışı İptal Edilenler";
            this.cbSatisIptal.UseVisualStyleBackColor = false;
            // 
            // frmUrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 648);
            this.Controls.Add(this.cbSatisIptal);
            this.Controls.Add(this.pictureGeri);
            this.Controls.Add(this.pictureAltaAl);
            this.Controls.Add(this.pictureKapat);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbUrunKategorisi);
            this.Controls.Add(this.dtgvUrunListesi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.lblUrunTuru);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblYemekler);
            this.Controls.Add(this.txUrunFiyati);
            this.Controls.Add(this.txUrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUrunIslemleri";
            this.Text = "UrunIslemleri";
            this.Load += new System.EventHandler(this.frmUrunIslemleri_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUrunListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUrunAdi;
        private System.Windows.Forms.TextBox txUrunFiyati;
        private System.Windows.Forms.Label lblYemekler;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunTuru;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dtgvUrunListesi;
        private System.Windows.Forms.ComboBox cmbUrunKategorisi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.PictureBox pictureKapat;
        private System.Windows.Forms.PictureBox pictureGeri;
        private System.Windows.Forms.PictureBox pictureAltaAl;
        private System.Windows.Forms.CheckBox cbSatisIptal;
    }
}