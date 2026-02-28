namespace GestionaraDonatorilorDeSange
{
    partial class SearchForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donareSangeDBDataSet1 = new GestionaraDonatorilorDeSange.DonareSangeDBDataSet();
            this.donatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donatoriTableAdapter = new GestionaraDonatorilorDeSange.DonareSangeDBDataSetTableAdapters.DonatoriTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaSanguinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrupaDeSange = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRh = new System.Windows.Forms.ComboBox();
            this.btnSearchDonator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donareSangeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatoriBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // donareSangeDBDataSet1
            // 
            this.donareSangeDBDataSet1.DataSetName = "DonareSangeDBDataSet1";
            this.donareSangeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donatoriBindingSource
            // 
            this.donatoriBindingSource.DataMember = "Donatori";
            this.donatoriBindingSource.DataSource = this.donareSangeDBDataSet1;
            // 
            // donatoriTableAdapter
            // 
            this.donatoriTableAdapter.ClearBeforeFill = true;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSearchDonator);
            this.groupBox1.Controls.Add(this.cmbRh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGrupaDeSange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(662, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gaseste un donator compatibil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza grupa de sange:";
            // 
            // cmbGrupaDeSange
            // 
            this.cmbGrupaDeSange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupaDeSange.FormattingEnabled = true;
            this.cmbGrupaDeSange.Items.AddRange(new object[] {
            "O",
            "A",
            "B",
            "AB"});
            this.cmbGrupaDeSange.Location = new System.Drawing.Point(185, 22);
            this.cmbGrupaDeSange.Name = "cmbGrupaDeSange";
            this.cmbGrupaDeSange.Size = new System.Drawing.Size(121, 24);
            this.cmbGrupaDeSange.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecteaza rh-ul:";
            // 
            // cmbRh
            // 
            this.cmbRh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRh.FormattingEnabled = true;
            this.cmbRh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbRh.Location = new System.Drawing.Point(186, 52);
            this.cmbRh.Name = "cmbRh";
            this.cmbRh.Size = new System.Drawing.Size(121, 24);
            this.cmbRh.TabIndex = 3;
            // 
            // btnSearchDonator
            // 
            this.btnSearchDonator.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearchDonator.Location = new System.Drawing.Point(231, 83);
            this.btnSearchDonator.Name = "btnSearchDonator";
            this.btnSearchDonator.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDonator.TabIndex = 4;
            this.btnSearchDonator.Text = "Cauta";
            this.btnSearchDonator.UseVisualStyleBackColor = false;
            this.btnSearchDonator.Click += new System.EventHandler(this.btnSearchDonator_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionaraDonatorilorDeSange.Properties.Resources.searchBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cauta donator";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donareSangeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donatoriBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DonareSangeDBDataSet donareSangeDBDataSet1;
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
        private System.Windows.Forms.Button btnSearchDonator;
        private System.Windows.Forms.ComboBox cmbRh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupaDeSange;
        private System.Windows.Forms.Label label1;
    }
}