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
    public partial class FormInvoiceQuery : Form
    {
        public FormInvoiceQuery()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        //ComboBox'ı City bilgileri ile doldurma
        private void FillCity() {

            var FillCity = db.Cities.Select(x => x).ToList();
            cmbCity.DisplayMember = "Description";
            cmbCity.ValueMember = "CityID";
            cmbCity.DataSource = FillCity;
            
        }


        //ComboBox'ı seçili City'lerin ilçeleri ile doldurma
        private void FillCounty() {
            var FillCounty = db.Counties.Where(x => x.CityID == (int)cmbCity.SelectedValue).ToList();
            cmbCounty.DisplayMember = "Description";
            cmbCounty.ValueMember = "CountyID";
            cmbCounty.DataSource = FillCounty;
        }

        private void FormInvoiceQuery_Load(object sender, EventArgs e)
        {
            FillCity();
            Listele();
        }

        //Seçili il değişince o ile ait ilçeleri getiriyor.
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCounty();
        }

        private void FillCustomer()
        {
            try
            {
                var FillCustomer = db.Customers.Where(x => x.CountyID == (int)cmbCounty.SelectedValue).ToList();
                cmbCustomerName.DisplayMember = "CompanyName";
                cmbCustomerName.ValueMember = "CustomerID";
                cmbCustomerName.DataSource = FillCustomer;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
     

        }

        private void cmbCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCustomer();
        }

        //Tüm Siparişleri getir
        private void btnTumSiparisleriGoster_Click(object sender, EventArgs e)
        {

            dtGridInvoiceQuery.DataSource = db.InvoiceHeaders.Select(x => new
            {
                x.InvoiceID,
                x.CustomerID,
                x.customer.CompanyName,
                x.customer.county.City.Description,
                ilce = x.customer.county.Description,
                x.InvoiceDate,
                x.PaymentDate,
                x.DeliveryNote,
            }).OrderBy(x => x.InvoiceID).ToList();

            }


        private void Listele()
        {
            
                dtGridInvoiceQuery.DataSource = db.InvoiceHeaders.Select(x => new {
                    x.InvoiceID,
                    x.CustomerID,
                    x.customer.CompanyName,
                    x.customer.county.City.Description,
                    ilce = x.customer.county.Description,
                    x.InvoiceDate,
                    x.PaymentDate,
                    x.DeliveryNote,
                }).Where(x => x.InvoiceID.ToString().Contains(txtInvoiceID.Text)).ToList();
          
     

        }

        private void txtInvoiceID_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }



        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtGridInvoiceQuery.DataSource = db.InvoiceHeaders.Select(x => new
            {
                x.InvoiceID,
                x.CustomerID,
                x.customer.CompanyName,
                x.customer.county.City.Description,
                ilce = x.customer.county.Description,
                x.InvoiceDate,
                x.PaymentDate,
                x.DeliveryNote,
            }).Where(x => x.CustomerID == (int)cmbCustomerName.SelectedValue).ToList();


            }
    }
}
