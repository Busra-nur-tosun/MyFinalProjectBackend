using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public interface IProductService
    {

       IDataResult<List<Product>> GetAll();//tüm ürünleri listeliyor
        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult< List<ProductDetailDto>> GetProductDetails();
        IDataResult<List<Product>> Add(Product product);
       IResult GetById(int productId);


    }
}
