using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal() //constructor
        {
             _cars =new List<Car> { 
                 new Car{Id=1,BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=150000,Description="Sedan 4 kapı"},
                 new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2019,DailyPrice=150000,Description="Hatchback 2 kapı"}
              
             };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public void GetAll() //tüm listeyi döndürecek
        {
            foreach (var car in _cars)
            {
                Console.WriteLine("Id = "+car.Id +" MarkaId = "+ car.BrandId +" Açıklama = "+ car.Description +" Fiyat = "+ car.DailyPrice +" TL");
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void GetById(int brand)
        {
            var getWithId = _cars.Where(c=>c.BrandId==brand).ToList();

            foreach (var carItem in getWithId)
            {
                Console.WriteLine(carItem.Id+" "+carItem.Description+" "+ carItem.DailyPrice);
            }
            
        }//markaya göre arabaları sıralama

        public void Update(Car car)
        {
            Car oldCar = _cars.First(c => c.Id == car.Id);

            oldCar.BrandId = car.BrandId;
            oldCar.ColorId = car.ColorId;
            oldCar.ModelYear = car.ModelYear;
            oldCar.DailyPrice = car.DailyPrice;
            oldCar.Description = car.Description;

        }
    }
}
