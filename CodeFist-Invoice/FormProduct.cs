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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();


        //DtGrid fill Product
        public void FillGridProduct() {
            var FillGridProduct = db.Products.Select(x => new
            {
              x.ProductID,
              x.ProductName,
              x.ProductCode,
              x.unit.UnitName,
              x.UnitPrice,
            }).ToList();
            dtGridProduct.DataSource = FillGridProduct;

        }

        //Fill CmbUnitName for UnitName
        public void FillCmbUnit() {

            var FillCmbUnit = db.Units.Select(x => x).ToList();
            cmbUnitName.DisplayMember = "UnitName";
            cmbUnitName.ValueMember = "UnitID";
            cmbUnitName.DataSource = FillCmbUnit;


        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            FillGridProduct();
            FillCmbUnit();

        }


        //Add Product
        private void btnProductName_Click(object sender, EventArgs e)
        {
            Product addProduct = new Product();
            addProduct.ProductName = txtProductName.Text;
            addProduct.ProductCode = Convert.ToInt32(txtProductCode.Text);
            addProduct.UnitID = (int)cmbUnitName.SelectedValue;
            addProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            db.Products.Add(addProduct);
            db.SaveChanges();
            MessageBox.Show("Product eklendi.");
            FillGridProduct();
            
        }


        //DataGridde seçili kaydın bilgilerini yukarıdaki textBoxlara doldurma
        private void dtGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int SeciliProductID = (int)dtGridProduct.CurrentRow.Cells["ProductID"].Value;
            Product FindProduct = db.Products.Find(SeciliProductID);
            txtProductName.Text = FindProduct.ProductName;
            txtProductCode.Text = FindProduct.ProductCode.ToString();
            txtUnitPrice.Text = FindProduct.UnitPrice.ToString();
            cmbUnitName.SelectedValue = (int)FindProduct.UnitID;



        }

        //Update Product
        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            int SeciliProductID = (int)dtGridProduct.CurrentRow.Cells["ProductID"].Value;
            Product FindProduct = db.Products.Find(SeciliProductID);
            FindProduct.ProductName = txtProductName.Text;
            FindProduct.ProductCode = Convert.ToInt32(txtProductCode.Text);
            FindProduct.UnitID = (int)cmbUnitName.SelectedValue;
            FindProduct.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            db.SaveChanges();
            MessageBox.Show("Product güncellendi.");
            FillGridProduct();
        }


        //Delete single Product
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (dtGridProduct.SelectedRows.Count==1)
            {
                int SeciliProductID = (int)dtGridProduct.CurrentRow.Cells["ProductID"].Value;
                Product FindProduct = db.Products.Find(SeciliProductID);
                db.Products.Remove(FindProduct);
                db.SaveChanges();
                MessageBox.Show("Product silindi");
                FillGridProduct();
            }
            else
            {
                MessageBox.Show("Birden fazla kayıt seçtiniz.Lütfen 'Multi Delete' butonunu kullanınız ya da silmek için tek bir kayıt seçiniz.");
            }

        }

        //Multi Delete for Product
        private void btnProductMultiDelete_Click(object sender, EventArgs e)
        {
            if (dtGridProduct.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow item in dtGridProduct.SelectedRows)
                {

                    int SeciliProductID = Convert.ToInt32(item.Cells["ProductID"].Value);
                    Product FindProduct = db.Products.Find(SeciliProductID);
                    db.Products.Remove(FindProduct);
                    db.SaveChanges();
                    

                }
                MessageBox.Show("Seçilen kayıtlar silindi.");
                FillGridProduct();
            }
            else
            {
                MessageBox.Show("Bir kayıt seçtiniz.Lütfen 'Delete' butonunu kullanınız ya da silmek için birden fazla kayıt seçiniz.");
            }

        }
    }
}
