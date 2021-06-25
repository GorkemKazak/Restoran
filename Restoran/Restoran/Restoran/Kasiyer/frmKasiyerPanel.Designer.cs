namespace Restoran
{
    partial class frmKasiyerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasiyerPanel));
            this.dtgvSiparisler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureKapat = new System.Windows.Forms.PictureBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txSiparisID = new System.Windows.Forms.TextBox();
            this.btnDetayGoruntule = new System.Windows.Forms.Button();
            this.pictureAltaAl = new System.Windows.Forms.PictureBox();
            this.pictureGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSiparisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSiparisler
            // 
            this.dtgvSiparisler.AllowUserToAddRows = false;
            this.dtgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSiparisler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.dtgvSiparisler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSiparisler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.dtgvSiparisler.Location = new System.Drawing.Point(2, 15);
            this.dtgvSiparisler.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvSiparisler.Name = "dtgvSiparisler";
            this.dtgvSiparisler.ReadOnly = true;
            this.dtgvSiparisler.RowHeadersWidth = 51;
            this.dtgvSiparisler.RowTemplate.Height = 24;
            this.dtgvSiparisler.Size = new System.Drawing.Size(428, 282);
            this.dtgvSiparisler.TabIndex = 0;
            this.dtgvSiparisler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSiparisler_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtgvSiparisler);
            this.groupBox1.Location = new System.Drawing.Point(16, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(432, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(12, 448);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(138, 31);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "Sipariş Ara:";
            // 
            // txSiparisID
            // 
            this.txSiparisID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.txSiparisID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSiparisID.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txSiparisID.Location = new System.Drawing.Point(149, 449);
            this.txSiparisID.MaxLength = 19;
            this.txSiparisID.Name = "txSiparisID";
            this.txSiparisID.Size = new System.Drawing.Size(68, 33);
            this.txSiparisID.TabIndex = 26;
            this.txSiparisID.TextChanged += new System.EventHandler(this.txSiparisID_TextChanged);
            this.txSiparisID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngel);
            // 
            // btnDetayGoruntule
            // 
            this.btnDetayGoruntule.BackColor = System.Drawing.Color.Transparent;
            this.btnDetayGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetayGoruntule.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetayGoruntule.Location = new System.Drawing.Point(19, 487);
            this.btnDetayGoruntule.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetayGoruntule.Name = "btnDetayGoruntule";
            this.btnDetayGoruntule.Size = new System.Drawing.Size(199, 41);
            this.btnDetayGoruntule.TabIndex = 27;
            this.btnDetayGoruntule.Text = "DETAY GÖRÜNTÜLE";
            this.btnDetayGoruntule.UseVisualStyleBackColor = false;
            this.btnDetayGoruntule.Click += new System.EventHandler(this.btnDetayGoruntule_Click);
            // 
            // pictureAltaAl
            // 
            this.pictureAltaAl.BackColor = System.Drawing.Color.Transparent;
            this.pictureAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("pictureAltaAl.Image")));
            this.pictureAltaAl.Location = new System.Drawing.Point(347, 12);
            this.pictureAltaAl.Name = "pictureAltaAl";
            this.pictureAltaAl.Size = new System.Drawing.Size(50, 40);
            this.pictureAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAltaAl.TabIndex = 28;
            this.pictureAltaAl.TabStop = false;
            this.pictureAltaAl.Click += new System.EventHandler(this.pictureAltaAl_Click);
            // 
            // pictureGeri
            // 
            this.pictureGeri.BackColor = System.Drawing.Color.Transparent;
            this.pictureGeri.Image = ((System.Drawing.Image)(resources.GetObject("pictureGeri.Image")));
            this.pictureGeri.Location = new System.Drawing.Point(18, 12);
            this.pictureGeri.Name = "pictureGeri";
            this.pictureGeri.Size = new System.Drawing.Size(50, 40);
            this.pictureGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGeri.TabIndex = 29;
            this.pictureGeri.TabStop = false;
            this.pictureGeri.Click += new System.EventHandler(this.pictureGeri_Click);
            // 
            // frmKasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 580);
            this.Controls.Add(this.pictureGeri);
            this.Controls.Add(this.pictureAltaAl);
            this.Controls.Add(this.btnDetayGoruntule);
            this.Controls.Add(this.txSiparisID);
            this.Controls.Add(this.pictureKapat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblToplam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKasiyerPanel";
            this.Text = "KasiyerPanel";
            this.Load += new System.EventHandler(this.frmKasiyerPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSiparisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAltaAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureKapat;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox txSiparisID;
        private System.Windows.Forms.Button btnDetayGoruntule;
        private System.Windows.Forms.PictureBox pictureAltaAl;
        private System.Windows.Forms.PictureBox pictureGeri;
    }
}