using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {

            if (entity.Description.Length>=2 && entity.DailyPrice>0)
            {
                using (RentACarContext context = new RentACarContext())
                {
                    var addedCar = context.Entry(entity);
                    addedCar.State = EntityState.Added;

                    context.SaveChanges();
                }
            }

            else
            {
                Console.WriteLine("Araba ismini veya Günlük Fiyat değerini doğru giriniz.");
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public  List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context= new RentACarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }


        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedCar = context.Entry(entity);
                updatedCar.State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
