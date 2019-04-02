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
    public partial class FormCounty : Form
    {
        public FormCounty()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();


        //Fill dataGrid for county
        public void FillGridCounty() {

            var fillGridCounty = db.Counties.Select(x => new 
            {
               CountyID=x.CountyID,
                CounyName=x.Description,
                CityName=x.City.Description,

            }).ToList();
            dtGridCounty.DataSource = fillGridCounty;
            
        }

        //Fill comboBox for City
        public void FillCmbCity() {

            var FillCmbCity = db.Cities.Select(x => x).ToList();
            cmbCity.DisplayMember = "Description";
            cmbCity.ValueMember = "CityID";
            cmbCity.DataSource = FillCmbCity;

        }

        private void FormCounty_Load(object sender, EventArgs e)
        {
            FillGridCounty();
            FillCmbCity();

        }


        //County add
        private void btnAddCounty_Click(object sender, EventArgs e)
        {
            County addCounty = new County();
            addCounty.Description = txtCountyName.Text;
            addCounty.CityID = (int)cmbCity.SelectedValue;

            db.Counties.Add(addCounty);
            db.SaveChanges();
            MessageBox.Show("ilçe eklendi.");
            FillGridCounty();
        }


        //dataGride tıklandıgı an bilgileri CountyName textBoxına ve CityName ComboBoxına gönderme 
        private void dtGridCounty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliCountyID = (int)dtGridCounty.CurrentRow.Cells["CountyID"].Value;
            County findCounty = db.Counties.Find(seciliCountyID);
            txtCountyName.Text = findCounty.Description;
            cmbCity.SelectedValue = findCounty.CityID;


        }

        //Update County
        private void btnUpdateCounty_Click(object sender, EventArgs e)
        {

            int seciliCountyID = (int)dtGridCounty.CurrentRow.Cells["CountyID"].Value;
            County findCounty = db.Counties.Find(seciliCountyID);
            findCounty.Description = txtCountyName.Text;
            findCounty.CityID = (int)cmbCity.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
            FillGridCounty();

        }

        //Delete County
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtGridCounty.SelectedRows.Count == 1)
            {
                int seciliCountyID = (int)dtGridCounty.CurrentRow.Cells["CountyID"].Value;
                County findCounty = db.Counties.Find(seciliCountyID);
                db.Counties.Remove(findCounty);
                db.SaveChanges();
                MessageBox.Show("Kayıt silindi");
                FillGridCounty();
            }
            else {
                MessageBox.Show("Birden fazla kayıt seçtiniz.Lütfen kayıtları silmek için 'Multi Delete' butonunu kullanınız.");

                  }
        }

        //Çoklu ilçe sildirme
        private void cmbMultiDelete_Click(object sender, EventArgs e)
        {

            if (dtGridCounty.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow item in dtGridCounty.SelectedRows)
                {
                    int seciliCountyID = Convert.ToInt32(item.Cells[0].Value);
                    County findCounty = db.Counties.Find(seciliCountyID);
                    db.Counties.Remove(findCounty);
                    db.SaveChanges();


                }
                MessageBox.Show("Kayıtlar silindi");

                FillGridCounty();
            }
            else
            {
                MessageBox.Show("Bir kayıt seçtiniz.Lütfen 'Delete' butonunu kullanınız.");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
