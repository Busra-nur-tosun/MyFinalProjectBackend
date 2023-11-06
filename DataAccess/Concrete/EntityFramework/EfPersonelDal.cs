using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public partial class EfProductDal
    {
        public class EfPersonelDal : EfEntityRepositoryBase<Personel, NorthwindContext>, IPersonelDal
        {
        }
    }
}
