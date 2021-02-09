using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public string CustomerId { get; set; } //Northwind de CustomerId string olarak tutulduğu için string yazıldı.
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }


    }
}
