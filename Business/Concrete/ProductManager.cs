﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _iProductDal;

        public ProductManager(IProductDal productDal)
        {
            _iProductDal = productDal;
        }


        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();
        }
    }
}
