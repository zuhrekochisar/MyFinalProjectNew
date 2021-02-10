using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Category ile ,lgili neyi, dış dünyaya neyi service etmek istiyorsam onu yazıyorum.
   public interface ICategoryService
    {
        List<Category> GetAll(); //Hepsini getirmek için
        Category GetById(int categoryId);  //Detayına gitmek için
    }
}
