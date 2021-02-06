using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using - IDisposable pattern implementation of C#
            using (NorthwindContext context = new NorthwindContext()) //NortwindContext işi bitince bellekten atılacak. 
            {
                var addedEntity = context.Entry(entity); // added Entity - Eklenen varlık.  Referansı yakala.
                addedEntity.State = EntityState.Added;  //Eklenecek bir nesne.
                context.SaveChanges();  //Ekle
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted;  
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //? - Filtre null mı? Evetse tümünü getir.             : - Değilse
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();




            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
