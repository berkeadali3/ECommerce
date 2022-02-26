using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int productId);
        List<ProductDetailDto> GetProductDetails();

    }
}
