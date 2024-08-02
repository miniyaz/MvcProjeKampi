using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NOT; YAZILIMDA DRY KAVRAMI NEDİR ARAŞTIR.
namespace EntityLayer.Concrete
{
    public class Writer // Yazar sınıfı ve ona ait olan özellikler
    {
        [Key] // WriterId adındaki özelliğin bu sınıfın anahtar(primary key) niteliğinde olduğunu belirtir.
        public int WriterId { get; set; }

        [StringLength(50)] //maksimum uzunlukları 50 karakter olduğunu belirtir.
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }

        public ICollection<Heading> Headings { get; set; }//bir yazarın birden fazla başlığa sahip olabileceğini belirtir.
        public ICollection<Content> Contents { get; set; }
    }
}
