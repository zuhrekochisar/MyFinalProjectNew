using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  //Bu method hangi veritabanıyla ilişkilendireceğimizi belirttiğimiz yerdir.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True"); //Hangi veritabanına bağlanacağımızı yazacağız.
        //True_Connection = Kullanıcı adı ve şifre gerekmeden kullanım olsun diye yazıldı.
        }
        public DbSet<Product> Products { get; set; } //Hangi nesne, hangi nesneye karşılık gelecek. DbSet ile; Product nesnesini veritabanındaki Products ile bağla.
        //Hangi Class hangi tabloya karşılık geliyor.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
