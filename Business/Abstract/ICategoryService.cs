using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    /// Kategori işlemlerini yöneten servis arayüzüdür.
    /// Bu arayüz, kategori verilerinin getirilmesi ve belirli bir kategoriye ait detayların alınması gibi
    /// kategori işlemlerini gerçekleştirmek için kullanılır.
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int CategoryId);
    }
}
