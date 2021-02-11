using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract  //Business a kurallar yazılır. 
{
   public interface IProductService
    {   //T - Product
        IDataResult<List<Product>> GetAll();  //Business a sağ tıklayıp proje başvurusu ekledik. DataAccess ve Entities i seçtik. Ardından ampule tıkladık.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);  //Sadece ürüne ait özelliklerin görüntülenmesi için.
        IResult Add(Product product);
    }

}
