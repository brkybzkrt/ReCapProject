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
            //CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 6, ColorId = 3, ModelYear = 2020, DailyPrice = 500000, Description = "Sls Amg" });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id +" "+ car.ModelYear+" "+ car.Description );
            //}

            //***************************************************

            //var result = carManager.GetCarDetails();
            //foreach (var carDetail in result.Data)
            //{
            //    Console.WriteLine(carDetail.Id+" "+carDetail.BrandName+" "+carDetail.Description+" "+carDetail.ColorName+" "+carDetail.DailyPrice);

            //}

            //Console.WriteLine(result.Message);

            //********************************

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color {ColorName="Sarı"});


            //var result2 = colorManager.GetColors();
            //foreach (var color in result2.Data)
            //{
            //    Console.WriteLine(color.ColorId +" "+ color.ColorName);
            //}

            //Console.WriteLine(result2.Message);
           
            //******************************
            
            UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User {FirstName="Berkay",LastName="Bozkurt",Email="berkay@gmail.com",Password="12397685" });

            var result= userManager.GetAll();

            foreach (var user in result.Data)
            {
                Console.WriteLine(user.UserId+" "+ user.FirstName+" "+user.LastName+" "+user.Email+" "+user.Password);
            }


            CustomerManager customerManager = new CustomerManager(new EfCustomerDal()); ////crudları yaz

        }
    }
}
