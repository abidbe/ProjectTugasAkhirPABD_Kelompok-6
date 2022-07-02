namespace UAS_Rent_Car
{
    partial class FormDataPelanggan
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
            this.textBoxidpel = new System.Windows.Forms.TextBox();
            this.textBoxnmpel = new System.Windows.Forms.TextBox();
            this.textBoxnokntk = new System.Windows.Forms.TextBox();
            this.textBoxalamat = new System.Windows.Forms.TextBox();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.dgvdatapelanggan = new System.Windows.Forms.DataGridView();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorkontakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appRentCarDataSet = new UAS_Rent_Car.AppRentCarDataSet();
            this.datamobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_mobilTableAdapter = new UAS_Rent_Car.AppRentCarDataSetTableAdapters.data_mobilTableAdapter();
            this.data_pelangganTableAdapter = new UAS_Rent_Car.AppRentCarDataSetTableAdapters.data_pelangganTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatapelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Kontak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cari Id Pelanggan";
            // 
            // textBoxidpel
            // 
            this.textBoxidpel.Location = new System.Drawing.Point(193, 52);
            this.textBoxidpel.Name = "textBoxidpel";
            this.textBoxidpel.Size = new System.Drawing.Size(201, 20);
            this.textBoxidpel.TabIndex = 5;
            this.textBoxidpel.TextChanged += new System.EventHandler(this.textBoxidpel_TextChanged);
            // 
            // textBoxnmpel
            // 
            this.textBoxnmpel.Location = new System.Drawing.Point(193, 96);
            this.textBoxnmpel.Name = "textBoxnmpel";
            this.textBoxnmpel.Size = new System.Drawing.Size(201, 20);
            this.textBoxnmpel.TabIndex = 6;
            // 
            // textBoxnokntk
            // 
            this.textBoxnokntk.Location = new System.Drawing.Point(193, 137);
            this.textBoxnokntk.Name = "textBoxnokntk";
            this.textBoxnokntk.Size = new System.Drawing.Size(201, 20);
            this.textBoxnokntk.TabIndex = 7;
            // 
            // textBoxalamat
            // 
            this.textBoxalamat.Location = new System.Drawing.Point(193, 188);
            this.textBoxalamat.Name = "textBoxalamat";
            this.textBoxalamat.Size = new System.Drawing.Size(201, 20);
            this.textBoxalamat.TabIndex = 8;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(587, 211);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(201, 20);
            this.textBoxsearch.TabIndex = 9;
            // 
            // dgvdatapelanggan
            // 
            this.dgvdatapelanggan.AllowUserToOrderColumns = true;
            this.dgvdatapelanggan.AutoGenerateColumns = false;
            this.dgvdatapelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatapelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpelangganDataGridViewTextBoxColumn,
            this.namapelangganDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nomorkontakDataGridViewTextBoxColumn});
            this.dgvdatapelanggan.DataSource = this.datapelangganBindingSource;
            this.dgvdatapelanggan.Location = new System.Drawing.Point(13, 240);
            this.dgvdatapelanggan.Name = "dgvdatapelanggan";
            this.dgvdatapelanggan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvdatapelanggan.Size = new System.Drawing.Size(774, 206);
            this.dgvdatapelanggan.TabIndex = 10;
            this.dgvdatapelanggan.UseWaitCursor = true;
            this.dgvdatapelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatapelanggan_CellContentClick);
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            this.idpelangganDataGridViewTextBoxColumn.ToolTipText = "AddwithValues";
            // 
            // namapelangganDataGridViewTextBoxColumn
            // 
            this.namapelangganDataGridViewTextBoxColumn.DataPropertyName = "nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.HeaderText = "nama_pelanggan";
            this.namapelangganDataGridViewTextBoxColumn.Name = "namapelangganDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // nomorkontakDataGridViewTextBoxColumn
            // 
            this.nomorkontakDataGridViewTextBoxColumn.DataPropertyName = "nomor_kontak";
            this.nomorkontakDataGridViewTextBoxColumn.HeaderText = "nomor_kontak";
            this.nomorkontakDataGridViewTextBoxColumn.Name = "nomorkontakDataGridViewTextBoxColumn";
            // 
            // datapelangganBindingSource
            // 
            this.datapelangganBindingSource.DataMember = "data_pelanggan";
            this.datapelangganBindingSource.DataSource = this.appRentCarDataSet;
            // 
            // appRentCarDataSet
            // 
            this.appRentCarDataSet.DataSetName = "AppRentCarDataSet";
            this.appRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datamobilBindingSource
            // 
            this.datamobilBindingSource.DataMember = "data_mobil";
            this.datamobilBindingSource.DataSource = this.appRentCarDataSet;
            // 
            // data_mobilTableAdapter
            // 
            this.data_mobilTableAdapter.ClearBeforeFill = true;
            // 
            // data_pelangganTableAdapter
            // 
            this.data_pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Edit\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDataPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvdatapelanggan);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.textBoxalamat);
            this.Controls.Add(this.textBoxnokntk);
            this.Controls.Add(this.textBoxnmpel);
            this.Controls.Add(this.textBoxidpel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDataPelanggan";
            this.Text = "Form Data Pelanggan";
            this.Load += new System.EventHandler(this.FormDataPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatapelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxidpel;
        private System.Windows.Forms.TextBox textBoxnmpel;
        private System.Windows.Forms.TextBox textBoxnokntk;
        private System.Windows.Forms.TextBox textBoxalamat;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.DataGridView dgvdatapelanggan;
        private AppRentCarDataSet appRentCarDataSet;
        private System.Windows.Forms.BindingSource datamobilBindingSource;
        private AppRentCarDataSetTableAdapters.data_mobilTableAdapter data_mobilTableAdapter;
        private System.Windows.Forms.BindingSource datapelangganBindingSource;
        private AppRentCarDataSetTableAdapters.data_pelangganTableAdapter data_pelangganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorkontakDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}