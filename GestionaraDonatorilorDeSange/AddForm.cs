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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet.Donatori);
        }

        private void btnAddDonator_Click(object sender, EventArgs e)
        {
            string nume = txtAddNume.Text;
            string prenume = txtAddPrenume.Text;
            int varsta;
            if (!int.TryParse(txtAddVarsta.Text, out varsta))
            {
                MessageBox.Show("Varsta trebuie sa fie un numar valid.", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string dataNasterii = dtpAddData.Text;
            string email = txtAddEmail.Text;
            string adresa = txtAddAdresa.Text;
            string grupaSanguina = txtAddGrupaSanguina.Text;
            string rh = txtAddRH.Text;
            if (okDateDonator(nume, prenume, varsta, dataNasterii, email, adresa, grupaSanguina, rh))
            {
                this.donatoriTableAdapter.AddDonator(nume, prenume, varsta, dataNasterii, email, adresa, grupaSanguina, rh);
                this.donatoriTableAdapter.Fill(this.donareSangeDBDataSet.Donatori);
                CleanTextBoxes();
            }
            else
            {
                MessageBox.Show("Datele nu sunt corecte.", "Va rugam introduceti date valide.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanTextBoxes()
        {
            txtAddNume.Text = string.Empty;
            txtAddPrenume.Text = string.Empty;
            txtAddVarsta.Text = string.Empty;
            dtpAddData.Text = string.Empty;
            txtAddEmail.Text = string.Empty;
            txtAddAdresa.Text = string.Empty;
            txtAddGrupaSanguina.Text = string.Empty;
            txtAddRH.Text = string.Empty;
        }

        private bool okDateDonator(string nume, string prenume, int varsta, string dataNasterii, string email, string adresa, string grupaSanguina, string rh)
        {
            if (string.IsNullOrWhiteSpace(nume))
                return false;
            if (string.IsNullOrWhiteSpace(prenume))
                return false;
            if (okVarsta(varsta) == false)
                return false;
            if (dataNasterii.Length == 0)
                return false;
            if (okEmail(email) == false)
                return false;
            if (string.IsNullOrWhiteSpace(adresa))
                return false;
            if (okGrupaSanguina(grupaSanguina) == false)
                return false;
            if (okRH(rh) == false)
                return false;
            return true;
        }

        private bool okVarsta(int varsta)
        {
            if (varsta < 18)
                return false;
            if (varsta > 120)
                return false;
            return true;
        }

        private bool okRH(string rh)
        {
            string rhPoz = "+", rhNeg = "-";
            if (rh.Equals(rhPoz))
                return true;
            if (rh.Equals(rhNeg))
                return true;
            return false;
        }

        private bool okGrupaSanguina(string grupaSanguina)
        {
            string grupaO = "O", grupaA = "A", grupaB = "B", grupaAB = "AB";
            if (grupaSanguina.Equals(grupaO))
                return true;
            if (grupaSanguina.Equals(grupaA))
                return true;
            if (grupaSanguina.Equals(grupaB))
                return true;
            if (grupaSanguina.Equals(grupaAB))
                return true;
            return false;
        }

        private bool okEmail(string email)
        {
            if (email.Contains('@') == false)
                return false;
            if (email.Contains('.') == false)
                return false;
            return true;
        }
    }
}