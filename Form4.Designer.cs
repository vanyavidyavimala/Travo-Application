namespace travo
{
    partial class FormWT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWT));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.buttlogout = new System.Windows.Forms.Button();
            this.cbnegara = new System.Windows.Forms.ComboBox();
            this.cbdaerah = new System.Windows.Forms.ComboBox();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.panelpaket = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbsearch
            // 
            this.tbsearch.BackColor = System.Drawing.Color.DarkCyan;
            this.tbsearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbsearch.Location = new System.Drawing.Point(165, 18);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(208, 20);
            this.tbsearch.TabIndex = 1;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // buttlogout
            // 
            this.buttlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.buttlogout.ForeColor = System.Drawing.SystemColors.Window;
            this.buttlogout.Location = new System.Drawing.Point(683, 12);
            this.buttlogout.Name = "buttlogout";
            this.buttlogout.Size = new System.Drawing.Size(105, 32);
            this.buttlogout.TabIndex = 2;
            this.buttlogout.Text = "Log Out";
            this.buttlogout.UseVisualStyleBackColor = false;
            this.buttlogout.Click += new System.EventHandler(this.buttlogout_Click);
            // 
            // cbnegara
            // 
            this.cbnegara.BackColor = System.Drawing.Color.DarkCyan;
            this.cbnegara.ForeColor = System.Drawing.SystemColors.Window;
            this.cbnegara.FormattingEnabled = true;
            this.cbnegara.Items.AddRange(new object[] {
            "Indonesia",
            "Jepang",
            "Thailand"});
            this.cbnegara.Location = new System.Drawing.Point(453, 206);
            this.cbnegara.Name = "cbnegara";
            this.cbnegara.Size = new System.Drawing.Size(154, 21);
            this.cbnegara.TabIndex = 3;
            this.cbnegara.Text = "Negara";
            this.cbnegara.SelectedValueChanged += new System.EventHandler(this.cbnegara_SelectedValueChanged);
            // 
            // cbdaerah
            // 
            this.cbdaerah.BackColor = System.Drawing.Color.DarkCyan;
            this.cbdaerah.ForeColor = System.Drawing.SystemColors.Window;
            this.cbdaerah.FormattingEnabled = true;
            this.cbdaerah.Items.AddRange(new object[] {
            "Bali",
            "Yogyakarta",
            "Labuan Bajo",
            "Tokyo",
            "Kyoto",
            "Osaka",
            "Bangkok",
            "Hua Hin",
            "Phuket"});
            this.cbdaerah.Location = new System.Drawing.Point(625, 206);
            this.cbdaerah.Name = "cbdaerah";
            this.cbdaerah.Size = new System.Drawing.Size(154, 21);
            this.cbdaerah.TabIndex = 4;
            this.cbdaerah.Text = "Daerah";
            this.cbdaerah.SelectedValueChanged += new System.EventHandler(this.cbdaerah_SelectedValueChanged);
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(641, 13);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 9;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // panelpaket
            // 
            this.panelpaket.BackColor = System.Drawing.Color.DarkCyan;
            this.panelpaket.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelpaket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelpaket.Location = new System.Drawing.Point(20, 229);
            this.panelpaket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelpaket.Name = "panelpaket";
            this.panelpaket.Size = new System.Drawing.Size(758, 213);
            this.panelpaket.TabIndex = 10;
            // 
            // FormWT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelpaket);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.cbdaerah);
            this.Controls.Add(this.cbnegara);
            this.Controls.Add(this.buttlogout);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormWT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walking Tour and Bike Tour";
            this.Load += new System.EventHandler(this.FormWT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button buttlogout;
        private System.Windows.Forms.ComboBox cbnegara;
        private System.Windows.Forms.ComboBox cbdaerah;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.FlowLayoutPanel panelpaket;
    }
}