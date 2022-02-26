using Business.Abstract;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public Product Get(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId) ;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
