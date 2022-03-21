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
    public partial class FormAdminDaerah : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formadmin formempatbelas;
        DataTable dtNat = new DataTable();
        DataTable dtCount = new DataTable();
        DataTable dtCountdaerah = new DataTable();
        
        string id = "";
        int rowsCount = 0;
        public static string id_click;
        public Boolean inscek = true;
        public FormAdminDaerah()
        {
            InitializeComponent();
        }

        private void FormAdminDaerah_Load(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_PELANGGAN as `DELETE` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;

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

                if (cbnegarainsert.SelectedIndex.ToString() != "")
                {
                    dtCount = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM daerah WHERE NAMA_NEGARA LIKE '" + cbnegarainsert.Text.Substring(0, 1) + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCount);
                    dtCountdaerah = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM daerah WHERE NAMA_DAERAH LIKE '" + tbdaerahinsert.Text.Substring(0, 1) + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCountdaerah);
                    rowsCount = dtCountdaerah.Rows.Count;
                    rowsCount++;

                    string nol = "";
                    if (rowsCount < 1)
                    {
                        nol += "0";
                    }
                    id = cbnegarainsert.Text.Substring(0, 1).ToUpper() + tbdaerahinsert.Text.Substring(0, 1).ToUpper() + nol + rowsCount.ToString();
                    Tbidinsert.Text = id;
                }
                if (tbdaerahinsert.Text != "")
                {
                    if (tbkotainsert.Text != "")
                    {
                        if (cbnegarainsert.SelectedIndex.ToString() != "-1")
                        {
                            query = "INSERT INTO daerah VALUES('" + id + "','" + tbdaerahinsert.Text + "','" + cbnegarainsert.SelectedItem.ToString() + "','" + tbkotainsert.Text + "',DELETE_PELANGGAN = 0)";
                            sqlConnect = new MySqlConnection(stringConnect);
                            sqlCommand = new MySqlCommand(query, sqlConnect);
                            sqlConnect.Open();
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Data berhasil di Input");

                            sqlConnect.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nama Negara Harus Diisi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nama Kota Harus Diisi");
                    }
                }
                else
                {
                    MessageBox.Show("Nama Daerah Harus Diisi");
                }


                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_PELANGGAN as `Delete` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;
            }
            catch (Exception ex)
            {
                sqlConnect.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void tbnamanegara_TextChanged(object sender, EventArgs e)
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
                query = "DELETE FROM daerah WHERE ID_DAERAH = '" + tbidupdate.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Delete");

                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_PELANGGAN as `Delete` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbdaerahupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbkotaupdate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbnegara.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                query = "UPDATE daerah SET NAMA_DAERAH = '" + tbdaerahupdate.Text.ToString() + "', NAMA_NEGARA ='" + cbnegara.SelectedItem.ToString() + "', NAMA_KOTA ='" + tbkotaupdate.Text.ToString() + "',DELETE_PELANGGAN = 0 WHERE ID_DAERAH = '" + tbidupdate.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Update");

                DataTable dtdaerah = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_DAERAH as `ID Daerah`,NAMA_DAERAH as `Nama Daerah`,NAMA_NEGARA as `Nama Negara`,NAMA_KOTA as `Nama Kota`,DELETE_PELANGGAN as `Delete` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                dataGridView1.DataSource = dtdaerah;
            }
            catch (Exception ex)
            {

                sqlConnect.Close();
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void rbfalseinsert_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
           dtback.formsepuluh = this;
           dtback.Show();
            this.Hide();

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formsepuluh = this;
            dtlogin.Show();
            this.Hide();
        }

        private void tbidupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbidinsert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
