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
    public partial class Ftransaksipemesanan : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;

        public FormAdminPelanggan formtigabelas;
      
        public Formadmin formenambelas;
        public Ftransaksipemesanan()
        {
            InitializeComponent();
        }

        private void Finsertpelanggan_Load(object sender, EventArgs e)
        {
            DataTable dttransaksi = new DataTable();
            sqlConnect = new MySqlConnection(stringConnect);
            query = "SELECT ID_TRANSAKSI as `ID Transaksi`,ID_PELANGGAN as `ID Pelanggan`,TANGGAL_TRANSAKSI as `Tgl Transaksi`,TOTAL_TRANSAKSI AS `Total transaksi`,DELETE_TRANSAKSI as `Delete` FROM transaksi_pemesanan";
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dttransaksi);
            dataGridView1.DataSource = dttransaksi;
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtadmin = new Formadmin();
            dtadmin.formenambelas = this;
            dtadmin.Show();
            this.Hide();
        }
    }
}
