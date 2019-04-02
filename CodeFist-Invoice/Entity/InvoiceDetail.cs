using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
   public class InvoiceDetail //Fatura detayları 
    {
       

        [Key]
        [Column(Order=1)] //InvoiceID(faturaID) ve ProductID(ÜrünID) birleşerek pk oluyor.(Composite key)
        public int InvoiceID { get; set; }  

        [Key]
        [Column(Order = 2)]//InvoiceID(faturaID) ve ProductID(ÜrünID) birleşerek pk oluyor.(Composite key)
        public int ProductID { get; set; }  //Ürün ID

        public int Quantity { get; set; } //miktar
        public decimal UnitPrice { get; set; } //birim fiyat
        public decimal VatAmount { get; set; } //kdv miktarı
        [Required]
        public decimal VatAmountWithVat { get; set; } //kdv'li fiyat
       
        public string Description { get; set; } //aciklama



        public virtual Product product { get; set; }//Bir fatura detayında birden fazla ürün olabilir.(One to many)

        public virtual InvoiceHeader invoiceHeader { get; set; } //bir fatura detayının bir fatura baslıgı olur.                                    //Bir fatura detayının bir fatura başlığı olur.


    }
}
