using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product : IEntity  //Public = Bu class a diğer katmanlar da ulaşabilsin demek. O yüzden sonradan ekledik.
{
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //short; int in bir küçüğü.
        public decimal UnitPrice { get; set; }

    }
}
//Abstract-Soyut   Concrete-Somut