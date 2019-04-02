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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CodeFist_Invoice
{
    public partial class FormCity : Form
    {
        public FormCity()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();

        

        //City add
        private void btnCityAdd_Click(object sender, EventArgs e)
        {

            City addCity = new City();
            addCity.Description = txtCityName.Text;
            db.Cities.Add(addCity);
            db.SaveChanges();
            MessageBox.Show("Şehir eklendi.");
            FillDataGrid();

        }

        //Fill dataGrid for City
        private void FillDataGrid()
        {
            var FillCity = db.Cities.Select(x => new
            {
                x.CityID,
                CityName = x.Description,
            }).ToList();

            dtGridCity.DataSource = FillCity;

        }

        private void FormCity_Load(object sender, EventArgs e)
        {
            FillDataGrid();

        }

        //Update City
        private void btnCityUpdate_Click(object sender, EventArgs e)
        {
            int seciliCityID = (int)dtGridCity.CurrentRow.Cells[0].Value;
            City FindCity = db.Cities.Find(seciliCityID);
            FindCity.Description = txtCityName.Text;
            db.SaveChanges();
            MessageBox.Show("Şehir güncellendi");
            FillDataGrid();

        }



        //dataGride tıklandıgı an txtCityName'e cityName'i gönderme
        private void dtGridCity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliCityID = (int)dtGridCity.CurrentRow.Cells[0].Value;
            City FindCity = db.Cities.Find(seciliCityID);
            txtCityName.Text = FindCity.Description;


        }

        //City Delete
        private void btnCityDelete_Click(object sender, EventArgs e)
        {


            if (dtGridCity.SelectedRows.Count==1)
            {
            
            
                int seciliCityID = (int)dtGridCity.CurrentRow.Cells[0].Value;
                City FindCity = db.Cities.Find(seciliCityID);
                db.Cities.Remove(FindCity);
                db.SaveChanges();
                MessageBox.Show("Şehir Silindi");
                FillDataGrid();

            }

            else
            {
                MessageBox.Show("Birden fazla kayıt seçtiniz.Lütfen 'Multi Delete' butonunu kullanınız.");
            }
        }

        //Multiple delete City
        private void btnCityMultipleDelete_Click(object sender, EventArgs e)
        {
            if (dtGridCity.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow item in dtGridCity.SelectedRows)
                {

                    int seciliCityID = (int)item.Cells[0].Value;
                    City FindCity = db.Cities.Find(seciliCityID);
                    db.Cities.Remove(FindCity);
                    db.SaveChanges();
                   

                }
                FillDataGrid();
                MessageBox.Show("Çoklu silme gerçekleşti");
            }
            else
            {
                MessageBox.Show("Bir kayıt seçtiniz.Lütfen 'Delete' tuşuna basınız.");
            }
        }
    }
}
