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
            ProductManager productManager = new ProductManager(new EfProductDal());

            /*foreach (var product in productManager.GetAllByCategoryId(2)) // 2 numaralı kategorideki ürünleri göster.  //Önceki GetAll du. Hepsini getirmişti.
                
            {

                Console.WriteLine(product.ProductName);
            }
            */

            foreach (var product in productManager.GetByUnitPrice(50,100))  //Fiyatı 50 ile 100 olanları getir.
            {

                Console.WriteLine(product.ProductName);
            }

        }
    }
}
