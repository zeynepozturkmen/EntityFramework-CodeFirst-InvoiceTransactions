using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
    public class City //Şehir
    {

        public  City() {
            this.counties = new HashSet<County>();
        }

        public int CityID { get; set; } //Şehir ID 

       
        public string Description { get; set; } //açıklama

        public virtual ICollection<County> counties { get; set; } //Bir şehrin birden fazla ilçesi olabilir.Bire çok ilişki.(One to many)

    }
}
