namespace travo
{
    partial class Ftransaksipemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ftransaksipemesanan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeltransaksi = new System.Windows.Forms.Label();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labeltransaksi
            // 
            this.labeltransaksi.AutoSize = true;
            this.labeltransaksi.BackColor = System.Drawing.Color.DarkCyan;
            this.labeltransaksi.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltransaksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltransaksi.Location = new System.Drawing.Point(396, 1);
            this.labeltransaksi.Name = "labeltransaksi";
            this.labeltransaksi.Size = new System.Drawing.Size(359, 42);
            this.labeltransaksi.TabIndex = 30;
            this.labeltransaksi.Text = "Transaksi Pemesanan";
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(761, 6);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 31;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(784, 324);
            this.dataGridView1.TabIndex = 32;
            // 
            // Ftransaksipemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.labeltransaksi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ftransaksipemesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Finsertpelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltransaksi;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}