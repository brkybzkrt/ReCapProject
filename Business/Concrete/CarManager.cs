using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal iCarDal)
        {
            _carDal = iCarDal;
        }

        public void GetAll()
        {
            _carDal.GetAll();
        }

        

    }
}
