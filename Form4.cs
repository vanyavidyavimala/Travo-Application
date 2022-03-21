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
    public partial class FormWT : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string stringConnect = "server=localhost;uid=root;pwd=;database=travo;";
        string query;
        public Formhome formketiga;
        public Formdestinasi formkesembilan;
        public static string paket;
        public static string idpaket;

        public FormWT()
        {
            InitializeComponent();
        }

        private void FormWT_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable negara = new DataTable();
                sqlConnect = new MySqlConnection(stringConnect);
                query = "SELECT nama_negara from daerah group by NAMA_NEGARA";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(negara);
                cbnegara.DataSource = negara;
                cbnegara.DisplayMember = "nama_negara";
                cbnegara.ValueMember = "nama_negara";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttlogout_Click(object sender, EventArgs e)
        {
            formsignup datalo = new formsignup();
            
            datalo.Show();
            this.Hide();
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formhome btback = new Formhome();
            
            btback.Show();
            this.Hide();
        }
        private void Pics1_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;

            idpaket = pb.Name;
            Formdestinasi fd = new Formdestinasi();
            fd.Show();
            this.Hide();
        }
        private void lb1_click(object sender, EventArgs e)
        {
            var lb = sender as Label;
            idpaket = lb.Name;
            Formdestinasi fd = new Formdestinasi();
            fd.Show();
            this.Hide();
        }
        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbsearch.Text.ToString())) /*TextBox kosong*/
                {
                    this.panelpaket.Controls.Clear(); 
                    DataTable hitung1 = new DataTable();
                    query = "SELECT HARGA_TOUR_ORG,ID_PAKET_TOUR, nama_paket_tour,nama_kota,foto from daerah d, paket__tour p where d.ID_DAERAH = p.ID_DAERAH and NAMA_KOTA = '" + cbdaerah.SelectedValue.ToString() + "'and ID_PAKET_TOUR like 'WT%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(hitung1);
                    
                    for (int i = 0; i < hitung1.Rows.Count; i++)  /*memunculkan semua row ke db*/ 
                    {
                        PictureBox pics1 = new PictureBox();
                        Label lb1 = new Label();
                        Label lb2 = new Label();
                        pics1.Click += Pics1_Click;
                        lb1.Click += lb1_click;
                        this.panelpaket.Controls.Add(pics1);/* memasukan pb  ke dalam panel*/
                        this.panelpaket.Controls.Add(lb1);
                        this.panelpaket.Controls.Add(lb2);
                        pics1.Name = hitung1.Rows[i]["ID_PAKET_TOUR"].ToString();

                        pics1.Width = 150;
                        pics1.Height = 150;
                        byte[] img = (byte[])hitung1.Rows[i]["foto"];
                        MemoryStream ms = new MemoryStream(img);
                        pics1.Image = Image.FromStream(ms);
                        

                        lb1.Text = hitung1.Rows[i]["nama_paket_tour"].ToString();
                        lb1.Name = hitung1.Rows[i]["ID_PAKET_TOUR"].ToString();
                        lb2.Text = "Rp. "+hitung1.Rows[i]["HARGA_TOUR_ORG"].ToString();
                    }

                }
                else  /*TextBox isi*/
                {
                    DataTable cari = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    string query2 = "SELECT HARGA_TOUR_ORG, NAMA_PAKET_TOUR ,ID_PAKET_TOUR , nama_kota,foto from paket__tour p, daerah d where p.ID_DAERAH = d.ID_DAERAH and NAMA_KOTA = '" + cbdaerah.SelectedValue.ToString() + "' and NAMA_PAKET_TOUR like '" + tbsearch.Text.ToString() + "%' and ID_PAKET_TOUR like 'WT%';";
                    sqlCommand = new MySqlCommand(query2, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(cari);
                    
                    this.panelpaket.Controls.Clear();
                    for (int i = 0; i < cari.Rows.Count; i++)
                    {
                        PictureBox pics1 = new PictureBox();
                        Label lb1 = new Label();
                        Label lb2 = new Label();
                        pics1.Click += Pics1_Click;
                        lb1.Click += lb1_click;
                       
                        this.panelpaket.Controls.Add(pics1);
                        this.panelpaket.Controls.Add(lb1);
                        this.panelpaket.Controls.Add(lb2);
                        pics1.Name = cari.Rows[i]["ID_PAKET_TOUR"].ToString();

                        pics1.Width = 150;
                        pics1.Height = 150;
                        byte[] img = (byte[])cari.Rows[i]["foto"];
                        MemoryStream ms = new MemoryStream(img);
                        pics1.Image = Image.FromStream(ms);
                        
                        
                        lb1.Text = cari.Rows[i]["nama_paket_tour"].ToString();
                        lb1.Name = cari.Rows[i]["ID_PAKET_TOUR"].ToString();
                        lb2.Text = "Rp. " + cari.Rows[i]["HARGA_TOUR_ORG"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbnegara_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbnegara.SelectedValue.ToString() == "Indonesia")
                {
                    DataTable indo = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT NAMA_KOTA FROM travo.daerah where NAMA_NEGARA = 'Indonesia' group by NAMA_KOTA;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(indo);
                    cbdaerah.DataSource = indo;
                    cbdaerah.DisplayMember = "NAMA_KOTA";
                    cbdaerah.ValueMember = "NAMA_KOTA";
                }
                else if (cbnegara.SelectedValue.ToString() == "Jepang")
                {
                    DataTable jepang = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT NAMA_KOTA FROM travo.daerah where NAMA_NEGARA = 'Jepang' group by NAMA_KOTA;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(jepang);
                    cbdaerah.DataSource = jepang;
                    cbdaerah.DisplayMember = "NAMA_KOTA";
                    cbdaerah.ValueMember = "NAMA_KOTA";
                }
                else if (cbnegara.SelectedValue.ToString() == "Thailand")
                {
                    DataTable Thailand = new DataTable();
                    sqlConnect = new MySqlConnection(stringConnect);
                    query = "SELECT NAMA_KOTA FROM travo.daerah where NAMA_NEGARA = 'Thailand' group by NAMA_KOTA;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(Thailand);
                    cbdaerah.DataSource = Thailand;
                    cbdaerah.DisplayMember = "NAMA_KOTA";
                    cbdaerah.ValueMember = "NAMA_KOTA";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbdaerah_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.panelpaket.Controls.Clear();
                DataTable hitung1 = new DataTable();
                query = "SELECT HARGA_TOUR_ORG,ID_PAKET_TOUR, nama_paket_tour,nama_kota,foto from daerah d, paket__tour p where d.ID_DAERAH = p.ID_DAERAH and NAMA_KOTA = '" + cbdaerah.SelectedValue.ToString() + "'and ID_PAKET_TOUR like 'WT%';";
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(hitung1);
              
                for (int i = 0; i < hitung1.Rows.Count; i++)
                {
                    PictureBox pics1 = new PictureBox();
                    Label lb1 = new Label();
                    Label lb2 = new Label();
                    pics1.Click += Pics1_Click;
                    lb1.Click += lb1_click;
                    this.panelpaket.Controls.Add(pics1);
                    this.panelpaket.Controls.Add(lb1);
                    this.panelpaket.Controls.Add(lb2);
                    pics1.Name = hitung1.Rows[i]["ID_PAKET_TOUR"].ToString();

                    ;

                    pics1.Width = 150;
                    pics1.Height = 150;
                    byte[] img = (byte[])hitung1.Rows[i]["foto"];
                    MemoryStream ms = new MemoryStream(img);
                    pics1.BackgroundImage = Image.FromStream(ms);
                    pics1.BackgroundImageLayout = ImageLayout.Stretch;
                    lb1.Text = hitung1.Rows[i]["nama_paket_tour"].ToString();
                    lb1.Name = hitung1.Rows[i]["ID_PAKET_TOUR"].ToString();
                    lb2.Text = "Rp. " + hitung1.Rows[i]["HARGA_TOUR_ORG"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.Message);
            }

        }
    }
}
