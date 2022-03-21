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
    public partial class formloginadmin : Form
    {
        public Formlogin formkedua;
        public formloginadmin()
        {
            InitializeComponent();
            tbpasswordadmin.PasswordChar = '*';
        }

        private void btloginadmin_Click(object sender, EventArgs e)
        {
            if (tbnamaadmin.Text == "vanya")
            {
                if (tbpasswordadmin.Text == "123")
                {
                    Formadmin fa = new Formadmin();
                    fa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("salah password");
                }
            }
            else
            {
                MessageBox.Show("salah nama");
            }
            




        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }
    }
}
