using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint - T yi filtreleyerek sınırlandırma
    //class - referans olabilir demek.
    //new: new lenebilir olmalı.
  public interface IEntityRepository<T> where T:class, IEntity, new() //IEntity: T ya Entity olabilir ya da Entity den implemente bir şey olabilir.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);  //istenilen filtrelemeyi gerçekleştirmek için. Filter = null - Filtre vermeye de bilirsin demek.
        T Get(Expression<Func<T, bool>> filter = null);  //Sadece bir öğenin bilgilerini incelemek için.
        void Add(T entity);    //Default Public
        void Update(T entity);  //Default Public
        void Delete(T entity);  //Default Public

       // List<T> GetAllByCategory(int categoryId);  10 ve 11. satırdan ötürü buna gerek kalmadı.
    }
}
//Core katmanı; diğer katmanları referans almaz.