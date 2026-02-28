namespace GestionaraDonatorilorDeSange
{
    partial class AddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaSanguinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donareSangeDBDataSet = new GestionaraDonatorilorDeSange.DonareSangeDBDataSet();
            this.donatoriTableAdapter = new GestionaraDonatorilorDeSange.DonareSangeDBDataSetTableAdapters.DonatoriTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddDonator = new System.Windows.Forms.Button();
            this.dtpAddData = new System.Windows.Forms.DateTimePicker();
            this.txtAddRH = new System.Windows.Forms.TextBox();
            this.txtAddGrupaSanguina = new System.Windows.Forms.TextBox();
            this.txtAddAdresa = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddVarsta = new System.Windows.Forms.TextBox();
            this.txtAddPrenume = new System.Windows.Forms.TextBox();
            this.txtAddNume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donareSangeDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.varstaDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.grupaSanguinaDataGridViewTextBoxColumn,
            this.rHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donatoriBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 72;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 90;
            // 
            // varstaDataGridViewTextBoxColumn
            // 
            this.varstaDataGridViewTextBoxColumn.DataPropertyName = "Varsta";
            this.varstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            this.varstaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
            this.varstaDataGridViewTextBoxColumn.Width = 75;
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            this.dataNasteriiDataGridViewTextBoxColumn.Width = 111;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 70;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 80;
            // 
            // grupaSanguinaDataGridViewTextBoxColumn
            // 
            this.grupaSanguinaDataGridViewTextBoxColumn.DataPropertyName = "GrupaSanguina";
            this.grupaSanguinaDataGridViewTextBoxColumn.HeaderText = "GrupaSanguina";
            this.grupaSanguinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grupaSanguinaDataGridViewTextBoxColumn.Name = "grupaSanguinaDataGridViewTextBoxColumn";
            this.grupaSanguinaDataGridViewTextBoxColumn.Width = 130;
            // 
            // rHDataGridViewTextBoxColumn
            // 
            this.rHDataGridViewTextBoxColumn.DataPropertyName = "RH";
            this.rHDataGridViewTextBoxColumn.HeaderText = "RH";
            this.rHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rHDataGridViewTextBoxColumn.Name = "rHDataGridViewTextBoxColumn";
            this.rHDataGridViewTextBoxColumn.Width = 56;
            // 
            // donatoriBindingSource
            // 
            this.donatoriBindingSource.DataMember = "Donatori";
            this.donatoriBindingSource.DataSource = this.donareSangeDBDataSet;
            // 
            // donareSangeDBDataSet
            // 
            this.donareSangeDBDataSet.DataSetName = "DonareSangeDBDataSet";
            this.donareSangeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donatoriTableAdapter
            // 
            this.donatoriTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAddDonator);
            this.groupBox1.Controls.Add(this.dtpAddData);
            this.groupBox1.Controls.Add(this.txtAddRH);
            this.groupBox1.Controls.Add(this.txtAddGrupaSanguina);
            this.groupBox1.Controls.Add(this.txtAddAdresa);
            this.groupBox1.Controls.Add(this.txtAddEmail);
            this.groupBox1.Controls.Add(this.txtAddVarsta);
            this.groupBox1.Controls.Add(this.txtAddPrenume);
            this.groupBox1.Controls.Add(this.txtAddNume);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(874, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introdu datele noului donator:";
            // 
            // btnAddDonator
            // 
            this.btnAddDonator.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddDonator.Location = new System.Drawing.Point(142, 261);
            this.btnAddDonator.Name = "btnAddDonator";
            this.btnAddDonator.Size = new System.Drawing.Size(89, 36);
            this.btnAddDonator.TabIndex = 16;
            this.btnAddDonator.Text = "Adauga";
            this.btnAddDonator.UseVisualStyleBackColor = false;
            this.btnAddDonator.Click += new System.EventHandler(this.btnAddDonator_Click);
            // 
            // dtpAddData
            // 
            this.dtpAddData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddData.Location = new System.Drawing.Point(116, 103);
            this.dtpAddData.Name = "dtpAddData";
            this.dtpAddData.Size = new System.Drawing.Size(102, 22);
            this.dtpAddData.TabIndex = 15;
            // 
            // txtAddRH
            // 
            this.txtAddRH.Location = new System.Drawing.Point(118, 224);
            this.txtAddRH.Name = "txtAddRH";
            this.txtAddRH.Size = new System.Drawing.Size(100, 22);
            this.txtAddRH.TabIndex = 14;
            // 
            // txtAddGrupaSanguina
            // 
            this.txtAddGrupaSanguina.Location = new System.Drawing.Point(117, 192);
            this.txtAddGrupaSanguina.Name = "txtAddGrupaSanguina";
            this.txtAddGrupaSanguina.Size = new System.Drawing.Size(100, 22);
            this.txtAddGrupaSanguina.TabIndex = 13;
            // 
            // txtAddAdresa
            // 
            this.txtAddAdresa.Location = new System.Drawing.Point(118, 161);
            this.txtAddAdresa.Name = "txtAddAdresa";
            this.txtAddAdresa.Size = new System.Drawing.Size(100, 22);
            this.txtAddAdresa.TabIndex = 12;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(117, 131);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(100, 22);
            this.txtAddEmail.TabIndex = 11;
            // 
            // txtAddVarsta
            // 
            this.txtAddVarsta.Location = new System.Drawing.Point(116, 76);
            this.txtAddVarsta.Name = "txtAddVarsta";
            this.txtAddVarsta.Size = new System.Drawing.Size(100, 22);
            this.txtAddVarsta.TabIndex = 10;
            // 
            // txtAddPrenume
            // 
            this.txtAddPrenume.Location = new System.Drawing.Point(116, 48);
            this.txtAddPrenume.Name = "txtAddPrenume";
            this.txtAddPrenume.Size = new System.Drawing.Size(100, 22);
            this.txtAddPrenume.TabIndex = 9;
            // 
            // txtAddNume
            // 
            this.txtAddNume.Location = new System.Drawing.Point(116, 20);
            this.txtAddNume.Name = "txtAddNume";
            this.txtAddNume.Size = new System.Drawing.Size(100, 22);
            this.txtAddNume.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "RH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grupa sanguina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data nasterii:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varsta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionaraDonatorilorDeSange.Properties.Resources.addBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga donator";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donareSangeDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DonareSangeDBDataSet donareSangeDBDataSet;
        private System.Windows.Forms.BindingSource donatoriBindingSource;
        private DonareSangeDBDataSetTableAdapters.DonatoriTableAdapter donatoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaSanguinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDonator;
        private System.Windows.Forms.DateTimePicker dtpAddData;
        private System.Windows.Forms.TextBox txtAddRH;
        private System.Windows.Forms.TextBox txtAddGrupaSanguina;
        private System.Windows.Forms.TextBox txtAddAdresa;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddVarsta;
        private System.Windows.Forms.TextBox txtAddPrenume;
        private System.Windows.Forms.TextBox txtAddNume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}