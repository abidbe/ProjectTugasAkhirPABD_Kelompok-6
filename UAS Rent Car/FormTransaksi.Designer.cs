namespace UAS_Rent_Car
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxidtransaksi = new System.Windows.Forms.TextBox();
            this.textBoxidpel2 = new System.Windows.Forms.TextBox();
            this.textBoxnomobil2 = new System.Windows.Forms.TextBox();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.textBoxlmsewa = new System.Windows.Forms.TextBox();
            this.datetglsewa = new System.Windows.Forms.DateTimePicker();
            this.dgvtransaksi = new System.Windows.Forms.DataGridView();
            this.idtransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalsewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomormobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appRentCarDataSet = new UAS_Rent_Car.AppRentCarDataSet();
            this.data_transaksiTableAdapter = new UAS_Rent_Car.AppRentCarDataSetTableAdapters.data_transaksiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lama Sewa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hari";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tanggal Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "No Mobil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Pelanggan";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cari ID Transaksi";
            // 
            // textBoxidtransaksi
            // 
            this.textBoxidtransaksi.Location = new System.Drawing.Point(126, 58);
            this.textBoxidtransaksi.Name = "textBoxidtransaksi";
            this.textBoxidtransaksi.Size = new System.Drawing.Size(147, 20);
            this.textBoxidtransaksi.TabIndex = 13;
            this.textBoxidtransaksi.TextChanged += new System.EventHandler(this.textBoxidtransaksi_TextChanged);
            // 
            // textBoxidpel2
            // 
            this.textBoxidpel2.Location = new System.Drawing.Point(126, 185);
            this.textBoxidpel2.Name = "textBoxidpel2";
            this.textBoxidpel2.Size = new System.Drawing.Size(147, 20);
            this.textBoxidpel2.TabIndex = 16;
            // 
            // textBoxnomobil2
            // 
            this.textBoxnomobil2.Location = new System.Drawing.Point(126, 223);
            this.textBoxnomobil2.Name = "textBoxnomobil2";
            this.textBoxnomobil2.Size = new System.Drawing.Size(147, 20);
            this.textBoxnomobil2.TabIndex = 17;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(641, 223);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(147, 20);
            this.textBoxsearch.TabIndex = 18;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged_1);
            // 
            // textBoxlmsewa
            // 
            this.textBoxlmsewa.Location = new System.Drawing.Point(126, 103);
            this.textBoxlmsewa.Name = "textBoxlmsewa";
            this.textBoxlmsewa.Size = new System.Drawing.Size(147, 20);
            this.textBoxlmsewa.TabIndex = 14;
            // 
            // datetglsewa
            // 
            this.datetglsewa.Location = new System.Drawing.Point(130, 145);
            this.datetglsewa.Name = "datetglsewa";
            this.datetglsewa.Size = new System.Drawing.Size(143, 20);
            this.datetglsewa.TabIndex = 19;
            // 
            // dgvtransaksi
            // 
            this.dgvtransaksi.AutoGenerateColumns = false;
            this.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtransaksiDataGridViewTextBoxColumn,
            this.lamasewaDataGridViewTextBoxColumn,
            this.tanggalsewaDataGridViewTextBoxColumn,
            this.totalsewaDataGridViewTextBoxColumn,
            this.nomormobilDataGridViewTextBoxColumn,
            this.idpelangganDataGridViewTextBoxColumn});
            this.dgvtransaksi.DataSource = this.datatransaksiBindingSource;
            this.dgvtransaksi.Location = new System.Drawing.Point(16, 257);
            this.dgvtransaksi.Name = "dgvtransaksi";
            this.dgvtransaksi.Size = new System.Drawing.Size(771, 184);
            this.dgvtransaksi.TabIndex = 20;
            // 
            // idtransaksiDataGridViewTextBoxColumn
            // 
            this.idtransaksiDataGridViewTextBoxColumn.DataPropertyName = "id_transaksi";
            this.idtransaksiDataGridViewTextBoxColumn.HeaderText = "id_transaksi";
            this.idtransaksiDataGridViewTextBoxColumn.Name = "idtransaksiDataGridViewTextBoxColumn";
            // 
            // lamasewaDataGridViewTextBoxColumn
            // 
            this.lamasewaDataGridViewTextBoxColumn.DataPropertyName = "lama_sewa";
            this.lamasewaDataGridViewTextBoxColumn.HeaderText = "lama_sewa";
            this.lamasewaDataGridViewTextBoxColumn.Name = "lamasewaDataGridViewTextBoxColumn";
            // 
            // tanggalsewaDataGridViewTextBoxColumn
            // 
            this.tanggalsewaDataGridViewTextBoxColumn.DataPropertyName = "tanggal_sewa";
            this.tanggalsewaDataGridViewTextBoxColumn.HeaderText = "tanggal_sewa";
            this.tanggalsewaDataGridViewTextBoxColumn.Name = "tanggalsewaDataGridViewTextBoxColumn";
            // 
            // totalsewaDataGridViewTextBoxColumn
            // 
            this.totalsewaDataGridViewTextBoxColumn.DataPropertyName = "total_sewa";
            this.totalsewaDataGridViewTextBoxColumn.HeaderText = "total_sewa";
            this.totalsewaDataGridViewTextBoxColumn.Name = "totalsewaDataGridViewTextBoxColumn";
            // 
            // nomormobilDataGridViewTextBoxColumn
            // 
            this.nomormobilDataGridViewTextBoxColumn.DataPropertyName = "nomor_mobil";
            this.nomormobilDataGridViewTextBoxColumn.HeaderText = "nomor_mobil";
            this.nomormobilDataGridViewTextBoxColumn.Name = "nomormobilDataGridViewTextBoxColumn";
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            // 
            // datatransaksiBindingSource
            // 
            this.datatransaksiBindingSource.DataMember = "data_transaksi";
            this.datatransaksiBindingSource.DataSource = this.appRentCarDataSet;
            // 
            // appRentCarDataSet
            // 
            this.appRentCarDataSet.DataSetName = "AppRentCarDataSet";
            this.appRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_transaksiTableAdapter
            // 
            this.data_transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtransaksi);
            this.Controls.Add(this.datetglsewa);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.textBoxnomobil2);
            this.Controls.Add(this.textBoxidpel2);
            this.Controls.Add(this.textBoxlmsewa);
            this.Controls.Add(this.textBoxidtransaksi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRentCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxidtransaksi;
        private System.Windows.Forms.TextBox textBoxidpel2;
        private System.Windows.Forms.TextBox textBoxnomobil2;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.TextBox textBoxlmsewa;
        private System.Windows.Forms.DateTimePicker datetglsewa;
        private System.Windows.Forms.DataGridView dgvtransaksi;
        private AppRentCarDataSet appRentCarDataSet;
        private System.Windows.Forms.BindingSource datatransaksiBindingSource;
        private AppRentCarDataSetTableAdapters.data_transaksiTableAdapter data_transaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalsewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomormobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}