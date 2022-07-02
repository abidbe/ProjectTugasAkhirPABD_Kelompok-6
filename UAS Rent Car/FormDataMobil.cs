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
    public partial class FormDataMobil : Form
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-1JEFHIF2\\ABIDIBADURRAHMAN;database=AppRentCar;User ID=sa;Password=Cacad132");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        public string nomobil = "";

        private void ClearData()
        {
            textBoxnomobil.Text = "";
            textBoxjnsmobil.Text = "";
            textBoxmrkmobil.Text = "";
            textBoxhrgsewa.Text = "0";
            nomobil = "";
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.data_mobil", con);
            adapt.Fill(dt);
            dgvdatamobil.DataSource = dt;
            con.Close();
        }

        public FormDataMobil()
        {
            InitializeComponent();
        }
        private void FormDataMobil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appRentCarDataSet.data_mobil' table. You can move, or remove it, as needed.
            

        }
        private void FormDataMobil_FormClose(object sender, EventArgs e)
        {
            FormMainMenu tutup = new FormMainMenu();
            tutup.Show();
            this.Hide();
        }

  
   
 
        private void dgvdatamobil_RowHeaderMouseClick_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvdatamobil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomobil = (dgvdatamobil.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxnomobil.Text = dgvdatamobil.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxjnsmobil.Text = dgvdatamobil.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxmrkmobil.Text = dgvdatamobil.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxhrgsewa.Text = dgvdatamobil.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxnomobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxmrkmobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxhrgsewa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nomobil != "")
            {
                cmd = new SqlCommand("delete dbo.data_mobil where nomor_mobil=@nomobil", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nomobil", nomobil);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil dihapus");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("please select record to delete");
            }
        }

        private void textBoxjnsmobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxsearch_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.data_mobil where nomor_mobil='" + textBoxsearch + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvdatamobil.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxnomobil.Text != "" && textBoxjnsmobil.Text != "" && textBoxmrkmobil.Text != "" && textBoxhrgsewa.Text != "0")
            {
                cmd = new SqlCommand("update dbo.data_mobil set nomor_mobil=@nomobil,jenis_mobil=@jnsmobil,merk_mobil=@merk,harga_sewa=@hrg where nomor_mobil=@nomobil2", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nomobil2", nomobil);
                cmd.Parameters.AddWithValue("@nomobil", textBoxnomobil.Text);
                cmd.Parameters.AddWithValue("@jnsmobil", textBoxjnsmobil.Text);
                cmd.Parameters.AddWithValue("@merk", textBoxmrkmobil.Text);
                cmd.Parameters.AddWithValue("@hrg", textBoxhrgsewa.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("please select record to edit");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxnomobil.Text != "" && textBoxjnsmobil.Text != "" && textBoxmrkmobil.Text != "" && textBoxhrgsewa.Text != "0")
            {
                cmd = new SqlCommand("insert into dbo.data_mobil (nomor_mobil,jenis_mobil,merk_mobil,harga_sewa) values (@nomobil, @jnsmobil, @merk, @hrg)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nomobil", textBoxnomobil.Text);
                cmd.Parameters.AddWithValue("@jnsmobil", textBoxjnsmobil.Text);
                cmd.Parameters.AddWithValue("@merk", textBoxmrkmobil.Text);
                cmd.Parameters.AddWithValue("@hrg", textBoxhrgsewa.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil ditambahkan");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Kolom belum terisi");
            }
        }
    }
}
