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
    public partial class FormAdminPaketTour : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formadmin formempatbelas;
        public Finsertpakettour formlimabelas;
        FileStream fs;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        BinaryReader br;
        public FormAdminPaketTour()
        {
            InitializeComponent();
        }

        private void FormAdminPaketTour_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtpaketour = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_PAKET_TOUR as `ID Paket Tour`,ID_DAERAH as `ID daerah`,ID_KATEGORI as `ID Kategori`,NAMA_PAKET_TOUR as `Nama Paket Tour`,KETENTUAN as `Ketentuan`,KENDARAAN as `Kendaraan`,DETAIL as `Detail`,HARGA_TOUR_ORG as `Harga Tour`,FOTO as `Foto`,DELETE_PELANGGAN as `Delete` FROM paket__tour";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpaketour);
                dataGridView1.DataSource = dtpaketour;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbidpaket.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               tbdaerah.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbnamapaket.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbketentuan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbkendaraan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbdetail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbharga.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            Finsertpakettour datainsertPT = new Finsertpakettour();
            datainsertPT.formduabelas = this;
            datainsertPT.Show();
            this.Hide();

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "DELETE FROM paket__tour WHERE ID_PAKET_TOUR = '" + tbidpaket.Text.ToString() + "';";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di Delete");

                DataTable dtpaketour = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_PAKET_TOUR as `ID Paket Tour`,ID_DAERAH as `ID daerah`,ID_KATEGORI as `ID Kategori`,NAMA_PAKET_TOUR as `Nama Paket Tour`,KETENTUAN as `Ketentuan`,KENDARAAN as `Kendaraan`,DETAIL as `Detail`,HARGA_TOUR_ORG as `Harga Tour`,FOTO as `Foto`,DELETE_PELANGGAN as `Delete` FROM paket__tour";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpaketour);
                dataGridView1.DataSource = dtpaketour;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formadmin dtback = new Formadmin();
            dtback.formduabelas = this;
            dtback.Show();
            this.Hide();

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Formlogin dtlogin = new Formlogin();
            dtlogin.formduabelas = this;
            dtlogin.Show();
            this.Hide();

        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files *.jpg| *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = openFileDialog1.FileName;
                byte[] ImageData;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                System.IO.BufferedStream bf = new BufferedStream(fs);
                byte[] buffer = new byte[bf.Length];
                bf.Read(buffer, 0, buffer.Length);

                //ImageData = br.ReadBytes((int)fs.Length);
                byte[] buffer_new = buffer;

                fs.Close();
                query = "UPDATE paket__tour SET ID_DAERAH = @Iddaerah, ID_KATEGORI = @Idkategori,NAMA_PAKET_TOUR =  @nama,KETENTUAN = @ketentuan,KENDARAAN = @kendaraan,DETAIL = @detail,HARGA_TOUR_ORG = @harga,FOTO = @foto WHERE ID_PAKET_TOUR = @Idpaket";
                sqlConnect = new MySqlConnection(stringConnect);
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(query, sqlConnect);

                
                sqlCommand.Parameters.Add("@Idpaket", MySqlDbType.VarChar, 30);
                sqlCommand.Parameters.Add("@Iddaerah", MySqlDbType.VarChar, 20);
                sqlCommand.Parameters.Add("@Idkategori", MySqlDbType.VarChar, 30);
                sqlCommand.Parameters.Add("@nama", MySqlDbType.VarChar, 200);
                sqlCommand.Parameters.Add("@ketentuan", MySqlDbType.VarChar, 200);
                sqlCommand.Parameters.Add("@kendaraan", MySqlDbType.VarChar, 20);
                sqlCommand.Parameters.Add("@detail", MySqlDbType.VarChar, 500);
                sqlCommand.Parameters.Add("@harga", MySqlDbType.Decimal, 12);
                sqlCommand.Parameters.Add("@foto", MySqlDbType.Blob);

                sqlCommand.Parameters["@Idpaket"].Value = tbidpaket.Text;
                sqlCommand.Parameters["@Iddaerah"].Value = tbdaerah.Text;
                sqlCommand.Parameters["@Idkategori"].Value = tbkategori.Text;
                sqlCommand.Parameters["@nama"].Value = tbnamapaket.Text;
                sqlCommand.Parameters["@ketentuan"].Value = tbketentuan.Text;
                sqlCommand.Parameters["@kendaraan"].Value = tbkendaraan.Text;
                sqlCommand.Parameters["@detail"].Value = tbdetail.Text;
                sqlCommand.Parameters["@harga"].Value = tbharga.Text;
                sqlCommand.Parameters["@foto"].Value = buffer_new;
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di Update");
                sqlConnect.Close();

                DataTable dtpaketour = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_PAKET_TOUR as `ID Paket Tour`,ID_DAERAH as `ID daerah`,ID_KATEGORI as `ID Kategori`,NAMA_PAKET_TOUR as `Nama Paket Tour`,KETENTUAN as `Ketentuan`,KENDARAAN as `Kendaraan`,DETAIL as `Detail`,HARGA_TOUR_ORG as `Harga Tour`,FOTO as `Foto`,DELETE_PELANGGAN as `Delete` FROM paket__tour";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpaketour);
                dataGridView1.DataSource = dtpaketour;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files *.jpg| *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
