namespace Restoran.Kasiyer
{
    partial class frmKasiyerUrunDetayPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasiyerUrunDetayPanel));
            this.pictureKapat = new System.Windows.Forms.PictureBox();
            this.dtgvSiparisDetay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSiparisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureKapat
            // 
            this.pictureKapat.BackColor = System.Drawing.Color.Transparent;
            this.pictureKapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureKapat.Image")));
            this.pictureKapat.Location = new System.Drawing.Point(389, 12);
            this.pictureKapat.Name = "pictureKapat";
            this.pictureKapat.Size = new System.Drawing.Size(50, 40);
            this.pictureKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKapat.TabIndex = 26;
            this.pictureKapat.TabStop = false;
            this.pictureKapat.Click += new System.EventHandler(this.pictureKapat_Click);
            // 
            // dtgvSiparisDetay
            // 
            this.dtgvSiparisDetay.AllowUserToAddRows = false;
            this.dtgvSiparisDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSiparisDetay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.dtgvSiparisDetay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSiparisDetay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(192)))));
            this.dtgvSiparisDetay.Location = new System.Drawing.Point(0, 74);
            this.dtgvSiparisDetay.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvSiparisDetay.Name = "dtgvSiparisDetay";
            this.dtgvSiparisDetay.ReadOnly = true;
            this.dtgvSiparisDetay.RowHeadersWidth = 51;
            this.dtgvSiparisDetay.RowTemplate.Height = 24;
            this.dtgvSiparisDetay.Size = new System.Drawing.Size(453, 200);
            this.dtgvSiparisDetay.TabIndex = 27;
            // 
            // frmKasiyerUrunDetayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 273);
            this.Controls.Add(this.dtgvSiparisDetay);
            this.Controls.Add(this.pictureKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasiyerUrunDetayPanel";
            this.Text = "frmKasiyerUrunDetayPanel";
            this.Load += new System.EventHandler(this.frmKasiyerUrunDetayPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSiparisDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureKapat;
        public System.Windows.Forms.DataGridView dtgvSiparisDetay;
    }
}