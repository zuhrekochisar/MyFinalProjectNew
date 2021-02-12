using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages //Sürekli new lememek için static yazıldı.
    {
        public static string ProductAdded = "Ürün Eklendi.";    //public olduğu için değişken isimlerinin ilk harfi de büyük yazıldı.
        public static string ProductNameInavalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
    }
}
