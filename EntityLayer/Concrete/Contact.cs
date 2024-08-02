using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq; // verileri sorgulama işlemlerini kolaylaştıran fonksiyonları kullanmak için gerekli kütüphaneyi ekler.
using System.Text;
using System.Threading.Tasks;  // asenkron (aynı anda birden fazla işlem yapma) programlama işlemleri için gerekli fonksiyonları kullanabilmek için

namespace EntityLayer.Concrete
{
    public class Contact // İletişim Sınıfı
    {
        [Key] // ContactID adındaki özelliğin bu sınıfın anahtar (primary key) niteliğinde olduğunu belirtir. (Anahtar)
        public int ContactID { get; set; }


        [StringLength(50)] //maksimum uzunlukları 50 karakter olduğunu belirtir.
        public string UserName { get; set; }


        [StringLength(50)]
        public string UserMail { get; set; }


        [StringLength(50)]
        public string Subject { get; set; }


        //[StringLength(1000)]
        public string Message { get; set; } 
    }
}
/*
 * Bu sınıf, bir iletişim formunda toplanacak verileri temsil eder.
 * Bu sınıfın özellikleri, kullanıcının adını, e-posta adresini, iletişim konusunu ve mesajını saklar.
 * Bu sınıf, veritabanına kaydedilecek her bir iletişim kaydı için kullanılabilir.
*/