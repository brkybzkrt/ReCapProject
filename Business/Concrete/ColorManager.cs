using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class ColorManager : IColorService
    {

        IColorDal _colorDal;

        public ColorManager(IColorDal icolorDal)
        {
            _colorDal = icolorDal;
        }

        public IResult Add(Color color)
        {
             _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IDataResult<List<Color>> GetColors()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ColorListed);
        }
    }
}
