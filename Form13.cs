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
    public partial class FormAdminPelanggan : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formadmin formempatbelas;
        string id = "";
        int rowsCount = 0;
        public FormAdminPelanggan()
        {
            InitializeComponent();
        }

        private void FormAdminPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtpelanggan = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_PELANGGAN as `Id Pelanggan`,EMAIL_PELANGGAN as `Email`,NO_TELPHONE as `No Telp`,KEWARGANEGARAAN as `Kewarganegaraan`,NAMA_PELANGGAN as `Nama Pelanggan`,PASSWORD as `Password`,DELETE_PELANGGAN as `Delete` FROM pelanggan ";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpelanggan);
                dataGridView1.DataSource = dtpelanggan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void DGV_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Data belum dipilih !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
            dtback.formtigabelas = this;
            dtback.Show();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formtigabelas = this;
            dtlogin.Show();
            this.Hide();

        }

        private void tbnotelp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
