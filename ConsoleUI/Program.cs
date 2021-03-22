using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 6, ColorId = 3, ModelYear = 2020, DailyPrice = 500000, Description = "Sls Amg" });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id +" "+ car.ModelYear+" "+ car.Description );
            //}

            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.Id+" "+carDetail.BrandName+" "+carDetail.Description+" "+carDetail.ColorName+" "+carDetail.DailyPrice);
            }

        }
    }
}
