using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
   public class County //İlçe sınıfı
    {
        public  County() {
            this.customers = new HashSet<Customer>();
        }

        public int CountyID { get; set; }  //İlçe ID

        [Required] //Sütunun boş geçilebilecegini belirttim.(Data Annotation)
        public string Description { get; set; } //Açıklama

        public int CityID { get; set; } //Şehir ID (fK) oluyor.City tablosuyla arasında.


        public virtual  City City { get; set; }//Bir ilçe yalnızca bir şehre ait olur.

        public virtual ICollection<Customer> customers { get; set; }//Bir ilçede birden fazla müşteri olur.Bire çok ilişki.(one to many)


    }
}
