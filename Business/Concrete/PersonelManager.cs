using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}