using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
       public  interface IProductDal:IEntityRepository<Product>
    {





        /*
         * şimdi entity repository yaptığında buraya gerek yok
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);//ürünleri category ıd ye göre filtrele*/
    }
}
