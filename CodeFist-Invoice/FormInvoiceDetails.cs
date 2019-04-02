using CodeFist_Invoice.Context;
using CodeFist_Invoice.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFist_Invoice
{
    public partial class FormInvoiceDetails : Form
    {
        public FormInvoiceDetails()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        List<UrunSecilen> urunListesi = new List<UrunSecilen>();

        int secilenID;

        //Fill ComboBox  for Customer 
        public void FillCmbCustomer()
        {

            var FillCmbCustomer = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName,
            }).ToList();

            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = FillCmbCustomer;

        }

        //Fill ComboBox for City
        public void FillCmbCity() {

            var FillCmbCity = db.Cities.Select(x => x).ToList();
            cmbCity.DisplayMember = "Description";
            cmbCity.ValueMember = "CityID";
            cmbCity.DataSource = FillCmbCity;

        }

        //Fill ComboBox for County
        public void FillCmbCounty() {

            var FillCmbCounty = db.Counties.Select(x => x).ToList();
            cmbCounty.DisplayMember = "Description";
            cmbCounty.ValueMember = "CountyID";
            cmbCounty.DataSource = FillCmbCounty;
        }

        //Fill ComboBox Product
        public void FillCmbProduct() {

            var FillCmbProduct = db.Products.Select(x => x).ToList();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = FillCmbProduct;
        }

        //Fill TextBox for UnitPrice and ProductCode
        public void FillTxtUnitPrice()
        {

            int selectedCmbProductID = (int)cmbProduct.SelectedValue;
            var FindProduct = db.Products.Find(selectedCmbProductID);
            txtUnitPrice.Text = FindProduct.UnitPrice.ToString();
            txtProductCode.Text = FindProduct.ProductCode.ToString();
            
        }

        //Fill ComboBox for Unit
        public void FillCmbUnit() {

            var FillCmbUnit = db.Units.Select(x => x).ToList();
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = FillCmbUnit;
        }


        private void FormInvoiceDetails_Load(object sender, EventArgs e)
        {
            //Fill InvoiceHeader
            FillCmbCity();
            FillCmbCounty();
            FillCmbCustomer();

            //Fill InvoiceDetails
            FillCmbProduct();
            FillTxtUnitPrice();
            FillCmbUnit();


        }

        //Product Insert
        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            urunListesi.Add(new UrunSecilen
            {
                ProductID = (int)cmbProduct.SelectedValue,
                ProductName = cmbProduct.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                VatAmount = Convert.ToDecimal(txtVatAmount.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text),


            });
            Listele();

         }
        public void Listele()
        {

            dtGridInvoiceDetails.DataSource = urunListesi.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.Quantity,
                x.VatAmount,

            }).ToList();
            dtGridInvoiceDetails.Columns[0].Visible = false;



        }

        //Fill InvoiceHeader
        private void FaturaKaydet()
        {
            InvoiceHeader InsertInvoiceHeader = new InvoiceHeader();
            InsertInvoiceHeader.CustomerID = (int)cmbCustomer.SelectedValue;
            InsertInvoiceHeader.PaymentDate = dtPckrPaymentDate.Value; //ödeme tarhi
            InsertInvoiceHeader.DeliveryNote = Convert.ToInt32(txtDeliveryNote.Text); //irsaliye no
            //InsertInvoiceHeader.TotalAmount=
            db.InvoiceHeaders.Add(InsertInvoiceHeader);
            db.SaveChanges();
            label14.Text = InsertInvoiceHeader.InvoiceID.ToString();
            //MessageBox.Show("Invoice Header Eklendi.");

        }


        //Fill InvoiceDetails
       private void FaturaDetayKaydet()
        {
            try
            {
                foreach (UrunSecilen item in urunListesi)
                {
                    InvoiceDetail DetailInsert = new InvoiceDetail();
                    DetailInsert.InvoiceID = Convert.ToInt32(label14.Text);
                    DetailInsert.ProductID = item.ProductID;

                    //DetailInsert.product.ProductCode = Convert.ToInt32(txtProductCode.Text);
                    DetailInsert.Quantity = item.Quantity; //Miktar
                    DetailInsert.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text); //Fiyat
                    DetailInsert.VatAmount = Convert.ToDecimal(txtVatAmount.Text); //kdv miktarı

                    decimal KdvMiktari = Convert.ToDecimal(txtVatAmount.Text);
                    decimal KdvliFiyat = Convert.ToDecimal(txtUnitPrice.Text) + (Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToDecimal(txtVatAmount.Text));
                    DetailInsert.VatAmountWithVat = KdvliFiyat;

                    db.InvoiceDetails.Add(DetailInsert);

                }
                db.SaveChanges();
                MessageBox.Show("Başarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
  


        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCmbProductID = (int)cmbProduct.SelectedValue;
            var FindProduct = db.Products.Find(selectedCmbProductID);
            txtUnitPrice.Text = FindProduct.UnitPrice.ToString();
            txtProductCode.Text = FindProduct.ProductCode.ToString();

            decimal KdvMiktari = Convert.ToDecimal(txtVatAmount.Text);
            decimal KdvliFiyat = Convert.ToDecimal(txtUnitPrice.Text) * (1 + Convert.ToDecimal(txtVatAmount.Text));
            txtAmountWithVat.Text = KdvliFiyat.ToString();

        }

        //Fatura kaydet
        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            DbContextTransaction tran = db.Database.BeginTransaction();
            try
            {
                FaturaKaydet();
                FaturaDetayKaydet();
                tran.Commit();
            }
            catch (Exception)
            {

                tran.Rollback();
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }
        }

      

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var FillCmbCounty = db.Counties.Where(x=> x.CityID==(int)cmbCity.SelectedValue).Select(x => x).ToList();
            cmbCounty.DisplayMember = "Description";
            cmbCounty.ValueMember = "CountyID";
            cmbCounty.DataSource = FillCmbCounty;
        }

        //DtGridde seçili kaydın bilgilerini textBox'a gönderme
        private void dtGridInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           int secilenID = (int)dtGridInvoiceDetails.CurrentRow.Cells[0].Value;
            var urun = urunListesi.Where(x => x.ProductID == secilenID).FirstOrDefault();
            cmbProduct.SelectedValue = secilenID;
           

            

        }

        //Buton update
        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            int secilenID = (int)dtGridInvoiceDetails.CurrentRow.Cells[0].Value;
            try
            {
                var urun = urunListesi.Where(x => x.ProductID == secilenID).FirstOrDefault();
                if (secilenID == (int)cmbProduct.SelectedValue)
                {
                    urun.Quantity = Convert.ToInt32(txtQuantity.Text);
                    //urun.ToplamTutar = Convert.ToDecimal(txtUrunFiyat.Text) * (decimal)numericMiktar.Value;
                }
                else
                {
                    urun.ProductID = (int)cmbProduct.SelectedValue;
                    urun.ProductName = cmbProduct.Text;
                    urun.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                    urun.Quantity = Convert.ToInt32(txtQuantity.Text);
                    //urun.ToplamTutar = Convert.ToDecimal(txtUrunFiyat.Text) * (decimal)numericMiktar.Value;
                  
                }
            
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Lütfen listeden ürün seçiniz..");
            }
        }

        //Remove
        private void btnProductRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var RemoveProduct = urunListesi.Where(x => x.ProductID == (int)dtGridInvoiceDetails.CurrentRow.Cells[0].Value).Select(x => x).FirstOrDefault();
                urunListesi.Remove(RemoveProduct);
                Listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
       



        }
    }
}
