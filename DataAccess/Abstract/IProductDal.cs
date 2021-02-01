﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Product ile ilgili veritabanında yapılacak operasyonları içeren interface.
   public interface IProductDal   //I-interface  Product-Entity(Tablo)  Dal-Data Access Layer   Dal bazı projelerde (Java vb.) Dao olarak görülür. Data Access Object
    {
        List<Product> GetAll();  //GetAll - Hepsini getir. Buradaki Product farklı bir katmandan gelecek.
        //DataAccess'a sağ tıkladık. Ekle'den "Proje Başvurusu"na tıkladık. Çıkan ekrandan "Entities" seçilir. Ardından List'in yanındaki Product ampulden ilki seçilir.
        void Add(Product product);    //Default Public
        void Update(Product product);  //Default Public
        void Delete(Product product);  //Default Public
    }
}

//interface in operasyonları public tir. kendisi public değildir.