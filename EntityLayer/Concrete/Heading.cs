using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //public ifadesi diğer sınıflardan ve katmanlardan erişim sağlar  j
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }


        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        //  ilişki kurduğumuz tablonun anahtar sütunu ile aynı isme sahip olması gerekiyor.
        //  Bu şu demek;Heading tablomda categoryId adında sütunum olucak.
        //  CategoryId adlı sütunun ilişki içerisinde olduğunu nasıl öğrenicem?

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }


    }
}
