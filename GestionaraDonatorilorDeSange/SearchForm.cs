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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donareSangeDBDataSet1.Donatori' table. You can move, or remove it, as needed.
            this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet1.Donatori);

        }

        private void btnSearchDonator_Click(object sender, EventArgs e)
        {
            int indGrupaSanguina = cmbGrupaDeSange.SelectedIndex;
            int indRh = cmbRh.SelectedIndex;
            string grupaSanguina = aflaGrupaSanguina(indGrupaSanguina);
            string rh = aflaRh(indRh);
            string undefined = ".";
            if (grupaSanguina.Equals(undefined) || rh.Equals(undefined))
                MessageBox.Show("Nu ai selectat grupa de sange sau rh-ul.", "Te rugam sa le selectezi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.donatoriTableAdapter.searchDonator(this.donareSangeDBDataSet1.Donatori, grupaSanguina, rh);
        }

        private string aflaRh(int indRh)
        {
            if (indRh == 0)
                return "+";
            if (indRh == 1)
                return "-";
            return ".";
        }

        private string aflaGrupaSanguina(int indGrupaSanguina)
        {
            if (indGrupaSanguina == 0)
                return "O";
            if (indGrupaSanguina == 1)
                return "A";
            if (indGrupaSanguina == 2)
                return "B";
            if (indGrupaSanguina == 3)
                return "AB";
            return ".";
        }
    }
}
