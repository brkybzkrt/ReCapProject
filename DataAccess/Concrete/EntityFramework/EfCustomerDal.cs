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
   public class EfCustomerDal:EfRepositoryBase<Customer,RentACarContext>,ICustomerDal
    {

       
   
        
    }
}
