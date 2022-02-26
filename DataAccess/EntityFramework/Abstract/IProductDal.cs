using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Abstract
{
    public interface IProductDal:IEntityBaseRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
