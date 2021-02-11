using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
   public interface IResult  // Sonuçları görüntülemek için. Başarılı-başarısız durum kontrolü ve mesaj ekleme.
    {
        bool Success { get; } //get - sadece okunabilir demek.     set - yazmak için
        string Message { get; }   //get sadece return eder.
    }
}
