using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travo
{
    public partial class Formadmin : Form
    {
        public Formlogin formkedua;
        public FormAdminDaerah formsepuluh;
        public FormAdminKategori formsebelas;
        public FormAdminPaketTour formduabelas;
        public FormAdminPelanggan formtigabelas;
        public Ftransaksipemesanan formenambelas;
        public Formadmin()
        {
            InitializeComponent();
        }

        private void Formadmin_Load(object sender, EventArgs e)
        {

        }

        private void btdaerah_Click(object sender, EventArgs e)
        {
            FormAdminDaerah dbdaerah = new FormAdminDaerah();
            dbdaerah.formempatbelas = this;
            dbdaerah.Show();
            this.Hide();
        }

        private void btkategori_Click(object sender, EventArgs e)
        {
            FormAdminKategori dbkategori = new FormAdminKategori();
            dbkategori.formempatbelas = this;
            dbkategori.Show();
            this.Hide();

        }

        private void btpakettour_Click(object sender, EventArgs e)
        {
            FormAdminPaketTour dbpaket = new FormAdminPaketTour();
            dbpaket.formempatbelas = this;
            dbpaket.Show();
            this.Hide();

        }

        private void btpelanggan_Click(object sender, EventArgs e)
        {
            FormAdminPelanggan dbpelanggan = new FormAdminPelanggan();
            dbpelanggan.formempatbelas = this;
            dbpelanggan.Show();
            this.Hide();

        }

        private void pbback_Click(object sender, EventArgs e)
        {
            Formlogin flg = new Formlogin();
            flg.Show();
            this.Hide();
        }

        private void bttransaksipemesanan_Click(object sender, EventArgs e)
        {
            Ftransaksipemesanan dbtransaksi = new Ftransaksipemesanan();
            dbtransaksi.formenambelas = this;
            dbtransaksi.Show();
            this.Hide();

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            formloginadmin flg = new formloginadmin();
            flg.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
