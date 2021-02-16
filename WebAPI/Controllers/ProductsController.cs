using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //Attribute -- Bir class ile ilgili bilgi verme, onu imzalama.
    public class ProductsController : ControllerBase
    {

        //Loosely Coupled - Gevşek Bağlılık
        //naming convention
        //IoC Container -- Inversion of Control (Değişimin kontrolü)
        IProductService _productService; //Bağımlılığın önüne geçmek için(*)

        public ProductsController(IProductService productService)  //Manager ver demek. Çünkü bu manager ın referansını tutabiliyor.
        {
            _productService = productService;
        }

       
        
        [HttpGet("getall")]  
        public IActionResult GetAll()
        {
            //Dependency Chain -- Bağımlılık Zinciri
            //*IProductService productService = new ProductManager(new EfProductDal());


            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);  //Bu Get Request olduğundan 200 ile çalışır. 200 demek OK yani başarılı.
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
