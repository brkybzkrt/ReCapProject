using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.DataResults
{
   public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, true, message)
        {

        }

        public ErrorDataResult(T data) : base(data, true)
        {

        }

        public ErrorDataResult() : base(default, true)
        {

        }

    }
}
