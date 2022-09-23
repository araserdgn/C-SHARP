using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.OldCustomerProductBuilder;

namespace Builder
{
     class Program
    {
        static void Main(string[] args)
        {
            ProductDirector director = new ProductDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);
            var model=builder.GetModel();

            Console.WriteLine(model.Id);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountedPrice);
            Console.WriteLine(model.DiscountApplied);

            Console.ReadLine();
        }
    }
    class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }

    }
     abstract class ProductBuilder //MERKEZ//
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel(); // üretilen modeli döndürme
    }
    class NewCustomerProductBuilder : ProductBuilder //***//
    {
        ProductViewModel model1= new ProductViewModel();
        public override void GetProductData()
        {
            model1.Id = 1;
            model1.CategoryName = "Chai";
            model1.ProductName = "Plazma";
            model1.UnitPrice = 20;
        }
        public override void ApplyDiscount() // eski müşteri inidirm kısmı
        {
            model1.DiscountedPrice = (decimal)(model1.UnitPrice * 0.90);
            model1.DiscountApplied= true;
        }

        public override ProductViewModel GetModel()
        {
           return model1;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder //***//
    {
        ProductViewModel model1 = new ProductViewModel();
        public override void GetProductData()
        {
            model1.Id = 1;
            model1.CategoryName = "Chai";
            model1.ProductName = "Plazma";
            model1.UnitPrice = 20;
        }
        public override void ApplyDiscount()
        {
            model1.DiscountedPrice=model1.UnitPrice;
            model1.DiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return model1;
        }

        // PRODUCT ÜRETİM KISMI

         public class ProductDirector
        {
            public void GenerateProduct(ProductBuilder productBuilder) // New mi Old mu yazcaz onun kısmı burası
            {
                productBuilder.GetProductData();
                productBuilder.ApplyDiscount();
            }
        }
    }
}
