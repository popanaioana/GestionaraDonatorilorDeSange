namespace GestionaraDonatorilorDeSange
{
    partial class DeleteForm
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
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 150);
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
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtDeleteId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(529, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introdu Id-ul donatorului pe care doresti sa il stergi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scrie aici Id-ul:";
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(107, 31);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteId.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(163, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionaraDonatorilorDeSange.Properties.Resources.deleteBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeleteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sterge un donator din baza de date";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
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
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}