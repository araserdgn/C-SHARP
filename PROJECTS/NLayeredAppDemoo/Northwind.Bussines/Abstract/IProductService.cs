using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussines.Abstract
{
    public interface IProductService
    {
       
        List<Product> GetProductsByProductName(string productName);
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
