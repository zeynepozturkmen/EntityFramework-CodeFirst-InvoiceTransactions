using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
    public class InvoiceHeader //Fatura başlığı
    {
        public InvoiceHeader() {
            this.invoiceDetails = new HashSet<InvoiceDetail>();

            InvoiceDate = DateTime.Now;   //fatura tarihini date.Now al.
        }

        [Key]
        public int InvoiceID { get; set; } //Fatura ID
        public int CustomerID { get; set; } //Müşteri ID
        public DateTime InvoiceDate { get; set; } //fatura tarihi
        public int DeliveryNote { get; set; } //irsaliye numarası
        public DateTime PaymentDate { get; set; } //ödeme tarihi

        [Required]
        public decimal TotalAmount { get; set; } //Toplam tutar

        public virtual Customer customer { get; set; }//Bir fatura  bir kişiye ait olabilir.
        public virtual ICollection<InvoiceDetail> invoiceDetails { get; set; } //bir fatura başlıgında birden fazla detay olabilir.(One to many)



    }
}
