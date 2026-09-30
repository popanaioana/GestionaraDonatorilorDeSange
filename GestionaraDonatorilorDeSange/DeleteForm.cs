using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaraDonatorilorDeSange
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet1.Donatori);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtDeleteId.Text, out id) || id <= 0)
            {
                MessageBox.Show("Introduceti un ID valid.", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.donatoriTableAdapter.deleteDonator(id);
            this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet1.Donatori);
            txtDeleteId.Text = string.Empty;
        }
    }
}