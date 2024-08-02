using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    //Category ile ilgili işlemleri yapacak veya kontrol edecek yönetici
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        //Bu, daha önce tanımlanmış bir generic sınıfın (GenericRepository) "Category" tipinde bir örneğini temsil eder.
        //Bu sayede, Category nesneleri ile ilgili veritabanı işlemleri bu nesne üzerinden yapılacaktır.

        //repo: Bu, oluşturulan nesnenin bir referansını tutan bir değişkendir.
        //Yani, Category ile ilgili işlemler yaparken bu "repo" değişkeni üzerinden işlemler yapacağız.

        public List<Category> GetAllBL()//tüm kategorileri liste halinde döndürür.
        {
            return repo.List();//category sınıfı için ürettiğimiz repo üzerinden
            //gelen verileri list metoduyla döndür

            //daha önce oluşturulan "repo" nesnesinin tüm kategorileri listeleyen metodunu çağırır
            //ve dönen sonucu bu metodun sonucu olarak döndürür.
        }
        public void CategoryAddBL(Category p)
        //public void: Bu metot, bir kategori ekleme işlemi yapar ve herhangi bir değer döndürmez.
        //Category p: Bu metot, eklemek istediğimiz kategori bilgisini tutan bir nesne alır.
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
