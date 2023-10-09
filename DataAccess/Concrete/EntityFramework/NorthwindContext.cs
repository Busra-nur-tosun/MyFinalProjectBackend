using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //CONTEXT:db tabloları ile proje claslarının bağlamak
    /// <summary>
    // override yazdıktan sonra onconfiguring yazmaksenin projenin hangi veri tabanı ile çalıştığını belirten yerdri 
    /// </summary>
      public  class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }//hangi clasım hangi tabloya denk geliyor onu ayarlar
        public DbSet<Category> Categories { get; set; }
        public  DbSet<Customer>  Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
