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
using System.Text.RegularExpressions;
namespace travo
{
    public partial class Formlogin : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlAdapter;
        string SqlQuery = "";
        string connectString = "server=localhost;uid=root;pwd=;database=travo;";
        public formsignup formpertama;
        public FormAdminDaerah formsepuluh;
        public FormAdminKategori formsebelas;
        public FormAdminPaketTour formduabelas;
        public FormAdminPelanggan formtigabelas;
        public Formlogin()
        {
            InitializeComponent();
            tbpasswordformlogin.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btloginformlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable hasil = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                SqlQuery = "select email_pelanggan as `email`, `password` as `pass` from pelanggan where email_pelanggan = '" + tbemailformlogin.Text.ToString() + "' and  `password`= '" + tbpasswordformlogin.Text.ToString() + "';";
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlAdapter = new MySqlDataAdapter(SqlCommand);
                SqlAdapter.Fill(hasil);
                if (tbemailformlogin.Text != "")
                {
                    if (Regex.Match(tbemailformlogin.Text, @"^[0-9A-Za-z]+[+-_.]{0,1}[0-9A-Za-z]+[@]{1}[a-z]+[.]{1}[a-z]{3}").Success)
                    {
                        if (hasil.Rows.Count == 1)
                        {
                            if (hasil.Rows[0]["email"].ToString() == tbemailformlogin.Text.ToString())
                            {
                                if (hasil.Rows[0]["pass"].ToString() == tbpasswordformlogin.Text.ToString())
                                {
                                    formsignup.emailpelanggan = tbemailformlogin.Text;
                                    Formhome datalogin = new Formhome();
                                    datalogin.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email Belum terdaftar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("email salah");
                    }
                }
                else
                {
                    MessageBox.Show("isiin email");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btsignupformlogin_Click(object sender, EventArgs e)
        {
            formsignup datalogin = new formsignup();
            datalogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formloginadmin dataadmin = new formloginadmin();
            dataadmin.Show();
            this.Hide();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
