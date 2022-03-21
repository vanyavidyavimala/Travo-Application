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
    public partial class FormAdminKategori : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlAdapter;
        string SqlQuery = "";
        string connectString = "server=localhost;uid=root;pwd=;database=travo;";
        public Formadmin formempatbelas;
        DataTable dtkategori = new DataTable();
        DataTable dtdurasi = new DataTable();
        DataTable Dtkategoriupdate = new DataTable();
        DataTable Dtdurasiupdate = new DataTable();
        string id = "";
        int rowsCount = 0;
        public FormAdminKategori()
        {
            InitializeComponent();
        }

        private void FormAdminKategori_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtawal = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                SqlQuery = "SELECT ID_KATEGORI as `ID Kategori`,JENIS_KATEGORI as `Jenis Kategori`,DURASI_KATEGORI as `Durasi`,DELETE_KATEGORI as `Delete` FROM kategori";
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlAdapter = new MySqlDataAdapter(SqlCommand);
                SqlAdapter.Fill(dtawal);
                dataGridView1.DataSource = dtawal;
                sqlConnect = new MySqlConnection(connectString);
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbkategorinsert.Text != "")
                {
                    DataTable dtCount = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    SqlQuery = "SELECT * FROM kategori WHERE JENIS_KATEGORI LIKE '" + tbkategorinsert.Text.Substring(0, 1) + "%';";
                    SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                    SqlAdapter = new MySqlDataAdapter(SqlCommand);
                    SqlAdapter.Fill(dtCount);
                    rowsCount = dtCount.Rows.Count;

                    id = tbkategorinsert.Text.Substring(0, 1).ToUpper();
                    tbinsert.Text = id;
                }
                if (tbkategorinsert.Text != "")
                {
                    if (tbdurasiinsert.Text != "")
                    {
                        SqlQuery = "INSERT INTO kategori VALUES('" + id + "','" + tbkategorinsert.Text + "','" + tbdurasiinsert.Text + "',0)";
                        sqlConnect = new MySqlConnection(connectString);
                        SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                        sqlConnect.Open();
                        SqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil di Input");

                        sqlConnect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Durasi Harus Diisi");
                    }
                }
                else
                {
                    MessageBox.Show("Jenis Kategori Harus Diisi");
                }
                DataTable dtawal = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                SqlQuery = "SELECT ID_KATEGORI as `ID Kategori`,JENIS_KATEGORI as `Jenis Kategori`,DURASI_KATEGORI as `Durasi`,DELETE_KATEGORI as `Delete` FROM kategori";
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlAdapter = new MySqlDataAdapter(SqlCommand);
                SqlAdapter.Fill(dtawal);
                dataGridView1.DataSource = dtawal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void daerah()
        {

            DataTable dtdaerah = new DataTable();
            SqlQuery = "SELECT * FROM kategori";
            sqlConnect = new MySqlConnection(connectString);
            SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
            SqlAdapter = new MySqlDataAdapter(SqlCommand);
            SqlAdapter.Fill(dtdaerah);
            SqlCommand.ExecuteNonQuery();
            dataGridView1.DataSource = dtdaerah;
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbdurasiupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbkategoriupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlQuery = "UPDATE kategori SET  JENIS_KATEGORI = '" + tbkategoriupdate.Text.ToString() + "', DURASI_KATEGORI ='" + tbdurasiupdate.Text.ToString() + "',DELETE_KATEGORI = 0 WHERE ID_KATEGORI = '" + tbidupdate.Text.ToString() + "';";
                MessageBox.Show(SqlQuery);
                sqlConnect = new MySqlConnection(connectString);
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                sqlConnect.Open();
                SqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Update");

                DataTable dtawal = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                SqlQuery = "SELECT ID_KATEGORI as `ID Kategori`,JENIS_KATEGORI as `Jenis Kategori`,DURASI_KATEGORI as `Durasi`,DELETE_KATEGORI as `Delete` FROM kategori";
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlAdapter = new MySqlDataAdapter(SqlCommand);
                SqlAdapter.Fill(dtawal);
                dataGridView1.DataSource = dtawal;

            }
            catch (Exception ex)
            {
                sqlConnect.Close();
                MessageBox.Show(ex.Message);

            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlQuery = "DELETE FROM kategori WHERE ID_KATEGORI = '" + tbidupdate.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(connectString);
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                sqlConnect.Open();
                SqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Delete");

                DataTable dtawal = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                SqlQuery = "SELECT ID_KATEGORI as `ID Kategori`,JENIS_KATEGORI as `Jenis Kategori`,DURASI_KATEGORI as `Durasi`,DELETE_KATEGORI as `Delete` FROM kategori";
                SqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlAdapter = new MySqlDataAdapter(SqlCommand);
                SqlAdapter.Fill(dtawal);
                dataGridView1.DataSource = dtawal;

               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
            dtback.formsebelas = this;
            dtback.Show();
            this.Hide();

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formsebelas = this;
            dtlogin.Show();
            this.Hide();

        }

        private void tbidupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbkategoriupdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
