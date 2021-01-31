using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Abstract
{
    public interface IProductService
    {

        List<Product> GetAll();



         

    }
}
