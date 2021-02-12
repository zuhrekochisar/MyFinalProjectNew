using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)   //Mesaj döndürmemek için
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)  //default döndürmwk için  
        {

        }

        public ErrorDataResult() : base(default, false)  //hiçbir şey döndürmek istenmiyorsa.
        {

        }
    }
}
