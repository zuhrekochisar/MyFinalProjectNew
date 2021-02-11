using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // IResult ın somut sınıfı
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success)  //Result ın tek parametreli olan constructor ına success i yolla.  //this class ın kendisi demek. Yani burada kastedilne "Result".
        {
            Message = message;   //get ler readonly dir. fakat constructor larda set edilebilirler.
           
        }

        public Result(bool success)  //mesaj boş olsun istenirse
        {
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
