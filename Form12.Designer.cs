namespace travo
{
    partial class FormAdminPaketTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPaketTour));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbidpaket = new System.Windows.Forms.TextBox();
            this.tbdaerah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbkategori = new System.Windows.Forms.TextBox();
            this.tbnamapaket = new System.Windows.Forms.TextBox();
            this.tbketentuan = new System.Windows.Forms.TextBox();
            this.tbkendaraan = new System.Windows.Forms.TextBox();
            this.tbdetail = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.btfoto = new System.Windows.Forms.Button();
            this.btinsert = new System.Windows.Forms.Button();
            this.rbtrueupdate = new System.Windows.Forms.RadioButton();
            this.rbfalseupdate = new System.Windows.Forms.RadioButton();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.labelpaketour = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(510, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_cellclick);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btupdate.Location = new System.Drawing.Point(707, 415);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 4;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdelete.Location = new System.Drawing.Point(542, 415);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 6;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogout.Location = new System.Drawing.Point(704, 12);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(82, 26);
            this.btlogout.TabIndex = 9;
            this.btlogout.Text = "Log Out";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(542, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Paket Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(542, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Daerah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(542, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(535, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nama Paket Tour";
            // 
            // tbidpaket
            // 
            this.tbidpaket.Enabled = false;
            this.tbidpaket.Location = new System.Drawing.Point(641, 56);
            this.tbidpaket.Name = "tbidpaket";
            this.tbidpaket.Size = new System.Drawing.Size(145, 20);
            this.tbidpaket.TabIndex = 14;
            // 
            // tbdaerah
            // 
            this.tbdaerah.Enabled = false;
            this.tbdaerah.Location = new System.Drawing.Point(641, 85);
            this.tbdaerah.Name = "tbdaerah";
            this.tbdaerah.Size = new System.Drawing.Size(145, 20);
            this.tbdaerah.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(538, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ketentuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(539, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kendaraan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(543, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkCyan;
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(544, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Harga";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(544, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Delete";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkCyan;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(543, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Foto";
            // 
            // tbkategori
            // 
            this.tbkategori.Enabled = false;
            this.tbkategori.Location = new System.Drawing.Point(639, 114);
            this.tbkategori.Name = "tbkategori";
            this.tbkategori.Size = new System.Drawing.Size(147, 20);
            this.tbkategori.TabIndex = 23;
            // 
            // tbnamapaket
            // 
            this.tbnamapaket.Location = new System.Drawing.Point(633, 142);
            this.tbnamapaket.Name = "tbnamapaket";
            this.tbnamapaket.Size = new System.Drawing.Size(155, 20);
            this.tbnamapaket.TabIndex = 1;
            // 
            // tbketentuan
            // 
            this.tbketentuan.Location = new System.Drawing.Point(610, 171);
            this.tbketentuan.Multiline = true;
            this.tbketentuan.Name = "tbketentuan";
            this.tbketentuan.Size = new System.Drawing.Size(177, 29);
            this.tbketentuan.TabIndex = 2;
            // 
            // tbkendaraan
            // 
            this.tbkendaraan.Location = new System.Drawing.Point(644, 218);
            this.tbkendaraan.Name = "tbkendaraan";
            this.tbkendaraan.Size = new System.Drawing.Size(142, 20);
            this.tbkendaraan.TabIndex = 3;
            // 
            // tbdetail
            // 
            this.tbdetail.Location = new System.Drawing.Point(603, 244);
            this.tbdetail.Multiline = true;
            this.tbdetail.Name = "tbdetail";
            this.tbdetail.Size = new System.Drawing.Size(185, 49);
            this.tbdetail.TabIndex = 4;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(646, 303);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(142, 20);
            this.tbharga.TabIndex = 5;
            // 
            // btfoto
            // 
            this.btfoto.BackColor = System.Drawing.Color.Gold;
            this.btfoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btfoto.Location = new System.Drawing.Point(541, 357);
            this.btfoto.Name = "btfoto";
            this.btfoto.Size = new System.Drawing.Size(75, 23);
            this.btfoto.TabIndex = 30;
            this.btfoto.Text = "Browse";
            this.btfoto.UseVisualStyleBackColor = false;
            this.btfoto.Click += new System.EventHandler(this.btfoto_Click);
            // 
            // btinsert
            // 
            this.btinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.btinsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btinsert.Location = new System.Drawing.Point(12, 47);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 31;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = false;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // rbtrueupdate
            // 
            this.rbtrueupdate.AutoSize = true;
            this.rbtrueupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.rbtrueupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtrueupdate.Location = new System.Drawing.Point(620, 397);
            this.rbtrueupdate.Name = "rbtrueupdate";
            this.rbtrueupdate.Size = new System.Drawing.Size(43, 17);
            this.rbtrueupdate.TabIndex = 32;
            this.rbtrueupdate.TabStop = true;
            this.rbtrueupdate.Text = "true";
            this.rbtrueupdate.UseVisualStyleBackColor = false;
            // 
            // rbfalseupdate
            // 
            this.rbfalseupdate.AutoSize = true;
            this.rbfalseupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.rbfalseupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbfalseupdate.Location = new System.Drawing.Point(680, 395);
            this.rbfalseupdate.Name = "rbfalseupdate";
            this.rbfalseupdate.Size = new System.Drawing.Size(47, 17);
            this.rbfalseupdate.TabIndex = 33;
            this.rbfalseupdate.TabStop = true;
            this.rbfalseupdate.Text = "false";
            this.rbfalseupdate.UseVisualStyleBackColor = false;
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(664, 10);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 34;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // labelpaketour
            // 
            this.labelpaketour.AutoSize = true;
            this.labelpaketour.BackColor = System.Drawing.Color.DarkCyan;
            this.labelpaketour.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaketour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelpaketour.Location = new System.Drawing.Point(397, 0);
            this.labelpaketour.Name = "labelpaketour";
            this.labelpaketour.Size = new System.Drawing.Size(251, 55);
            this.labelpaketour.TabIndex = 35;
            this.labelpaketour.Text = "Paket Tour";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(633, 336);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormAdminPaketTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelpaketour);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.rbfalseupdate);
            this.Controls.Add(this.rbtrueupdate);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btfoto);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.tbdetail);
            this.Controls.Add(this.tbkendaraan);
            this.Controls.Add(this.tbketentuan);
            this.Controls.Add(this.tbnamapaket);
            this.Controls.Add(this.tbkategori);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbdaerah);
            this.Controls.Add(this.tbidpaket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAdminPaketTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travo";
            this.Load += new System.EventHandler(this.FormAdminPaketTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbidpaket;
        private System.Windows.Forms.TextBox tbdaerah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbkategori;
        private System.Windows.Forms.TextBox tbnamapaket;
        private System.Windows.Forms.TextBox tbketentuan;
        private System.Windows.Forms.TextBox tbkendaraan;
        private System.Windows.Forms.TextBox tbdetail;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Button btfoto;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.RadioButton rbtrueupdate;
        private System.Windows.Forms.RadioButton rbfalseupdate;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.Label labelpaketour;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}