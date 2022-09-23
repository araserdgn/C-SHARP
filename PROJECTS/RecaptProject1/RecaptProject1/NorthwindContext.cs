using RecaptProject1.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity; // veritabanı kitaplıgı
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecaptProject1
{
    public class NorthwindContext:DbContext // hangi nesneyi veritabanında baglaaycaksın onu yazıyoruz içine
    {
        public DbSet<Product>Products { get; set; }
        // Elimde PRODUCT var o product da veritabanında PRODUCTS'a karşılı gelir demek.
        public DbSet<Category> Categories { get; set; } 
        // Elimde Category var o da veritabanındaki CATEGORİES'e karşılık gelir
    }
}
