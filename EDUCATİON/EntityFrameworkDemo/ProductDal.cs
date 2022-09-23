using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll() {
        
            using (ETradeContext context = new ETradeContext()) // nesneyi dıspose etmeyi sağladı using burada
            {
                return context.Products.ToList(); 
            }
            // GetAll calısınca veritabanına gidecek ve oradakileri listeleyecek demek üstteki kod
        }

        public List<Product> GetByName(string key)
        {

            using (ETradeContext context = new ETradeContext()) // nesneyi dıspose etmeyi sağladı using burada
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
                        // veritabanından hepsinin ismine bak içinde key olanları listele

                        // name.ToLower()  key.ToLower() yaparsan buyuk kucuk harf sorununu kaldırırsın ortadan

            }
            // GetAll calısınca veritabanına gidecek ve oradakileri listeleyecek demek üstteki kod
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max) // iki fiyat aralıgı listeler
        {

            using (ETradeContext context = new ETradeContext()) // nesneyi dıspose etmeyi sağladı using burada
            {
                return context.Products.Where(p => p.UnitPrice > min && p.UnitPrice<=max).ToList();

            }
            
        }

        public Product GetById(int id) // tek bir şey göstereeksek 
        {

            using (ETradeContext context = new ETradeContext()) // nesneyi dıspose etmeyi sağladı using burada
            {
                var result=context.Products.FirstOrDefault(p=>p.Id== id);
                //SingletOrDefault , aynı id olan 2 tane varsa hata döndorur. Üstteki bunu yapmaz
                // veritaban id , girilen id eşitle eger boş ise default dön
                return result;
            }
            
        }

        public void Add (Product product)
        {
            using (ETradeContext context = new ETradeContext()) // nesneyi dıspose etmeyi sağladı using burada
            {
                //context.Products.Add(product);
                var entity = context.Entry(product); // gönderilen productu veritabanındakine eşitliyo
                entity.State = EntityState.Added;   
                context.SaveChanges(); // kaydedilenleri veritabanına yaz demek
              // context , products ise ekle
            }
        }

        public void Update (Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity=context.Entry(product); // gönderilen productu veritabanındakine eşitliyo
                entity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); // gönderilen productu veritabanındakine eşitliyo
                entity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
