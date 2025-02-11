﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content // içerik sınıfı
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }
        public int? WriterID { get; set; }
        //yazar ıd boş olabilir. Ben bunu boş geçebilirim. O yüzden ? işareti koydum.
        public virtual Writer Writer { get; set; }
    }
}
