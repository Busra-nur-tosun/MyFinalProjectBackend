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
    /// Ürün işlemlerini yöneten servis arayüzüdür.
    /// Bu arayüz, ürünlerin listesini getirme, belirli bir kategoriye ait ürünleri getirme,
    /// belirli fiyat aralığındaki ürünleri getirme, ürün detaylarını getirme, belirli bir ürünün
    /// detaylarını getirme, ürün ekleme, ürün güncelleme ve işlem sırasında bir test gerçekleştirme gibi
    /// ürün işlemlerini gerçekleştirmek için kullanılır.
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);

    }
}
