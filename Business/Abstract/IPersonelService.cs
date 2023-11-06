using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
    }
}
