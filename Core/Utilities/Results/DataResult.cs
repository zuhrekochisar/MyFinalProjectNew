using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message):base(success, message)   //Result sadece voidler içindi. DataResult da data da var.
        {
            Data = data;
        }

        public DataResult(T data,bool success):base(success)  //Mesaj gönderilmek istenmediğinde
        {
            Data = data;  //Data yı set ettik.
        }

        public T Data { get; }
    }
}
