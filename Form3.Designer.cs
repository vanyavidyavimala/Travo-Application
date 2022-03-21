namespace travo
{
    partial class Formhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formhome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbwt = new System.Windows.Forms.PictureBox();
            this.pbss = new System.Windows.Forms.PictureBox();
            this.pbtu = new System.Windows.Forms.PictureBox();
            this.pbp = new System.Windows.Forms.PictureBox();
            this.pbpt = new System.Windows.Forms.PictureBox();
            this.btlogoutformhome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbwt
            // 
            this.pbwt.Image = ((System.Drawing.Image)(resources.GetObject("pbwt.Image")));
            this.pbwt.Location = new System.Drawing.Point(12, 231);
            this.pbwt.Name = "pbwt";
            this.pbwt.Size = new System.Drawing.Size(148, 110);
            this.pbwt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbwt.TabIndex = 1;
            this.pbwt.TabStop = false;
            this.pbwt.Click += new System.EventHandler(this.pbwt_Click);
            // 
            // pbss
            // 
            this.pbss.Image = ((System.Drawing.Image)(resources.GetObject("pbss.Image")));
            this.pbss.Location = new System.Drawing.Point(166, 231);
            this.pbss.Name = "pbss";
            this.pbss.Size = new System.Drawing.Size(149, 110);
            this.pbss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbss.TabIndex = 2;
            this.pbss.TabStop = false;
            this.pbss.Click += new System.EventHandler(this.pbss_Click);
            // 
            // pbtu
            // 
            this.pbtu.Image = ((System.Drawing.Image)(resources.GetObject("pbtu.Image")));
            this.pbtu.Location = new System.Drawing.Point(321, 231);
            this.pbtu.Name = "pbtu";
            this.pbtu.Size = new System.Drawing.Size(150, 110);
            this.pbtu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtu.TabIndex = 3;
            this.pbtu.TabStop = false;
            this.pbtu.Click += new System.EventHandler(this.pbtu_Click);
            // 
            // pbp
            // 
            this.pbp.Image = ((System.Drawing.Image)(resources.GetObject("pbp.Image")));
            this.pbp.Location = new System.Drawing.Point(477, 231);
            this.pbp.Name = "pbp";
            this.pbp.Size = new System.Drawing.Size(151, 110);
            this.pbp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbp.TabIndex = 4;
            this.pbp.TabStop = false;
            this.pbp.Click += new System.EventHandler(this.pbp_Click);
            // 
            // pbpt
            // 
            this.pbpt.Image = ((System.Drawing.Image)(resources.GetObject("pbpt.Image")));
            this.pbpt.Location = new System.Drawing.Point(634, 231);
            this.pbpt.Name = "pbpt";
            this.pbpt.Size = new System.Drawing.Size(151, 110);
            this.pbpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpt.TabIndex = 5;
            this.pbpt.TabStop = false;
            this.pbpt.Click += new System.EventHandler(this.pbpt_Click);
            // 
            // btlogoutformhome
            // 
            this.btlogoutformhome.BackColor = System.Drawing.Color.DarkCyan;
            this.btlogoutformhome.ForeColor = System.Drawing.SystemColors.Window;
            this.btlogoutformhome.Location = new System.Drawing.Point(679, 12);
            this.btlogoutformhome.Name = "btlogoutformhome";
            this.btlogoutformhome.Size = new System.Drawing.Size(109, 33);
            this.btlogoutformhome.TabIndex = 8;
            this.btlogoutformhome.Text = "Log Out";
            this.btlogoutformhome.UseVisualStyleBackColor = false;
            this.btlogoutformhome.Click += new System.EventHandler(this.btlogoutformhome_Click);
            // 
            // Formhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlogoutformhome);
            this.Controls.Add(this.pbpt);
            this.Controls.Add(this.pbp);
            this.Controls.Add(this.pbtu);
            this.Controls.Add(this.pbss);
            this.Controls.Add(this.pbwt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Formhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbwt;
        private System.Windows.Forms.PictureBox pbss;
        private System.Windows.Forms.PictureBox pbtu;
        private System.Windows.Forms.PictureBox pbp;
        private System.Windows.Forms.PictureBox pbpt;
        private System.Windows.Forms.Button btlogoutformhome;
    }
}