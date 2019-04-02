using CodeFist_Invoice.Context;
using CodeFist_Invoice.Entity;
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
    public partial class FormInvoiceHeader : Form
    {
        public FormInvoiceHeader()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();


        //Fill dtGrid for Invoice Header
        public void dtGridFill() {

            var dtGridFill = db.InvoiceHeaders.Select(x => new
            {
               CustomerName =x.customer.CompanyName,
                x.InvoiceDate,
                x.PaymentDate,
                x.DeliveryNote,
                x.TotalAmount,

            }).ToList();
            dtGridInvoiceHeader.DataSource = dtGridFill;

        }

        public void FillCmbCustomer() {

            var FillCmbCustomer = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName,
            }).ToList();

            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = FillCmbCustomer;

        }

        private void FormInvoiceHeader_Load(object sender, EventArgs e)
        {
            FillCmbCustomer();
            dtGridFill();
        }


        //Invoice Header add
        private void btnInsert_Click(object sender, EventArgs e)
        {
            InvoiceHeader InsertInoviceHeader = new InvoiceHeader();
            InsertInoviceHeader.CustomerID = (int)cmbCustomer.SelectedValue;
            InsertInoviceHeader.InvoiceDate = dtPckrInvoiceDate.Value; //fatura tarihi
            InsertInoviceHeader.PaymentDate = dtPckrPaymentDate.Value; //ödeme tarihi
            InsertInoviceHeader.DeliveryNote = Convert.ToInt32(txtDeliveryNote.Text);
            InsertInoviceHeader.TotalAmount = Convert.ToInt32(txtTotalAmount.Text);
            db.InvoiceHeaders.Add(InsertInoviceHeader);
            db.SaveChanges();
            MessageBox.Show("Sipariş başlıgı olusturuldu.");
            dtGridFill();


        }


        //Insert InvoiceDetails
        private void btnInsertDetail_Click(object sender, EventArgs e)
        {
            FormInvoiceDetails frm = new FormInvoiceDetails();
            frm.Show();
            this.Hide();
        }
    }
}
