using Core.EfEntityRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context =new RentACarContext())
            {
                var sonuc = from c in context.Carss
                            join b in context.Brands
                            on c.BrandId equals b.BrandId
                            join co in context.Colors
                            on c.ColorId equals co.ColorId
                            select new CarDetailDto {Id=c.Id,BrandName=b.BrandName,Description=c.Description,ColorName=co.ColorName,DailyPrice=c.DailyPrice };

                return sonuc.ToList();
            }
        }
    }
}
