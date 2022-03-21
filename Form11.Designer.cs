namespace travo
{
    partial class FormAdminKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminKategori));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btupdate = new System.Windows.Forms.Button();
            this.btinsert = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.labelkategori = new System.Windows.Forms.Label();
            this.btlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbidupdate = new System.Windows.Forms.TextBox();
            this.tbdurasiupdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbinsert = new System.Windows.Forms.TextBox();
            this.tbdurasiinsert = new System.Windows.Forms.TextBox();
            this.tbkategorinsert = new System.Windows.Forms.TextBox();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbfalseinsert = new System.Windows.Forms.RadioButton();
            this.rbtrueinsert = new System.Windows.Forms.RadioButton();
            this.tbkategoriupdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(683, 197);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btupdate.Location = new System.Drawing.Point(707, 218);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 3;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btinsert
            // 
            this.btinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.btinsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btinsert.Location = new System.Drawing.Point(309, 215);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 4;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = false;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdelete.Location = new System.Drawing.Point(713, 409);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // labelkategori
            // 
            this.labelkategori.AutoSize = true;
            this.labelkategori.BackColor = System.Drawing.Color.DarkCyan;
            this.labelkategori.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelkategori.Location = new System.Drawing.Point(449, 5);
            this.labelkategori.Name = "labelkategori";
            this.labelkategori.Size = new System.Drawing.Size(205, 55);
            this.labelkategori.TabIndex = 7;
            this.labelkategori.Text = "Kategori";
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogout.Location = new System.Drawing.Point(706, 12);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(82, 26);
            this.btlogout.TabIndex = 8;
            this.btlogout.Text = "Log Out";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(432, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(431, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jenis Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(433, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Durasi";
            // 
            // tbidupdate
            // 
            this.tbidupdate.Enabled = false;
            this.tbidupdate.Location = new System.Drawing.Point(560, 78);
            this.tbidupdate.Name = "tbidupdate";
            this.tbidupdate.Size = new System.Drawing.Size(157, 20);
            this.tbidupdate.TabIndex = 13;
            this.tbidupdate.TextChanged += new System.EventHandler(this.tbidupdate_TextChanged);
            // 
            // tbdurasiupdate
            // 
            this.tbdurasiupdate.Location = new System.Drawing.Point(560, 150);
            this.tbdurasiupdate.Name = "tbdurasiupdate";
            this.tbdurasiupdate.Size = new System.Drawing.Size(157, 20);
            this.tbdurasiupdate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(32, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Jenis Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(30, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Durasi";
            // 
            // tbinsert
            // 
            this.tbinsert.Enabled = false;
            this.tbinsert.Location = new System.Drawing.Point(131, 80);
            this.tbinsert.Name = "tbinsert";
            this.tbinsert.Size = new System.Drawing.Size(157, 20);
            this.tbinsert.TabIndex = 22;
            // 
            // tbdurasiinsert
            // 
            this.tbdurasiinsert.Location = new System.Drawing.Point(131, 155);
            this.tbdurasiinsert.Name = "tbdurasiinsert";
            this.tbdurasiinsert.Size = new System.Drawing.Size(157, 20);
            this.tbdurasiinsert.TabIndex = 2;
            // 
            // tbkategorinsert
            // 
            this.tbkategorinsert.Location = new System.Drawing.Point(131, 119);
            this.tbkategorinsert.Name = "tbkategorinsert";
            this.tbkategorinsert.Size = new System.Drawing.Size(157, 20);
            this.tbkategorinsert.TabIndex = 1;
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(667, 12);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 36;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkCyan;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(30, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Delete";
            // 
            // rbfalseinsert
            // 
            this.rbfalseinsert.AutoSize = true;
            this.rbfalseinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.rbfalseinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbfalseinsert.Location = new System.Drawing.Point(224, 188);
            this.rbfalseinsert.Name = "rbfalseinsert";
            this.rbfalseinsert.Size = new System.Drawing.Size(47, 17);
            this.rbfalseinsert.TabIndex = 31;
            this.rbfalseinsert.TabStop = true;
            this.rbfalseinsert.Text = "false";
            this.rbfalseinsert.UseVisualStyleBackColor = false;
            // 
            // rbtrueinsert
            // 
            this.rbtrueinsert.AutoSize = true;
            this.rbtrueinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.rbtrueinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtrueinsert.Location = new System.Drawing.Point(151, 188);
            this.rbtrueinsert.Name = "rbtrueinsert";
            this.rbtrueinsert.Size = new System.Drawing.Size(43, 17);
            this.rbtrueinsert.TabIndex = 33;
            this.rbtrueinsert.TabStop = true;
            this.rbtrueinsert.Text = "true";
            this.rbtrueinsert.UseVisualStyleBackColor = false;
            // 
            // tbkategoriupdate
            // 
            this.tbkategoriupdate.Enabled = false;
            this.tbkategoriupdate.Location = new System.Drawing.Point(560, 114);
            this.tbkategoriupdate.Name = "tbkategoriupdate";
            this.tbkategoriupdate.Size = new System.Drawing.Size(157, 20);
            this.tbkategoriupdate.TabIndex = 37;
            // 
            // FormAdminKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbkategoriupdate);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.tbkategorinsert);
            this.Controls.Add(this.rbtrueinsert);
            this.Controls.Add(this.rbfalseinsert);
            this.Controls.Add(this.tbdurasiinsert);
            this.Controls.Add(this.tbinsert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbdurasiupdate);
            this.Controls.Add(this.tbidupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.labelkategori);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAdminKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travo";
            this.Load += new System.EventHandler(this.FormAdminKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label labelkategori;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbidupdate;
        private System.Windows.Forms.TextBox tbdurasiupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbinsert;
        private System.Windows.Forms.TextBox tbdurasiinsert;
        private System.Windows.Forms.TextBox tbkategorinsert;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbfalseinsert;
        private System.Windows.Forms.RadioButton rbtrueinsert;
        private System.Windows.Forms.TextBox tbkategoriupdate;
    }
}