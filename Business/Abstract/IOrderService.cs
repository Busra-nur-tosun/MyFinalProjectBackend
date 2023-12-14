using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{

    /// Sipariş işlemlerini yöneten servis arayüzüdür.
    /// Bu arayüz, tüm siparişlerin listesini getirme ve belirli bir siparişin detaylarını almak gibi
    /// sipariş işlemlerini gerçekleştirmek için kullanılır.
    interface IOrderService
    { 
        List<Order> GetAll();
        Order GetById(int id);
    }
}
