namespace UAS_Rent_Car
{
    partial class FormDataMobil
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
            this.textBoxnomobil = new System.Windows.Forms.TextBox();
            this.datamobilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appRentCarDataSet = new UAS_Rent_Car.AppRentCarDataSet();
            this.textBoxjnsmobil = new System.Windows.Forms.TextBox();
            this.datamobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxmrkmobil = new System.Windows.Forms.TextBox();
            this.textBoxhrgsewa = new System.Windows.Forms.TextBox();
            this.dgvdatamobil = new System.Windows.Forms.DataGridView();
            this.nomormobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenismobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkmobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_mobilTableAdapter = new UAS_Rent_Car.AppRentCarDataSetTableAdapters.data_mobilTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datamobilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatamobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Mobil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Mobil";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Merek Mobil";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Haga Sewa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxnomobil
            // 
            this.textBoxnomobil.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datamobilBindingSource2, "nomor_mobil", true));
            this.textBoxnomobil.Location = new System.Drawing.Point(164, 56);
            this.textBoxnomobil.Name = "textBoxnomobil";
            this.textBoxnomobil.Size = new System.Drawing.Size(162, 20);
            this.textBoxnomobil.TabIndex = 4;
            this.textBoxnomobil.TextChanged += new System.EventHandler(this.textBoxnomobil_TextChanged);
            // 
            // datamobilBindingSource2
            // 
            this.datamobilBindingSource2.DataMember = "data_mobil";
            this.datamobilBindingSource2.DataSource = this.appRentCarDataSet;
            // 
            // appRentCarDataSet
            // 
            this.appRentCarDataSet.DataSetName = "AppRentCarDataSet";
            this.appRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxjnsmobil
            // 
            this.textBoxjnsmobil.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datamobilBindingSource, "jenis_mobil", true));
            this.textBoxjnsmobil.Location = new System.Drawing.Point(164, 102);
            this.textBoxjnsmobil.Name = "textBoxjnsmobil";
            this.textBoxjnsmobil.Size = new System.Drawing.Size(162, 20);
            this.textBoxjnsmobil.TabIndex = 5;
            this.textBoxjnsmobil.TextChanged += new System.EventHandler(this.textBoxjnsmobil_TextChanged);
            // 
            // datamobilBindingSource
            // 
            this.datamobilBindingSource.DataMember = "data_mobil";
            this.datamobilBindingSource.DataSource = this.appRentCarDataSet;
            // 
            // textBoxmrkmobil
            // 
            this.textBoxmrkmobil.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datamobilBindingSource, "merk_mobil", true));
            this.textBoxmrkmobil.Location = new System.Drawing.Point(164, 152);
            this.textBoxmrkmobil.Name = "textBoxmrkmobil";
            this.textBoxmrkmobil.Size = new System.Drawing.Size(162, 20);
            this.textBoxmrkmobil.TabIndex = 6;
            this.textBoxmrkmobil.TextChanged += new System.EventHandler(this.textBoxmrkmobil_TextChanged);
            // 
            // textBoxhrgsewa
            // 
            this.textBoxhrgsewa.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datamobilBindingSource, "harga_sewa", true));
            this.textBoxhrgsewa.Location = new System.Drawing.Point(164, 201);
            this.textBoxhrgsewa.Name = "textBoxhrgsewa";
            this.textBoxhrgsewa.Size = new System.Drawing.Size(162, 20);
            this.textBoxhrgsewa.TabIndex = 7;
            this.textBoxhrgsewa.TextChanged += new System.EventHandler(this.textBoxhrgsewa_TextChanged);
            // 
            // dgvdatamobil
            // 
            this.dgvdatamobil.AutoGenerateColumns = false;
            this.dgvdatamobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatamobil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomormobilDataGridViewTextBoxColumn,
            this.jenismobilDataGridViewTextBoxColumn,
            this.merkmobilDataGridViewTextBoxColumn,
            this.hargasewaDataGridViewTextBoxColumn});
            this.dgvdatamobil.DataSource = this.datamobilBindingSource;
            this.dgvdatamobil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvdatamobil.Location = new System.Drawing.Point(12, 231);
            this.dgvdatamobil.Name = "dgvdatamobil";
            this.dgvdatamobil.Size = new System.Drawing.Size(764, 197);
            this.dgvdatamobil.TabIndex = 8;
            this.dgvdatamobil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatamobil_CellContentClick);
            // 
            // nomormobilDataGridViewTextBoxColumn
            // 
            this.nomormobilDataGridViewTextBoxColumn.DataPropertyName = "nomor_mobil";
            this.nomormobilDataGridViewTextBoxColumn.HeaderText = "nomor_mobil";
            this.nomormobilDataGridViewTextBoxColumn.Name = "nomormobilDataGridViewTextBoxColumn";
            // 
            // jenismobilDataGridViewTextBoxColumn
            // 
            this.jenismobilDataGridViewTextBoxColumn.DataPropertyName = "jenis_mobil";
            this.jenismobilDataGridViewTextBoxColumn.HeaderText = "jenis_mobil";
            this.jenismobilDataGridViewTextBoxColumn.Name = "jenismobilDataGridViewTextBoxColumn";
            // 
            // merkmobilDataGridViewTextBoxColumn
            // 
            this.merkmobilDataGridViewTextBoxColumn.DataPropertyName = "merk_mobil";
            this.merkmobilDataGridViewTextBoxColumn.HeaderText = "merk_mobil";
            this.merkmobilDataGridViewTextBoxColumn.Name = "merkmobilDataGridViewTextBoxColumn";
            // 
            // hargasewaDataGridViewTextBoxColumn
            // 
            this.hargasewaDataGridViewTextBoxColumn.DataPropertyName = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.HeaderText = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.Name = "hargasewaDataGridViewTextBoxColumn";
            // 
            // data_mobilTableAdapter
            // 
            this.data_mobilTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(627, 205);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(139, 20);
            this.textBoxsearch.TabIndex = 12;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cari Nomor Mobil";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // datamobilBindingSource1
            // 
            this.datamobilBindingSource1.DataMember = "data_mobil";
            this.datamobilBindingSource1.DataSource = this.appRentCarDataSet;
            // 
            // FormDataMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvdatamobil);
            this.Controls.Add(this.textBoxhrgsewa);
            this.Controls.Add(this.textBoxmrkmobil);
            this.Controls.Add(this.textBoxjnsmobil);
            this.Controls.Add(this.textBoxnomobil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDataMobil";
            this.Text = "FormDataMobil";
            this.Load += new System.EventHandler(this.FormDataMobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatamobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamobilBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnomobil;
        private System.Windows.Forms.TextBox textBoxjnsmobil;
        private System.Windows.Forms.TextBox textBoxmrkmobil;
        private System.Windows.Forms.TextBox textBoxhrgsewa;
        private System.Windows.Forms.DataGridView dgvdatamobil;
        private AppRentCarDataSet appRentCarDataSet;
        private System.Windows.Forms.BindingSource datamobilBindingSource;
        private AppRentCarDataSetTableAdapters.data_mobilTableAdapter data_mobilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomormobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenismobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkmobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource datamobilBindingSource2;
        private System.Windows.Forms.BindingSource datamobilBindingSource1;
    }
}