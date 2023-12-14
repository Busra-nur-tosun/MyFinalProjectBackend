using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    /// Personel işlemlerini yöneten servis arayüzüdür.
    /// Bu arayüz, tüm personellerin listesini getirmek gibi
    /// personel işlemlerini gerçekleştirmek için kullanılır.
    public interface IPersonelService
    {
        List<Personel> GetAll();
    }
}
