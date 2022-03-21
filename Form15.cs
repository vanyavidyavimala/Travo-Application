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
    public partial class Finsertpakettour : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        DataTable dtkategori = new DataTable();
        public FormAdminPaketTour formduabelas;
        string id = "";
        int rowsCount = 0;
        FileStream fs;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        BinaryReader br;
        public Finsertpakettour()
        {
            InitializeComponent();
        }

        private void Finsertpakettour_Load(object sender, EventArgs e)
        {
            try
            {
                tbidpaket.Enabled = false;
                sqlConnect = new MySqlConnection(stringConnect);
                DataTable dtdaerah = new DataTable();
                query = "SELECT ID_DAERAH as `ID daerah`,NAMA_DAERAH as `Nama daerah` FROM daerah";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtdaerah);
                cbiddaerah.DataSource = dtdaerah;
                cbiddaerah.DisplayMember = "Nama Daerah";
                cbiddaerah.ValueMember = "ID Daerah";
                DataTable dtkategori = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT ID_KATEGORI as `ID kategori`,JENIS_KATEGORI as `Jenis kategori` FROM kategori";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtkategori);
                cbkategori.DataSource = dtkategori;
                cbkategori.DisplayMember = "Jenis kategori";
                cbkategori.ValueMember = "ID kategori";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files *.jpg| *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pbinsertfoto.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            FormAdminPaketTour dtback = new FormAdminPaketTour();
            dtback.formlimabelas = this;
            dtback.Show();
            this.Hide();

        }

        private void tbidpaket_TextChanged(object sender, EventArgs e)
        {
            try
            {

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
                if (cbkategori.SelectedValue.ToString() != "")
                {

                    DataTable dtCount = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT * FROM paket__tour  WHERE ID_KATEGORI LIKE'" + cbkategori.SelectedValue.ToString() + "%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtCount);

                    rowsCount = dtCount.Rows.Count;

                    string nol = "";
                    rowsCount++;
                   
                    id = cbkategori.SelectedValue.ToString()+rowsCount.ToString();
                    tbidpaket.Text = id;
                }
                if (cbiddaerah.SelectedIndex.ToString() != "-1")
                {
                    if (tbnamapinsert.Text != "")
                    {
                        if (tbketentuaninsert.Text != "")
                        {
                            if (tbkendaraaninsert.Text != "")
                            {
                                if (tbdetailinsert.Text != "")
                                {
                                    if (tbhargainsert.Text != "")
                                    {
                                        if (tbnamapinsert.Text.Length > 0 && btfoto.Text.Length > 0)
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



                                            //query = "INSERT INTO paket__tour VALUES('" + id + "','" + cbiddaerah.SelectedValue.ToString() + "','" + cbkategori.SelectedValue.ToString() + "','" + tbnamapinsert.Text + "','" + tbketentuaninsert.Text + "','" + tbkendaraaninsert.Text + "','" + tbdetailinsert.Text + "' , '" + tbhargainsert.Text + "'," + buffer_new.ToString() + ";)";
                                            query = "INSERT INTO paket__tour VALUES (@Idpaket,@Iddaerah,@Idkategori,@nama,@ketentuan,@kendaraan,@detail,@harga,@foto,0)";
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

                                            sqlCommand.Parameters["@Idpaket"].Value = id;
                                            sqlCommand.Parameters["@Iddaerah"].Value = cbiddaerah.SelectedValue.ToString();
                                            sqlCommand.Parameters["@Idkategori"].Value = cbkategori.SelectedValue.ToString();
                                            sqlCommand.Parameters["@nama"].Value = tbnamapinsert.Text;
                                            sqlCommand.Parameters["@ketentuan"].Value = tbketentuaninsert.Text;
                                            sqlCommand.Parameters["@kendaraan"].Value = tbkendaraaninsert.Text;
                                            sqlCommand.Parameters["@detail"].Value = tbdetailinsert.Text;
                                            sqlCommand.Parameters["@harga"].Value = tbhargainsert.Text;
                                            sqlCommand.Parameters["@foto"].Value = buffer_new;
                                            sqlCommand.ExecuteNonQuery();
                                            MessageBox.Show("Data berhasil di Input");
                                            sqlConnect.Close();


                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Harga Harus Diisi");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Detail Harus Diisi");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kendaraan Harus Diisi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ketentuan Harus Diisi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nama Paket Belum Diisi");
                    }
                }
                else
                {
                    MessageBox.Show("Belum memilih daerah");
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbnamapinsert_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pbinsertfoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files *.jpg| *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pbinsertfoto.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
