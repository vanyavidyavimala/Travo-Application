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
    public partial class formsignup : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formlogin formkedua;
        public Formhome formketiga;
        public FormWT formkeempat;
        public FormSS formkelima;
        public FormTU formkeenam;
        public FormP formketujuh;
        public FormPT formkedelapan;
        public Formdestinasi formkesembilan;
        public static string emailpelanggan;
        public formsignup()
        {
            InitializeComponent();
            tbpasswordformsignup.PasswordChar = '*';
        }



        private void btsignupawal_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable hasil = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "select email_pelanggan as `email` from pelanggan where email_pelanggan = '" + tbemailformsignup.Text.ToString() + "';";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(hasil);
                if (tbemailformsignup.Text != "")
                {
                    if (Regex.Match(tbemailformsignup.Text, @"^[0-9A-Za-z]+[+-_.]{0,1}[0-9A-Za-z]+[@]{1}[a-z]+[.]{1}[a-z]{3}").Success)
                    {
                        if (hasil.Rows.Count == 0)
                        {
                            if (tbnotelp.Text != "")
                            {
                                if (Regex.Match(tbnotelp.Text, @"^[0]{1}[0-9]{10,13}$").Success)
                                {
                                    if (tbnamaformsignup.Text != "")
                                    {
                                        if (tbpasswordformsignup.Text != "")
                                        {
                                            if (cbkewarganegaraan.SelectedIndex.ToString() != "-1")
                                            {
                                                DataTable signup = new DataTable();
                                                sqlConnect = new MySqlConnection(stringConnect);
                                                string hurufdepan = tbnamaformsignup.Text.ToString().Substring(0, 1);
                                                query = "select * from pelanggan where nama_pelanggan like '" + hurufdepan + "%';";
                                                sqlCommand = new MySqlCommand(query, sqlConnect);
                                                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                                                sqlAdapter.Fill(signup);
                                                int nomor = signup.Rows.Count + 1;
                                                String idpelanggan = hurufdepan + nomor.ToString();
                                                string queryy = "insert into travo.pelanggan values ('" + idpelanggan + "','" + tbemailformsignup.Text.ToString() + "','" + tbnotelp.Text.ToString() + "','" + cbkewarganegaraan.SelectedItem.ToString() + "','" + tbnamaformsignup.Text.ToString() + "','" + tbpasswordformsignup.Text.ToString() + "',0)";
                                                sqlCommand = new MySqlCommand(queryy, sqlConnect);
                                                sqlConnect.Open();
                                                sqlCommand.ExecuteNonQuery();
                                                sqlConnect.Close();
                                                emailpelanggan = tbemailformsignup.Text;
                                                MessageBox.Show("data telah masuk");
                                                Formhome datalogin = new Formhome();
                                                datalogin.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Belum memilih negara");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("kosong Passwordnya");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kosong Namanya");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("bukan nomor telphone");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Masukkan nomor telphone");
                            }
                        }
                        else
                        {
                            if (hasil.Rows[0]["email"].ToString() == tbemailformsignup.Text.ToString())
                            {
                                MessageBox.Show("Email Sudah Digunakan");
                            }
                            else
                            {
                                MessageBox.Show("Email Sudah Digunakan");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("salah memasukkan email");
                    }
                }
                else
                {
                    MessageBox.Show("kosong emailnya");
                }
            
            }
            
            catch (Exception ex)
            {
                sqlConnect.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void formsignup_Load(object sender, EventArgs e)
        {

        }

        private void btloginawal_Click(object sender, EventArgs e)
        {
            Formlogin datasignup = new Formlogin();
            datasignup.Show();
            this.Hide();
        }

        private void tbnamaformsignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnamaformsignup_keypress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
