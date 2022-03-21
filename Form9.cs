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
using System.IO;

namespace travo
{
    public partial class Formdestinasi : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public FormWT formkeempat;
        public FormSS formkelima;
        public static string hargapaketsaja;
        public Formdestinasi()
        {
            InitializeComponent();
        }

        private void buttlogout_Click(object sender, EventArgs e)
        {
            Formlogin datalo = new Formlogin();
            
            datalo.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Formdestinasi_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FormWT.idpaket))
            {

            }
            else
            {
                DataTable detail = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "select NAMA_PAKET_TOUR,ID_PAKET_TOUR as `ID Paket`,foto,HARGA_TOUR_ORG,KETENTUAN,DETAIL from paket__tour where ID_PAKET_TOUR = '" + FormWT.idpaket + "';";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(detail);
                labnamadest.Text = detail.Rows[0]["NAMA_PAKET_TOUR"].ToString();
                labelketentuan.Text = detail.Rows[0]["KETENTUAN"].ToString();
                labeldeskripsi.Text = detail.Rows[0]["DETAIL"].ToString();
                byte[] img = (byte[])detail.Rows[0]["foto"];
                MemoryStream ms = new MemoryStream(img);
                pictureBoxdestinasi.Image = Image.FromStream(ms);
                sqlAdapter.Dispose();
                tbjumlah.Text = 1.ToString();
                int harga = Int32.Parse(tbjumlah.Text) * Int32.Parse(detail.Rows[0]["HARGA_TOUR_ORG"].ToString());
                labelhargatotal.Text = harga.ToString();
                tbjumlah.Enabled = false;
                hargapaketsaja = detail.Rows[0]["HARGA_TOUR_ORG"].ToString();
            }
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            DataTable detail = new DataTable();
            sqlConnect = new MySqlConnection(stringConnect);
            query = "select NAMA_PAKET_TOUR,ID_PAKET_TOUR as `ID Paket`,foto,HARGA_TOUR_ORG,KETENTUAN,DETAIL from paket__tour where ID_PAKET_TOUR = '" + FormWT.idpaket + "';";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(detail);
            int x = Int32.Parse(tbjumlah.Text);
            int total = x + 1;
            tbjumlah.Text = total.ToString();
            int harga = Int32.Parse(tbjumlah.Text) * Int32.Parse(detail.Rows[0]["HARGA_TOUR_ORG"].ToString());
            labelhargatotal.Text = harga.ToString();
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(tbjumlah.Text);
            DataTable detail = new DataTable();
            sqlConnect = new MySqlConnection(stringConnect);
            query = "select NAMA_PAKET_TOUR,ID_PAKET_TOUR as `ID Paket`,foto,HARGA_TOUR_ORG,KETENTUAN,DETAIL from paket__tour where ID_PAKET_TOUR = '" + FormWT.idpaket + "';";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(detail);
            if (tbjumlah.Text == 1.ToString())
            {
                tbjumlah.Text = 1.ToString();
                int harga = Int32.Parse(tbjumlah.Text) * Int32.Parse(detail.Rows[0]["HARGA_TOUR_ORG"].ToString());
                labelhargatotal.Text = harga.ToString();
            }
            else
            {
                int total = x - 1;
                tbjumlah.Text = total.ToString();
                int harga = Int32.Parse(tbjumlah.Text) * Int32.Parse(detail.Rows[0]["HARGA_TOUR_ORG"].ToString());
                labelhargatotal.Text = harga.ToString();
            }

        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formhome btback = new Formhome();
            
            btback.Show();
            this.Hide();
        }

        private void buttpesan_Click(object sender, EventArgs e)
        {
            DataTable id = new DataTable();
            sqlConnect = new MySqlConnection(stringConnect);
            query = "select id_pelanggan from pelanggan where EMAIL_PELANGGAN = '"+formsignup.emailpelanggan+"';";
            sqlCommand = new MySqlCommand(query,sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(id);
            string idtransaksi = "K"+id.Rows[0][0].ToString() + FormWT.idpaket;
            string query2 = "insert into transaksi_pemesanan value('"+idtransaksi+"','"+id.Rows[0]["id_pelanggan"].ToString()+"','"+this.dateTimePickertanggal.Text+"','"+labelhargatotal.Text.ToString()+"',0)";
            sqlCommand = new MySqlCommand(query2,sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            string query3 = "insert into transaksi_pemesanan_dan_paket_tour value('"+idtransaksi+"','"+FormWT.idpaket+"','"+Int32.Parse(tbjumlah.Text.ToString())+"','"+hargapaketsaja+"',0);";
            sqlCommand = new MySqlCommand(query3, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("berhasil memesan");
        }
    }
}
