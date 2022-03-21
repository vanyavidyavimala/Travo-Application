namespace travo
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpasswordformlogin = new System.Windows.Forms.TextBox();
            this.btloginformlogin = new System.Windows.Forms.Button();
            this.tbemailformlogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btsignupformlogin = new System.Windows.Forms.Button();
            this.btadmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbpasswordformlogin
            // 
            this.tbpasswordformlogin.Location = new System.Drawing.Point(285, 265);
            this.tbpasswordformlogin.Name = "tbpasswordformlogin";
            this.tbpasswordformlogin.Size = new System.Drawing.Size(231, 20);
            this.tbpasswordformlogin.TabIndex = 2;
            // 
            // btloginformlogin
            // 
            this.btloginformlogin.BackColor = System.Drawing.SystemColors.Window;
            this.btloginformlogin.Location = new System.Drawing.Point(355, 319);
            this.btloginformlogin.Name = "btloginformlogin";
            this.btloginformlogin.Size = new System.Drawing.Size(97, 24);
            this.btloginformlogin.TabIndex = 3;
            this.btloginformlogin.Text = "Log In";
            this.btloginformlogin.UseVisualStyleBackColor = false;
            this.btloginformlogin.Click += new System.EventHandler(this.btloginformlogin_Click);
            // 
            // tbemailformlogin
            // 
            this.tbemailformlogin.Location = new System.Drawing.Point(285, 220);
            this.tbemailformlogin.Name = "tbemailformlogin";
            this.tbemailformlogin.Size = new System.Drawing.Size(231, 20);
            this.tbemailformlogin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(282, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alamat Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(284, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // btsignupformlogin
            // 
            this.btsignupformlogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btsignupformlogin.ForeColor = System.Drawing.SystemColors.Window;
            this.btsignupformlogin.Location = new System.Drawing.Point(690, 12);
            this.btsignupformlogin.Name = "btsignupformlogin";
            this.btsignupformlogin.Size = new System.Drawing.Size(85, 25);
            this.btsignupformlogin.TabIndex = 17;
            this.btsignupformlogin.Text = "Sign Up";
            this.btsignupformlogin.UseVisualStyleBackColor = false;
            this.btsignupformlogin.Click += new System.EventHandler(this.btsignupformlogin_Click);
            // 
            // btadmin
            // 
            this.btadmin.BackColor = System.Drawing.Color.Gold;
            this.btadmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btadmin.Location = new System.Drawing.Point(594, 12);
            this.btadmin.Name = "btadmin";
            this.btadmin.Size = new System.Drawing.Size(86, 25);
            this.btadmin.TabIndex = 18;
            this.btadmin.Text = "Admin";
            this.btadmin.UseVisualStyleBackColor = false;
            this.btadmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btadmin);
            this.Controls.Add(this.btsignupformlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbemailformlogin);
            this.Controls.Add(this.btloginformlogin);
            this.Controls.Add(this.tbpasswordformlogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Formlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbpasswordformlogin;
        private System.Windows.Forms.Button btloginformlogin;
        private System.Windows.Forms.TextBox tbemailformlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsignupformlogin;
        private System.Windows.Forms.Button btadmin;
    }
}