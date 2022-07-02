using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UAS_Rent_Car
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }


 
        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
   

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inputDataMobilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataMobil tampil = new FormDataMobil();
            tampil.Show();
            this.Hide();
        }

        private void inputDataPelangganToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataPelanggan tampil = new FormDataPelanggan();
            tampil.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menutup aplikasi?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi tampil = new FormTransaksi();
            tampil.Show();
            this.Hide();
        }
    }
}
