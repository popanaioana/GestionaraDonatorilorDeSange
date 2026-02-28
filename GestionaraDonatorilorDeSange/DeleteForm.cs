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
            // TODO: This line of code loads data into the 'donareSangeDBDataSet1.Donatori' table. You can move, or remove it, as needed.
            this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet1.Donatori);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDeleteId.Text);
            this.donatoriTableAdapter.deleteDonator(id);
            this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet1.Donatori);
            txtDeleteId.Text = string.Empty;
        }
    }
}
