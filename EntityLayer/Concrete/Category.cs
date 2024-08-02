 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }


        [StringLength(50)]
        public string CategoryName { get; set; }


        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategorySatatus { get; set; }

        //ilişki kurma işlemi
        public ICollection<Heading> Headings { get; set; }
    //  Kategori ve heading tablosu arasında ilişki kurma
    //  Öncelikle property tanımlıyoruz.Onun türünü tanımlıyoruz.ICollection olucak yani koleksiyon.
    //  İlişki kurmak istediğim sınıfın adını koleksiyon yanında küçük-büyük içerisine yazıyoruz.
    //  Sınıfı yazdığımızda ona ait bir isim veriyoruz.Zaten kendisi öneri veriyor(headings)
    //  Aynı işlemi ilişki kurduğumuz sınıfa da yazmamız gerekiyor
    }
}
