using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface IColorService
    {
        IDataResult<List<Color>> GetColors();


        IResult Add(Color color);


    }
}
