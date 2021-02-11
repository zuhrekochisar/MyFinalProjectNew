using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult<T>:IResult  //Hangi tipi döndüreceğini söyle.
    {
        T Data { get; }  //buradaki data; ürünler.
    }
}
