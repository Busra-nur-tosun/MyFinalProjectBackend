using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
     public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//veri tabanı ile parametre olarak gönderdiğimi arasında refernasını yakalar
                addedEntity.State = EntityState.Added;//veri kaynağı ile yukarıda eşleştiktikden sonra mevut durumu veri tabanında ne yapması gerektiğini söyler
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext contextTodelete = new TContext())
            {
                var deletedEntity = contextTodelete.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contextTodelete.SaveChanges();
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
            using (TContext context = new TContext())
            {
                //filter null ise context.set ile product tablosundaki bilgileri listeleyip getirecek
                //null değilse koşula göre getireeck
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
