using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Dependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductdal>().To<NHProductdal>().InSingletonScope();
            
            ProductManager productManager = new ProductManager(kernel.Get<IProductdal>());
            productManager.Save();
            ProductManager productManager1 = new ProductManager(new Productdal());
            productManager1.Save();

            Console.ReadLine();
        }
    }
    interface IProductdal
    {
        void Save();
    }
    class Productdal : IProductdal
    {
        public void Save ()
        {
            Console.WriteLine("Saved with Ef");
        }
    }

    class NHProductdal : IProductdal
    {
        public void Save()
        {
            Console.WriteLine("Saved with NH");
        }
    }
    class ProductManager : IProductdal //*//
    {
        private IProductdal _productDal;

        public ProductManager(IProductdal product)
        {
            _productDal = product;
        }

        public void Save ()
        {
            //Bussines code
           
            _productDal.Save();
        }
    }
}
