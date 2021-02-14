﻿using Entities.Concrete;
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
        [HttpGet]  
        public List<Product> Get()
        {
            return new List<Product>
            {
                new Product{ProductId = 1, ProductName = "Elma"},
                new Product{ProductId = 2, ProductName = "Armut"}
            };
        }
    }
}
