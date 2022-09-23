using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; } // ben product u products tablo olarak kullanıcam. Veritabanında var.
                                                    // tablolarda products arıyo yani 


    }
}
