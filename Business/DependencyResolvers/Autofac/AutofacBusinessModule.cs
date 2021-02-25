﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)  //over + space
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();  //Startup da yapılan işlemin karşılığı
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}