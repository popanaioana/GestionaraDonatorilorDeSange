using System;
using System.Windows.Forms;

namespace GestionaraDonatorilorDeSange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm frm = new DeleteForm();
            frm.ShowDialog();
        }
    }
}