namespace travo
{
    partial class FormAdminDaerah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDaerah));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btupdate = new System.Windows.Forms.Button();
            this.btinsert = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.labeldaerah = new System.Windows.Forms.Label();
            this.tbidupdate = new System.Windows.Forms.TextBox();
            this.tbdaerahupdate = new System.Windows.Forms.TextBox();
            this.tbkotaupdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tbidinsert = new System.Windows.Forms.TextBox();
            this.tbdaerahinsert = new System.Windows.Forms.TextBox();
            this.tbkotainsert = new System.Windows.Forms.TextBox();
            this.rbtrueinsert = new System.Windows.Forms.RadioButton();
            this.rbfalseinsert = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.cbnegara = new System.Windows.Forms.ComboBox();
            this.cbnegarainsert = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 193);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btupdate.Location = new System.Drawing.Point(719, 219);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btinsert
            // 
            this.btinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.btinsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btinsert.Location = new System.Drawing.Point(302, 215);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 3;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = false;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdelete.Location = new System.Drawing.Point(713, 415);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 4;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogout.Location = new System.Drawing.Point(706, 12);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(82, 26);
            this.btlogout.TabIndex = 5;
            this.btlogout.Text = "Log Out";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // labeldaerah
            // 
            this.labeldaerah.AutoSize = true;
            this.labeldaerah.BackColor = System.Drawing.Color.DarkCyan;
            this.labeldaerah.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldaerah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeldaerah.Location = new System.Drawing.Point(482, 6);
            this.labeldaerah.Name = "labeldaerah";
            this.labeldaerah.Size = new System.Drawing.Size(175, 55);
            this.labeldaerah.TabIndex = 6;
            this.labeldaerah.Text = "Daerah";
            // 
            // tbidupdate
            // 
            this.tbidupdate.Enabled = false;
            this.tbidupdate.Location = new System.Drawing.Point(556, 74);
            this.tbidupdate.Name = "tbidupdate";
            this.tbidupdate.Size = new System.Drawing.Size(157, 20);
            this.tbidupdate.TabIndex = 11;
            this.tbidupdate.TextChanged += new System.EventHandler(this.tbidupdate_TextChanged);
            // 
            // tbdaerahupdate
            // 
            this.tbdaerahupdate.Location = new System.Drawing.Point(556, 100);
            this.tbdaerahupdate.Name = "tbdaerahupdate";
            this.tbdaerahupdate.Size = new System.Drawing.Size(157, 20);
            this.tbdaerahupdate.TabIndex = 1;
            // 
            // tbkotaupdate
            // 
            this.tbkotaupdate.Location = new System.Drawing.Point(556, 131);
            this.tbkotaupdate.Name = "tbkotaupdate";
            this.tbkotaupdate.Size = new System.Drawing.Size(157, 20);
            this.tbkotaupdate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(22, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Daerah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(22, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nama Daerah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkCyan;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(22, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nama Kota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkCyan;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(22, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nama Negara";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(23, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Delete";
            // 
            // Tbidinsert
            // 
            this.Tbidinsert.Enabled = false;
            this.Tbidinsert.Location = new System.Drawing.Point(132, 72);
            this.Tbidinsert.Name = "Tbidinsert";
            this.Tbidinsert.Size = new System.Drawing.Size(157, 20);
            this.Tbidinsert.TabIndex = 22;
            this.Tbidinsert.TextChanged += new System.EventHandler(this.Tbidinsert_TextChanged);
            // 
            // tbdaerahinsert
            // 
            this.tbdaerahinsert.Location = new System.Drawing.Point(132, 97);
            this.tbdaerahinsert.Name = "tbdaerahinsert";
            this.tbdaerahinsert.Size = new System.Drawing.Size(157, 20);
            this.tbdaerahinsert.TabIndex = 2;
            // 
            // tbkotainsert
            // 
            this.tbkotainsert.Location = new System.Drawing.Point(132, 125);
            this.tbkotainsert.Name = "tbkotainsert";
            this.tbkotainsert.Size = new System.Drawing.Size(157, 20);
            this.tbkotainsert.TabIndex = 3;
            // 
            // rbtrueinsert
            // 
            this.rbtrueinsert.AutoSize = true;
            this.rbtrueinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.rbtrueinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtrueinsert.Location = new System.Drawing.Point(132, 185);
            this.rbtrueinsert.Name = "rbtrueinsert";
            this.rbtrueinsert.Size = new System.Drawing.Size(43, 17);
            this.rbtrueinsert.TabIndex = 26;
            this.rbtrueinsert.TabStop = true;
            this.rbtrueinsert.Text = "true";
            this.rbtrueinsert.UseVisualStyleBackColor = false;
            // 
            // rbfalseinsert
            // 
            this.rbfalseinsert.AutoSize = true;
            this.rbfalseinsert.BackColor = System.Drawing.Color.DarkCyan;
            this.rbfalseinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbfalseinsert.Location = new System.Drawing.Point(215, 185);
            this.rbfalseinsert.Name = "rbfalseinsert";
            this.rbfalseinsert.Size = new System.Drawing.Size(47, 17);
            this.rbfalseinsert.TabIndex = 27;
            this.rbfalseinsert.TabStop = true;
            this.rbfalseinsert.Text = "false";
            this.rbfalseinsert.UseVisualStyleBackColor = false;
            this.rbfalseinsert.CheckedChanged += new System.EventHandler(this.rbfalseinsert_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(428, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Daerah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(428, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nama Daerah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(428, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nama Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(428, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nama Negara";
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(666, 8);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(34, 31);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 35;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // cbnegara
            // 
            this.cbnegara.FormattingEnabled = true;
            this.cbnegara.Items.AddRange(new object[] {
            "Afganistan",
            "Afrika Selatan",
            "Afrika Tengah",
            "Albania",
            "Aljazair",
            "Amerika Serikat",
            "Andorra",
            "Angola",
            "Antigua dan Barbuda",
            "Arab Saudi",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahama",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belanda",
            "Belarus",
            "Belgia",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia dan Herzegovina",
            "Botswana",
            "Brasil",
            "Britania Raya",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Ceko",
            "Chad",
            "Chili",
            "China",
            "Denmark",
            "Djibouti",
            "Dominika",
            "Ekuador",
            "El Salvador",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Filipina",
            "Finlandia",
            "Gabon",
            "Gambia",
            "Georgia",
            "Ghana",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea Bissau",
            "Guinea Khatulistiwa",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hongaria",
            "India",
            "Indonesia",
            "Irak",
            "Iran",
            "Irlandia",
            "Islandia",
            "Israel",
            "Italia",
            "Jamaika",
            "Jepang",
            "Jerman",
            "Kamboja",
            "Kamerun",
            "Kanada",
            "Kazakhstan",
            "Kenya",
            "Kirgizstan",
            "Kiribati",
            "Kolombia",
            "Komoro",
            "Republik Kongo",
            "Korea Selatan",
            "Korea Utara",
            "Kosta Rika",
            "Kroasia",
            "Kuba",
            "Kuwait",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lituania",
            "Luksemburg",
            "Madagaskar",
            "Makedonia",
            "Maladewa",
            "Malawi",
            "Malaysia",
            "Mali",
            "Malta",
            "Maroko",
            "Marshall",
            "Mauritania",
            "Mauritius",
            "Meksiko",
            "Mesir",
            "Mikronesia",
            "Moldova",
            "Monako",
            "Mongolia",
            "Montenegro",
            "Mozambik",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Niger",
            "Nigeria",
            "Nikaragua",
            "Norwegia",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Pantai Gading",
            "Papua Nugini",
            "Paraguay",
            "Perancis",
            "Peru",
            "Polandia",
            "Portugal",
            "Qatar",
            "Republik Demokratik Kongo",
            "Republik Dominika",
            "Rumania",
            "Rusia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Selandia Baru",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapura",
            "Siprus",
            "Slovenia",
            "Slowakia",
            "Solomon",
            "Somalia",
            "Spanyol",
            "Sri Lanka",
            "Sudan",
            "Sudan Selatan",
            "Suriah",
            "Suriname",
            "Swaziland",
            "Swedia",
            "Swiss",
            "Tajikistan",
            "Tanjung Verde",
            "Tanzania",
            "Thailand",
            "Timor Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turki",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraina",
            "Uni Emirat Arab",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yaman",
            "Yordania",
            "Yunani",
            "Zambia",
            "Zimbabwe"});
            this.cbnegara.Location = new System.Drawing.Point(556, 164);
            this.cbnegara.Name = "cbnegara";
            this.cbnegara.Size = new System.Drawing.Size(121, 21);
            this.cbnegara.TabIndex = 36;
            // 
            // cbnegarainsert
            // 
            this.cbnegarainsert.FormattingEnabled = true;
            this.cbnegarainsert.Items.AddRange(new object[] {
            "Afganistan",
            "Afrika Selatan",
            "Afrika Tengah",
            "Albania",
            "Aljazair",
            "Amerika Serikat",
            "Andorra",
            "Angola",
            "Antigua dan Barbuda",
            "Arab Saudi",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahama",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belanda",
            "Belarus",
            "Belgia",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia dan Herzegovina",
            "Botswana",
            "Brasil",
            "Britania Raya",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Ceko",
            "Chad",
            "Chili",
            "China",
            "Denmark",
            "Djibouti",
            "Dominika",
            "Ekuador",
            "El Salvador",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Filipina",
            "Finlandia",
            "Gabon",
            "Gambia",
            "Georgia",
            "Ghana",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea Bissau",
            "Guinea Khatulistiwa",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hongaria",
            "India",
            "Indonesia",
            "Irak",
            "Iran",
            "Irlandia",
            "Islandia",
            "Israel",
            "Italia",
            "Jamaika",
            "Jepang",
            "Jerman",
            "Kamboja",
            "Kamerun",
            "Kanada",
            "Kazakhstan",
            "Kenya",
            "Kirgizstan",
            "Kiribati",
            "Kolombia",
            "Komoro",
            "Republik Kongo",
            "Korea Selatan",
            "Korea Utara",
            "Kosta Rika",
            "Kroasia",
            "Kuba",
            "Kuwait",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lituania",
            "Luksemburg",
            "Madagaskar",
            "Makedonia",
            "Maladewa",
            "Malawi",
            "Malaysia",
            "Mali",
            "Malta",
            "Maroko",
            "Marshall",
            "Mauritania",
            "Mauritius",
            "Meksiko",
            "Mesir",
            "Mikronesia",
            "Moldova",
            "Monako",
            "Mongolia",
            "Montenegro",
            "Mozambik",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Niger",
            "Nigeria",
            "Nikaragua",
            "Norwegia",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Pantai Gading",
            "Papua Nugini",
            "Paraguay",
            "Perancis",
            "Peru",
            "Polandia",
            "Portugal",
            "Qatar",
            "Republik Demokratik Kongo",
            "Republik Dominika",
            "Rumania",
            "Rusia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Selandia Baru",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapura",
            "Siprus",
            "Slovenia",
            "Slowakia",
            "Solomon",
            "Somalia",
            "Spanyol",
            "Sri Lanka",
            "Sudan",
            "Sudan Selatan",
            "Suriah",
            "Suriname",
            "Swaziland",
            "Swedia",
            "Swiss",
            "Tajikistan",
            "Tanjung Verde",
            "Tanzania",
            "Thailand",
            "Timor Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turki",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraina",
            "Uni Emirat Arab",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yaman",
            "Yordania",
            "Yunani",
            "Zambia",
            "Zimbabwe"});
            this.cbnegarainsert.Location = new System.Drawing.Point(132, 152);
            this.cbnegarainsert.Name = "cbnegarainsert";
            this.cbnegarainsert.Size = new System.Drawing.Size(121, 21);
            this.cbnegarainsert.TabIndex = 37;
            // 
            // FormAdminDaerah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbnegarainsert);
            this.Controls.Add(this.cbnegara);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbfalseinsert);
            this.Controls.Add(this.rbtrueinsert);
            this.Controls.Add(this.tbkotainsert);
            this.Controls.Add(this.tbdaerahinsert);
            this.Controls.Add(this.Tbidinsert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbkotaupdate);
            this.Controls.Add(this.tbdaerahupdate);
            this.Controls.Add(this.tbidupdate);
            this.Controls.Add(this.labeldaerah);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAdminDaerah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travo";
            this.Load += new System.EventHandler(this.FormAdminDaerah_Load);
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
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Label labeldaerah;
        private System.Windows.Forms.TextBox tbidupdate;
        private System.Windows.Forms.TextBox tbdaerahupdate;
        private System.Windows.Forms.TextBox tbkotaupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tbidinsert;
        private System.Windows.Forms.TextBox tbdaerahinsert;
        private System.Windows.Forms.TextBox tbkotainsert;
        private System.Windows.Forms.RadioButton rbtrueinsert;
        private System.Windows.Forms.RadioButton rbfalseinsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.ComboBox cbnegara;
        private System.Windows.Forms.ComboBox cbnegarainsert;
    }
}