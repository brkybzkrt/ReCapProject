using Core.EfEntityRepositoryBase;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var sonuc = from r in context.Rentals
                            join c in context.Cars
                            on r.CarId equals c.Id
                            join cu in context.Customers
                            on r.CustomerId equals cu.CustomerId
                            join b in context.Brands
                            on c.BrandId equals b.BrandId
                            select new RentalDetailDto {Id=r.Id,CompanyName=cu.CustomerName,BrandName=b.BrandName,CarName=c.Description,RentDate=r.RentDate,ReturnDate=r.ReturnDate };

                return sonuc.ToList();
            }
        }

    }
}
