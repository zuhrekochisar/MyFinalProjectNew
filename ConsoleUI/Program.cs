using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //O - Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();  //24 ve 34 dahil bu satırları sağ tıklayıp ilk çıkan seçenekten ProdductTest yazdık  ve enterladık. Böylece method oluşturuldu.
           // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            /*foreach (var product in productManager.GetAllByCategoryId(2)) // 2 numaralı kategorideki ürünleri göster.  //Önceki GetAll du. Hepsini getirmişti.
                
            {

                Console.WriteLine(product.ProductName);
            }
            */

            /*foreach (var product in productManager.GetByUnitPrice(50, 100))  //Fiyatı 50 ile 100 olanları getir.
            {

                Console.WriteLine(product.ProductName);
            }*/

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {

                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);

                }

            }
            else
                {
                    Console.WriteLine(result.Message);
                }
            
        }
    }
}


//DTO - Data Transformation Object