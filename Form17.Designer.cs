namespace travo
{
    partial class formloginadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formloginadmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbnamaadmin = new System.Windows.Forms.TextBox();
            this.tbpasswordadmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btloginadmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbnamaadmin
            // 
            this.tbnamaadmin.Location = new System.Drawing.Point(344, 231);
            this.tbnamaadmin.Name = "tbnamaadmin";
            this.tbnamaadmin.Size = new System.Drawing.Size(167, 20);
            this.tbnamaadmin.TabIndex = 1;
            // 
            // tbpasswordadmin
            // 
            this.tbpasswordadmin.Location = new System.Drawing.Point(344, 283);
            this.tbpasswordadmin.Name = "tbpasswordadmin";
            this.tbpasswordadmin.Size = new System.Drawing.Size(167, 20);
            this.tbpasswordadmin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(289, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(285, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btloginadmin
            // 
            this.btloginadmin.BackColor = System.Drawing.Color.DarkCyan;
            this.btloginadmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btloginadmin.Location = new System.Drawing.Point(348, 339);
            this.btloginadmin.Name = "btloginadmin";
            this.btloginadmin.Size = new System.Drawing.Size(110, 29);
            this.btloginadmin.TabIndex = 3;
            this.btloginadmin.Text = "Log In";
            this.btloginadmin.UseVisualStyleBackColor = false;
            this.btloginadmin.Click += new System.EventHandler(this.btloginadmin_Click);
            // 
            // formloginadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btloginadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpasswordadmin);
            this.Controls.Add(this.tbnamaadmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formloginadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Admin";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbnamaadmin;
        private System.Windows.Forms.TextBox tbpasswordadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btloginadmin;
    }
}