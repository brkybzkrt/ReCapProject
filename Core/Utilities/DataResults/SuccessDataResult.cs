using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.DataResults
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)// mesaj göstermek istersek
        {

        }

        public SuccessDataResult(T data):base(data,true)// mesaj göstermek istemezsek
        {

        }

        public SuccessDataResult():base(default,true)
        {

        }

    }
}
