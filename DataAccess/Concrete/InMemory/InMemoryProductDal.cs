using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

  

    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products; // global değişken _product
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1,CategoryId =1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
            new Product{ProductId=2,CategoryId =1,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
            new Product{ProductId=3,CategoryId =2,ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
            new Product{ProductId=4,CategoryId =2,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
            new Product{ProductId=5,CategoryId =3,ProductName="Fare",UnitPrice=85,UnitInStock=1}



            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            ////LINQ -language  integrated query
            //Product producyToDelete =null;
            //foreach (var item in _products)
            //{
            //    if (product.ProductId==item.ProductId)
            //    {

            //        producyToDelete = item;

            //    }
            //}

            ///* iki farklı...*/
            ////SingleOrDefault tek tek dolaşmaya yarıyor...
            ////SingleOrDefault ID olan aramalarda kullnılır...
            //producyToDelete = _products.SingleOrDefault(item=>item.ProductId==product.ProductId); //LINQ

            ///**/
            ///

            Product producyToDelete = _products.SingleOrDefault(item => item.ProductId == product.ProductId); //LINQ
            _products.Remove(producyToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

     

        public void Update(Product product)
        {

            //Gönderdiğin  ürün ID sine  sahip olan listedeki  ürünü bul..
            Product productToUpdate = _products.SingleOrDefault(item => item.ProductId == product.ProductId); //LINQ
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;

        }



        public List<Product> GetAllByCategory(int categoryId)
        {

            return _products.Where(p => p.CategoryId == categoryId).ToList();


        }


    }
}
