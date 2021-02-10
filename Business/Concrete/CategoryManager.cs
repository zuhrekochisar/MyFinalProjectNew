using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;  //Daha az bağlımlılığa sahip olmak için. Bağımlılığı constructor injection ile yapıyoruz.

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _categoryDal.GetAll(); //Filtre koymuyoruz çünkü hepsi isteniyor.
            
        }


        //Sql'deki  select *from Catgeories where CategoryId = 3    koduna karşılık düşünülebilir.
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
