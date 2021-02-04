using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
  public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);  //istenilen filtrelemeyi gerçekleştirmek için. Filter = null - Filtre vermeye de bilirsin demek.
        T Get(Expression<Func<T, bool>> filter = null);  //Sadece bir öğenin bilgilerini incelemek için.
        void Add(T entity);    //Default Public
        void Update(T entity);  //Default Public
        void Delete(T entity);  //Default Public

       // List<T> GetAllByCategory(int categoryId);  10 ve 11. satırdan ötürü buna gerek kalmadı.
    }
}
