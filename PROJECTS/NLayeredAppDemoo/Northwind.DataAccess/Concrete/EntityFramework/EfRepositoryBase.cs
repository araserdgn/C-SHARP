using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity, new() // sınıf olmalı , IEnt. implement edilmeli ve yenilenmeki
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity=context.Entry(entity); // ilgili nesneye eriş
                addedEntity.State = EntityState.Added; // Abone ol nesneye , bulamayacaksın ve sen onu yeni ekle
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // ilgili nesneye eriş
                deletedEntity.State = EntityState.Deleted; // Abone ol nesneye , bulamayacaksın ve sen onu yeni ekle
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(TContext context = new TContext())
            {
                return filter==null?
                    context.Set<TEntity>().ToList():
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); // ilgili nesneye eriş
                updatedEntity.State = EntityState.Modified; // Abone ol nesneye , bulamayacaksın ve update halde ol
                context.SaveChanges();
            }
        }
    }
}
