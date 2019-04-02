using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
   public class Customer  //Müşteri sınıfı
    {
        public Customer() {

            this.invoiceHeaders = new HashSet<InvoiceHeader>();
            
                
        }

        public int CustomerID { get; set; } //Müşteri ID

        public string CompanyName { get; set; } //Kampanya adı

        public int CountyID { get; set; } //ilçe adı

        
        public string Adress { get; set; } //adres

        public virtual ICollection<InvoiceHeader> invoiceHeaders{ get; set; }//Bir müşterinin birden fazla faturası olabilir.

        public virtual County county{ get; set; } //Bir müşteri bir ilçeye  bağlı olabilir.(One to many)

    }
}
