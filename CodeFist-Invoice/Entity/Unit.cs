using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist_Invoice.Entity
{
     public class Unit  //birim 
    {
        public Unit() {
            this.products = new HashSet<Product>();

        }

        public int UnitID { get; set; } //Birim ID
        public string UnitName { get; set; } //Birim adı
         
        public virtual ICollection<Product> products { get; set; } //Bir birimde birden fazla ürün olabilir.Bire çok ilişki.Bir kilo şeker,1 kilo pirinç.

    }
}
