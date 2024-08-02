 using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext//DbContext sınıfı var ve o sınıfa ait özelliklerin
    //context sınıfında kullanmak istiyorum. İki noktada sonra yazdığımız sınıflar bu
    //anlama gelir.
    {
        public DbSet<About> Abouts { get; set; }
        //Başka katmandan sınıf kullanmak istersek öncelikle referans almalıyız.
        //About benim projemde yer alan sınıfın ismi...
        //Abouts ise sql de veritabanına yansayacak tablonun ismi

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
