namespace travo
{
    partial class Formadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formadmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btdaerah = new System.Windows.Forms.Button();
            this.btkategori = new System.Windows.Forms.Button();
            this.btpakettour = new System.Windows.Forms.Button();
            this.btpelanggan = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.bttransaksipemesanan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btdaerah
            // 
            this.btdaerah.BackColor = System.Drawing.Color.DarkCyan;
            this.btdaerah.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdaerah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdaerah.Location = new System.Drawing.Point(289, 97);
            this.btdaerah.Name = "btdaerah";
            this.btdaerah.Size = new System.Drawing.Size(220, 30);
            this.btdaerah.TabIndex = 1;
            this.btdaerah.Text = "Daerah";
            this.btdaerah.UseVisualStyleBackColor = false;
            this.btdaerah.Click += new System.EventHandler(this.btdaerah_Click);
            // 
            // btkategori
            // 
            this.btkategori.BackColor = System.Drawing.Color.DarkCyan;
            this.btkategori.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btkategori.Location = new System.Drawing.Point(290, 151);
            this.btkategori.Name = "btkategori";
            this.btkategori.Size = new System.Drawing.Size(220, 30);
            this.btkategori.TabIndex = 2;
            this.btkategori.Text = "Kategori";
            this.btkategori.UseVisualStyleBackColor = false;
            this.btkategori.Click += new System.EventHandler(this.btkategori_Click);
            // 
            // btpakettour
            // 
            this.btpakettour.BackColor = System.Drawing.Color.DarkCyan;
            this.btpakettour.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpakettour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btpakettour.Location = new System.Drawing.Point(292, 209);
            this.btpakettour.Name = "btpakettour";
            this.btpakettour.Size = new System.Drawing.Size(220, 30);
            this.btpakettour.TabIndex = 3;
            this.btpakettour.Text = "Paket Tour";
            this.btpakettour.UseVisualStyleBackColor = false;
            this.btpakettour.Click += new System.EventHandler(this.btpakettour_Click);
            // 
            // btpelanggan
            // 
            this.btpelanggan.BackColor = System.Drawing.Color.DarkCyan;
            this.btpelanggan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btpelanggan.Location = new System.Drawing.Point(290, 268);
            this.btpelanggan.Name = "btpelanggan";
            this.btpelanggan.Size = new System.Drawing.Size(220, 30);
            this.btpelanggan.TabIndex = 4;
            this.btpelanggan.Text = "Pelanggan";
            this.btpelanggan.UseVisualStyleBackColor = false;
            this.btpelanggan.Click += new System.EventHandler(this.btpelanggan_Click);
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogout.Location = new System.Drawing.Point(706, 12);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(82, 26);
            this.btlogout.TabIndex = 10;
            this.btlogout.Text = "Log Out";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(666, 9);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 11;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // bttransaksipemesanan
            // 
            this.bttransaksipemesanan.BackColor = System.Drawing.Color.DarkCyan;
            this.bttransaksipemesanan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttransaksipemesanan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttransaksipemesanan.Location = new System.Drawing.Point(290, 328);
            this.bttransaksipemesanan.Name = "bttransaksipemesanan";
            this.bttransaksipemesanan.Size = new System.Drawing.Size(220, 30);
            this.bttransaksipemesanan.TabIndex = 12;
            this.bttransaksipemesanan.Text = "Transaksi Pemesanan";
            this.bttransaksipemesanan.UseVisualStyleBackColor = false;
            this.bttransaksipemesanan.Click += new System.EventHandler(this.bttransaksipemesanan_Click);
            // 
            // Formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttransaksipemesanan);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.btpelanggan);
            this.Controls.Add(this.btpakettour);
            this.Controls.Add(this.btkategori);
            this.Controls.Add(this.btdaerah);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Formadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btdaerah;
        private System.Windows.Forms.Button btkategori;
        private System.Windows.Forms.Button btpakettour;
        private System.Windows.Forms.Button btpelanggan;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.Button bttransaksipemesanan;
    }
}