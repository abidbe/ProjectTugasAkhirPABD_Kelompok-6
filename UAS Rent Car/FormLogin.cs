﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_Rent_Car
{
    public partial class FormLogin : Form
    {
        readonly string Username = "admin";
        readonly string Password = "admin";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Username && textBox2.Text == Password)
            {
                this.Hide();
                FormMainMenu panggil1 = new FormMainMenu();
                panggil1.Show();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("username dan password tidak boleh kosong");
            }
            else
            {
                MessageBox.Show("username atau password anda salah");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
