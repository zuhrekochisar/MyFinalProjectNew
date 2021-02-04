using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //Veri varmış gibi davranacağımız için bir ürün listesi oluşturuyoruz.

        List<Product> _products;   //Classın içinde ama metotların dışında. Bu yüzden bunlara "Global Değişken" denir. Genellikle Alt çizgi ile gösterilir. //Naming Convension
        private Product productToDelete;

        //Ekranda ürün listesi oluşturmak için;
        public InMemoryProductDal() //ctor + 2 tab - Constructor oluşturma bloğu. Constructor; bellekte referans aldığı zaman çalışacak bloktur.
        {
            //Oracle, Sql Server, Postgres, MongoDb den geliyormuş gibi simüle ediyoruz.
            _products = new List<Product> {
            new Product {ProductId=1,CategoryId =1, ProductName = "Bardak", UnitInStock=15, UnitPrice = 15},
            new Product {ProductId=2,CategoryId =1, ProductName = "Kamera", UnitInStock=3, UnitPrice = 500},
            new Product {ProductId=3,CategoryId =2, ProductName = "Telefon", UnitInStock=2, UnitPrice = 1500},
            new Product {ProductId=4,CategoryId =2, ProductName = "Klavye", UnitInStock=65, UnitPrice = 150},
            new Product {ProductId=5,CategoryId =2, ProductName = "Fare", UnitInStock=1, UnitPrice = 85}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            // => - Lambda

            /*
            Product productToDelete = null;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }
            */

            //Yukarıdaki kod yerine LINQ ile yazılırsa;

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //Tek tek dolaşmaya yarayan koddur.

            _products.Remove(productToDelete);   //productToDelete - Silinecek ürün
        }

        public List<Product> GetAll()
        {
            return _products; //Veritabanını olduğu gibi döndür.
        }

       

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id sine sahip olan listedeki ürünü bul.
          Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //productToUpdate - Güncellenecek ürün
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            product.UnitInStock = product.UnitInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); //Where; içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
