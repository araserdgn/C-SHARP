using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussines.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T> ( ) // metod GENERİC oldu
        {
            var kernel = new StandardKernel(new BussinessModule());
            return kernel.Get<T>();
            // T yerine ne girersen atıyorum Product girdin hemen NinjectModule
            // yerine gider orda bakar ,
            // Bind<ICategoryService>().To<CategoryManager>();
            //Bind<ICategoryDal>().To<EfCategoryDal>();
            // TARZINA uygun varsa new yapar kullanır
        }
    }
}
