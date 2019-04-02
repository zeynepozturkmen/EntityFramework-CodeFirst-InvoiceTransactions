using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
   public class Product //ürün sınıfı
    {
        public  Product() {

            this.invoiceDetails = new HashSet<InvoiceDetail>();
        }

        //Icollectionı yaz (Initilation)

        public int ProductID { get; set; } //ürün ID
        public string ProductName { get; set; } //Ürün adı
        public int ProductCode { get; set; } //ürün kodu
        public int UnitID { get; set; } //birim ID
        public decimal UnitPrice { get; set; } //Ürün fiyatı

        public virtual Unit unit { get; set; } //Bir ürünün bir birimi olabilir.Bir birimde birden fazla ürün olabilir.1 kilo şeker,1 kilo pirinç.(One to many)
        public virtual ICollection<InvoiceDetail> invoiceDetails { get; set; } //Bir ürün bir fatura detayında bir kez olabilir.


    }
}
