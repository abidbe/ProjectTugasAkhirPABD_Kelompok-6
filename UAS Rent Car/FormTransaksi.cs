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
    public partial class FormTransaksi : Form
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-1JEFHIF2\\ABIDIBADURRAHMAN;database=AppRentCar;User ID=sa;Password=Cacad132");
        SqlDataAdapter adapt;
        private SqlCommand cmd;

        private void ClearData()
        {
            textBoxidtransaksi.Text = "";
            textBoxlmsewa.Text = "0";
            datetglsewa.Value = DateTime.Now;
            textBoxidpel2.Text = "";
            textBoxnomobil2.Text = "";
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.data_transaksi", con);
            adapt.Fill(dt);
            dgvtransaksi.DataSource = dt;
            con.Close();
        }

        public FormTransaksi()
        {
            InitializeComponent();
        }
        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            

        }
        private void FormTransaksi_FormClose(object sender, EventArgs e)
        {
            FormMainMenu tutup = new FormMainMenu();
            tutup.Show();
            this.Hide();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxidtransaksi.Text != "" && textBoxlmsewa.Text != "0" && datetglsewa.Text != ""&& textBoxnomobil2.Text != "" && textBoxidpel2.Text != "" )
            {
                cmd = new SqlCommand("insert into dbo.data_transaksi (id_transaksi,lama_sewa,tanggal_sewa,nomor_mobil,id_pelanggan) values (@idtrans,@lmsewa,@tglsewa,@nomormobil,@idpel)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idtrans", textBoxidtransaksi.Text);
                cmd.Parameters.AddWithValue("@lmsewa", textBoxlmsewa.Text);
                cmd.Parameters.AddWithValue("@tglsewa", datetglsewa.Text);
                cmd.Parameters.AddWithValue("@nomormobil", textBoxnomobil2.Text);
                cmd.Parameters.AddWithValue("@idpel", textBoxidpel2.Text);
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

        private void textBoxidtransaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsearch_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source =ROGSTRIXG17;database=AppRentCar;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  dbo.data_transaksi where id_transaksi='" + textBoxsearch + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvtransaksi.DataSource = dt;
            con.Close();
        }
    }
}
