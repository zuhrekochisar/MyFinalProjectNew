using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract  //Business a kurallar yazılır. 
{
   public interface IProductService
    {
        List<Product> GetAll();  //Business a sağ tıklayıp proje başvurusu ekledik. DataAccess ve Entities i seçtik. Ardından ampule tıkladık.
    }
}
