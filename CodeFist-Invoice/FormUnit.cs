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
    public partial class FormUnit : Form
    {
        public FormUnit()
        {
            InitializeComponent();
        }

        InvoiceContext db = new InvoiceContext();
     

        //Fill DataGrid for Unit
        public void FillGridUnit() {

            var FillGridUnit = db.Units.Select(x => new
            {
                x.UnitID,
                x.UnitName,
            }).ToList();
            dtGridUnit.DataSource = FillGridUnit;


        }

        private void FormUnit_Load(object sender, EventArgs e)
        {
            FillGridUnit();
        }

        //Add unit
        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            Unit addUnit = new Unit();
            addUnit.UnitName = txtUnitName.Text;
            db.Units.Add(addUnit);
            db.SaveChanges();
            MessageBox.Show("Unit eklendi");
            FillGridUnit();
        }


        //DataGridde bir kayda tıklandıgında UnitName verisini textBox'a gönderme
        private void dtGridUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliUnitID = (int)dtGridUnit.CurrentRow.Cells["UnitID"].Value;
            Unit findUnit = db.Units.Find(seciliUnitID);
            txtUnitName.Text = findUnit.UnitName;
        }


        //Update Unit
        private void btnUnitUpdate_Click(object sender, EventArgs e)
        {
            int seciliUnitID = (int)dtGridUnit.CurrentRow.Cells["UnitID"].Value;
            Unit findUnit = db.Units.Find(seciliUnitID);
            findUnit.UnitName = txtUnitName.Text;
            db.SaveChanges();
            MessageBox.Show("Unit güncellendi.");
            FillGridUnit();
        }


        //Unit single Delete
        private void btnUnitDelete_Click(object sender, EventArgs e)
        {
            if (dtGridUnit.SelectedRows.Count==1)
            {
                int seciliUnitID = (int)dtGridUnit.CurrentRow.Cells["UnitID"].Value;
                Unit findUnit = db.Units.Find(seciliUnitID);
                db.Units.Remove(findUnit);
                db.SaveChanges();
                MessageBox.Show("Unit silindi");
                FillGridUnit();

            }
            else
            {
                MessageBox.Show("Birden fazla kayıt seçtiniz.Lütfen 'Multi Delete' butonunu kullanınız");
            }
        }


        //Multi delete for Unit
        private void btnUnitMultiDelete_Click(object sender, EventArgs e)
        {
            if (dtGridUnit.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow item in dtGridUnit.SelectedRows)
                {

                    int seciliUnitID = (int)item.Cells["UnitID"].Value;
                    Unit findUnit = db.Units.Find(seciliUnitID);
                    db.Units.Remove(findUnit);
                    db.SaveChanges();

                }
                MessageBox.Show("Seçili kayıtlar silindi.");
                FillGridUnit();
            }
            else
            {
                MessageBox.Show("Bir kayıt seçtiniz.Lütfen 'Delete' butonunu kullanınız ya da birden fazla kayıt seçiniz.");
            }
        }
    }
}
