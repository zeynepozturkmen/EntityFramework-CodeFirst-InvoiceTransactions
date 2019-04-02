using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFist_Invoice
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCity frm = new FormCity();
            frm.Show();

        }

        private void countyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCounty frm = new FormCounty();
            frm.Show();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer frm = new FormCustomer();
            frm.Show();

        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit frm = new FormUnit();
            frm.Show();

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct frm = new FormProduct();
            frm.Show();
        }

        private void ınvoiceHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoiceQuery frm = new FormInvoiceQuery();
            frm.Show();
        }

        private void ınvoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoiceDetails frm = new FormInvoiceDetails();
            frm.Show();
        }
    }
}
