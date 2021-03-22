using Microsoft.EntityFrameworkCore;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Core.DataAccess;

namespace Core.EfEntityRepositoryBase
{
    public class EfRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>

    where TEntity:class,IEntity,new()
    where TContext :DbContext,new()
    {

        public void Add(TEntity entity)
        {

           
                using (TContext context = new TContext())
                {
                    var addedCar = context.Entry(entity);
                    addedCar.State = EntityState.Added;

                    context.SaveChanges();
                }
            

            
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();


            }


        }


        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedCar = context.Entry(entity);
                updatedCar.State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
