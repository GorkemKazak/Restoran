namespace Restoran.Yetkili
{
    partial class frmSiparisIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisIslemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvTumSiparisler = new System.Windows.Forms.DataGridView();
            this.pictureKapat = new System.Windows.Forms.PictureBox();
            this.pictureGeri = new System.Windows.Forms.PictureBox();
            this.pictureAltaAl = new System.Windows.Forms.PictureBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblToplamDeger = new System.Windows.Forms.Label();
            this.btnSiparisleriGoruntule = new System.Windows.Forms.Button();
            this.txSiparisID = new System.Windows.Forms.TextBox();
            this.lblSiparisAra = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTumSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtgvTumSiparisler);
            this.groupBox1.Location = new System.Drawing.Point(16, 139);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(431, 297);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dtgvTumSiparisler
            // 
            this.dtgvTumSiparisler.AllowUserToAddRows = false;
            this.dtgvTumSiparisler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.dtgvTumSiparisler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTumSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTumSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTumSiparisler.Location = new System.Drawing.Point(2, 15);
            this.dtgvTumSiparisler.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTumSiparisler.Name = "dtgvTumSiparisler";
            this.dtgvTumSiparisler.ReadOnly = true;
            this.dtgvTumSiparisler.RowHeadersWidth = 51;
            this.dtgvTumSiparisler.RowTemplate.Height = 24;
            this.dtgvTumSiparisler.Size = new System.Drawing.Size(427, 280);
            this.dtgvTumSiparisler.TabIndex = 0;
            // 
            // pictureKapat
            // 
            this.pictureKapat.BackColor = System.Drawing.Color.Transparent;
            this.pictureKapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureKapat.Image")));
            this.pictureKapat.Location = new System.Drawing.Point(403, 12);
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
            this.pictureGeri.Location = new System.Drawing.Point(304, 12);
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
            this.pictureAltaAl.Location = new System.Drawing.Point(354, 12);
            this.pictureAltaAl.Name = "pictureAltaAl";
            this.pictureAltaAl.Size = new System.Drawing.Size(50, 40);
            this.pictureAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAltaAl.TabIndex = 49;
            this.pictureAltaAl.TabStop = false;
            this.pictureAltaAl.Click += new System.EventHandler(this.pictureAltaAl_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(11, 537);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(111, 31);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "TOPLAM:";
            // 
            // lblToplamDeger
            // 
            this.lblToplamDeger.AutoSize = true;
            this.lblToplamDeger.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamDeger.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamDeger.Location = new System.Drawing.Point(126, 540);
            this.lblToplamDeger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamDeger.Name = "lblToplamDeger";
            this.lblToplamDeger.Size = new System.Drawing.Size(60, 27);
            this.lblToplamDeger.TabIndex = 8;
            this.lblToplamDeger.Text = "NULL";
            // 
            // btnSiparisleriGoruntule
            // 
            this.btnSiparisleriGoruntule.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisleriGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisleriGoruntule.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisleriGoruntule.Location = new System.Drawing.Point(98, 446);
            this.btnSiparisleriGoruntule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisleriGoruntule.Name = "btnSiparisleriGoruntule";
            this.btnSiparisleriGoruntule.Size = new System.Drawing.Size(256, 41);
            this.btnSiparisleriGoruntule.TabIndex = 51;
            this.btnSiparisleriGoruntule.Text = "SİPARİŞLERİ GÖRÜNTÜLE";
            this.btnSiparisleriGoruntule.UseVisualStyleBackColor = false;
            this.btnSiparisleriGoruntule.Click += new System.EventHandler(this.btnSiparisleriGoruntule_Click);
            // 
            // txSiparisID
            // 
            this.txSiparisID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.txSiparisID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSiparisID.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txSiparisID.Location = new System.Drawing.Point(149, 507);
            this.txSiparisID.MaxLength = 19;
            this.txSiparisID.Name = "txSiparisID";
            this.txSiparisID.Size = new System.Drawing.Size(68, 33);
            this.txSiparisID.TabIndex = 53;
            this.txSiparisID.TextChanged += new System.EventHandler(this.txSiparisID_TextChanged);
            // 
            // lblSiparisAra
            // 
            this.lblSiparisAra.AutoSize = true;
            this.lblSiparisAra.BackColor = System.Drawing.Color.Transparent;
            this.lblSiparisAra.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisAra.Location = new System.Drawing.Point(12, 506);
            this.lblSiparisAra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiparisAra.Name = "lblSiparisAra";
            this.lblSiparisAra.Size = new System.Drawing.Size(138, 31);
            this.lblSiparisAra.TabIndex = 52;
            this.lblSiparisAra.Text = "Sipariş Ara:";
            // 
            // frmSiparisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 577);
            this.Controls.Add(this.txSiparisID);
            this.Controls.Add(this.lblSiparisAra);
            this.Controls.Add(this.btnSiparisleriGoruntule);
            this.Controls.Add(this.pictureGeri);
            this.Controls.Add(this.pictureAltaAl);
            this.Controls.Add(this.pictureKapat);
            this.Controls.Add(this.lblToplamDeger);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSiparisIslemleri";
            this.Text = "frmSiparisler";
            this.Load += new System.EventHandler(this.frmSiparisIslemleri_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTumSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvTumSiparisler;
        private System.Windows.Forms.PictureBox pictureKapat;
        private System.Windows.Forms.PictureBox pictureGeri;
        private System.Windows.Forms.PictureBox pictureAltaAl;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblToplamDeger;
        private System.Windows.Forms.Button btnSiparisleriGoruntule;
        private System.Windows.Forms.TextBox txSiparisID;
        private System.Windows.Forms.Label lblSiparisAra;
    }
}