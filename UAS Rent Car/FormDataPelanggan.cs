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
    public partial class FormDataPelanggan : Form
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-1JEFHIF2\\ABIDIBADURRAHMAN;database=AppRentCar;User ID=sa;Password=Cacad132");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        public string id_pelanggan = "";

        private void ClearData()
        {
            textBoxidpel.Text = "";
            textBoxnmpel.Text = "";
            textBoxnokntk.Text = "";
            textBoxalamat.Text = "";
            id_pelanggan = "";
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.data_pelanggan", con);
            adapt.Fill(dt);
            dgvdatapelanggan.DataSource = dt;
            con.Close();
        }

        public FormDataPelanggan()
        {
            InitializeComponent();
            DisplayData();
        }
        private void FormDataPelanggan_Load(object sender, EventArgs e)
        {
            

        }
        private void FormDataPelanggan_FormClose(object sender, EventArgs e)
        {
            FormMainMenu tutup = new FormMainMenu();
            tutup.Show();
            this.Hide();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  dbo.data_pelanggan where id_pelanggan='" + textBoxsearch + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvdatapelanggan.DataSource = dt;
            con.Close();
        }



        private void dgvdatapelanggan_RowHeaderMouseClick_1(object sender, EventArgs e)
        {
            
        }

        private void textBoxidpel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxidpel.Text != "" && textBoxnmpel.Text != "" && textBoxnokntk.Text != "" && textBoxalamat.Text != "0")
            {
                if (textBoxidpel.Text != "" && textBoxnmpel.Text != "" && textBoxnokntk.Text != "" && textBoxalamat.Text != "0")
                {
                    cmd = new SqlCommand("insert into dbo.data_pelanggan (id_pelanggan,nama_pelanggan,nomor_kontak,alamat) values (@idpel, @nmpel, @nokntk, @alamat)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@idpel", textBoxidpel.Text);
                    cmd.Parameters.AddWithValue("@nmpel", textBoxnmpel.Text);
                    cmd.Parameters.AddWithValue("@nokntk", textBoxnokntk.Text);
                    cmd.Parameters.AddWithValue("@alamat", textBoxalamat.Text);
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxidpel.Text != "" && textBoxnmpel.Text != "" && textBoxnokntk.Text != "" && textBoxalamat.Text != "0")
            {
                cmd = new SqlCommand("update dbo.data_pelanggan set id_pelanggan=@idpel,nama_pelanggan=@nmpel,nomor_kontak=@nokntk,alamat=@alamat where id_pelanggan=@idpela", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idpela", id_pelanggan);
                cmd.Parameters.AddWithValue("@idpel", textBoxidpel.Text);
                cmd.Parameters.AddWithValue("@nmpel", textBoxnmpel.Text);
                cmd.Parameters.AddWithValue("@nokntk", textBoxnokntk.Text);
                cmd.Parameters.AddWithValue("@alamat", textBoxalamat.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_pelanggan != "")
            {
                cmd = new SqlCommand("delete dbo.data_pelanggan where id_pelanggan=@idpel", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idpel", id_pelanggan);
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

        private void dgvdatapelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pelanggan = (dgvdatapelanggan.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxidpel.Text = dgvdatapelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxnmpel.Text = dgvdatapelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxnokntk.Text = dgvdatapelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxalamat.Text = dgvdatapelanggan.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
