using Ninject.Modules;
using Northwind.Bussines.Abstract;
using Northwind.Bussines.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussines.DependencyResolvers.Ninject
{
    public class BussinessModule: NinjectModule

    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); // Birisi senden IProduct isterse ona new ProManager döner demek
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            //.InSingletonScope() üretilen birdaha üretilmesin , muk. performans etkiler.
        }
    }
}
