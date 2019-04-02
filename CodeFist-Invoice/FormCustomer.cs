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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        //dtGrid fill customer
        public void FillGridCustomer() {

            var FillGridCustomer = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName,
                CityName=x.county.City.Description,
                CountyName= x.county.Description,
                x.Adress,
              }).ToList();

            dtGridCustomer.DataSource = FillGridCustomer;

        }

        //Fill CmbCity for City
        public void FillCmbCity() {

            var FillCmbCity = db.Cities.Select(X => X).ToList();
            cmbCustomerCity.DisplayMember = "Description";
            cmbCustomerCity.ValueMember = "CityID";
            cmbCustomerCity.DataSource = FillCmbCity;

        }

        //Fill CmbCounty for County
        public void FillCmbCounty()
        {

            var FillCmbCounty = db.Counties.Where(x => x.CityID == (int)cmbCustomerCity.SelectedValue).Select(x => x).ToList();
            cmbCustomerCounty.DisplayMember = "Description";
            cmbCustomerCounty.ValueMember = "CountyID";
            cmbCustomerCounty.DataSource = FillCmbCounty;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            FillGridCustomer();
            FillCmbCity();
            FillCmbCounty();
        }


        //Add Customer
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customerAdd = new Customer();
            customerAdd.CompanyName = txtCustomerName.Text;
            customerAdd.CountyID = (int)cmbCustomerCounty.SelectedValue;
            customerAdd.Adress = txtAdress.Text;

            db.Customers.Add(customerAdd);
            db.SaveChanges();
            MessageBox.Show("Müşteri eklendi");
            FillGridCustomer();
        }

        //Update Customer
        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            int seciliCustomerID = (int)dtGridCustomer.CurrentRow.Cells["CustomerID"].Value;
            Customer FindCustomer = db.Customers.Find(seciliCustomerID);
            FindCustomer.CompanyName = txtCustomerName.Text;
            FindCustomer.county.CityID = (int)cmbCustomerCity.SelectedValue;
            FindCustomer.CountyID = (int)cmbCustomerCounty.SelectedValue;
            FindCustomer.Adress = txtAdress.Text;
            db.SaveChanges();
            MessageBox.Show("Kayıt güncellendi.");
            FillGridCustomer();

        }


        //DataGride tıklandıgı an bilgileri yukarıdaki textBoxa filan gönderme
        private void dtGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliCustomerID = (int)dtGridCustomer.CurrentRow.Cells["CustomerID"].Value;
            Customer FindCustomer = db.Customers.Find(seciliCustomerID);
            txtCustomerName.Text = FindCustomer.CompanyName;
            cmbCustomerCity.SelectedValue = FindCustomer.county.City.CityID;
            cmbCustomerCounty.SelectedValue = FindCustomer.county.CountyID;
            txtAdress.Text = FindCustomer.Adress;
            

        }


        //delete single Customer
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {

            if (dtGridCustomer.SelectedRows.Count==1)
            {
                int seciliCustomerID = (int)dtGridCustomer.CurrentRow.Cells["CustomerID"].Value;
                Customer FindCustomer = db.Customers.Find(seciliCustomerID);
                db.Customers.Remove(FindCustomer);
                db.SaveChanges();
                MessageBox.Show("Kayıt silindi.");
                FillGridCustomer();

            }
            else
            {
                MessageBox.Show("Birden fazla kayıt seçtiniz.Lütfen 'Multi Delete' butonunu kullanınız ya da silmek için bir kayıt seçiniz.");
            }

        }

        //Multi delete customers
        private void btnMultiDelete_Click(object sender, EventArgs e)
        {
            if (dtGridCustomer.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow item in dtGridCustomer.SelectedRows)
                {
                    int seciliCustomerID = (int)item.Cells["CustomerID"].Value;
                    Customer FindCustomer = db.Customers.Find(seciliCustomerID);
                    db.Customers.Remove(FindCustomer);
                    db.SaveChanges();

                }
                MessageBox.Show("Seçilen kayıtlar silindi.");
                FillGridCustomer();

            }
            else
            {
                MessageBox.Show("Bir kayıt seçtiniz.Lütfen 'delete' butonunu kullanınız ya da birden fazla kayıt seçiniz.");
            }
        }

     

        private void cmbCustomerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var FillCmbCounty = db.Counties.Where(x => x.CityID == (int)cmbCustomerCity.SelectedValue).Select(x => x).ToList();
            cmbCustomerCounty.DisplayMember = "Description";
            cmbCustomerCounty.ValueMember = "CountyID";
            cmbCustomerCounty.DataSource = FillCmbCounty;
        }
    }
}
