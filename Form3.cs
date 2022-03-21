using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace travo
{
    public partial class Formhome : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlAdapter;
        string SqlQuery = "";
        string connectString = "server=localhost;uid=root;pwd=;database=travo;";
        public Formlogin formkedua;
        public FormWT formkeempat;
        public FormSS formkelima;
        public FormTU formkeenam;
        public FormP formketujuh;
        public FormPT formkedelapan;
        
        public Formhome()
        {
            InitializeComponent();
        }

        private void Formhome_Load(object sender, EventArgs e)
        {

        }

        private void pbwt_Click(object sender, EventArgs e)
        {
            FormWT datawt = new FormWT();
            
            datawt.Show();
            this.Hide();
        }

        private void pbss_Click(object sender, EventArgs e)
        {
            FormSS datass = new FormSS();
            
            datass.Show();
            this.Hide();
        }

        private void pbtu_Click(object sender, EventArgs e)
        {
            FormTU datatu = new FormTU();
            
            datatu.Show();
            this.Hide();
        }

        private void pbp_Click(object sender, EventArgs e)
        {
            FormP datap = new FormP();
            
            datap.Show();
            this.Hide();
        }

        private void pbpt_Click(object sender, EventArgs e)
        {
            FormPT datapt = new FormPT();
            
            datapt.Show();
            this.Hide();
        }

        
        private void btlogoutformhome_Click(object sender, EventArgs e)
        {
            Formlogin datalo = new Formlogin();
            
            datalo.Show();
            this.Hide();
        }

       
    }
}
