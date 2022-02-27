using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<Product> GetById(int productId);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
    }
}
