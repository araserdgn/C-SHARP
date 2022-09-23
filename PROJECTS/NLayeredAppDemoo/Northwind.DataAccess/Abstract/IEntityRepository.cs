using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T>where T : class,IEntity,new () // T referans ve Ientityden implement edilmeli ve yenilenmeli
    {
        // GENERİC ile çalışalım ki Araya ne verirsek ona dönsun
        List<T> GetAll(Expression<Func<T,bool>>filter=null );
        // Ürün içinde şunlar olanları getir derse kodu yukardakı FİLTRE yani
        T Get(Expression<Func<T, bool>> filter); // mutlaka filtre versin
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
