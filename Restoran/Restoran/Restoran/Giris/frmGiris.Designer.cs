namespace Restoran
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txSifre = new System.Windows.Forms.TextBox();
            this.pictureKapat = new System.Windows.Forms.PictureBox();
            this.pictureAltaAl = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Location = new System.Drawing.Point(164, 288);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(103, 37);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txKullaniciAdi
            // 
            this.txKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txKullaniciAdi.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txKullaniciAdi.Location = new System.Drawing.Point(165, 154);
            this.txKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txKullaniciAdi.Name = "txKullaniciAdi";
            this.txKullaniciAdi.Size = new System.Drawing.Size(156, 27);
            this.txKullaniciAdi.TabIndex = 0;
            // 
            // txSifre
            // 
            this.txSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(180)))));
            this.txSifre.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txSifre.Location = new System.Drawing.Point(165, 232);
            this.txSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txSifre.Name = "txSifre";
            this.txSifre.PasswordChar = '*';
            this.txSifre.Size = new System.Drawing.Size(156, 27);
            this.txSifre.TabIndex = 2;
            // 
            // pictureKapat
            // 
            this.pictureKapat.BackColor = System.Drawing.Color.Transparent;
            this.pictureKapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureKapat.Image")));
            this.pictureKapat.Location = new System.Drawing.Point(372, 12);
            this.pictureKapat.Name = "pictureKapat";
            this.pictureKapat.Size = new System.Drawing.Size(50, 40);
            this.pictureKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKapat.TabIndex = 25;
            this.pictureKapat.TabStop = false;
            this.pictureKapat.Click += new System.EventHandler(this.pictureKapat_Click);
            // 
            // pictureAltaAl
            // 
            this.pictureAltaAl.BackColor = System.Drawing.Color.Transparent;
            this.pictureAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("pictureAltaAl.Image")));
            this.pictureAltaAl.Location = new System.Drawing.Point(316, 12);
            this.pictureAltaAl.Name = "pictureAltaAl";
            this.pictureAltaAl.Size = new System.Drawing.Size(50, 40);
            this.pictureAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAltaAl.TabIndex = 47;
            this.pictureAltaAl.TabStop = false;
            this.pictureAltaAl.Click += new System.EventHandler(this.pictureAltaAl_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(12, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 40);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfo.TabIndex = 48;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 375);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pictureAltaAl);
            this.Controls.Add(this.pictureKapat);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txSifre);
            this.Controls.Add(this.txKullaniciAdi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txKullaniciAdi;
        private System.Windows.Forms.TextBox txSifre;
        private System.Windows.Forms.PictureBox pictureKapat;
        private System.Windows.Forms.PictureBox pictureAltaAl;
        private System.Windows.Forms.PictureBox btnInfo;
    }
}

