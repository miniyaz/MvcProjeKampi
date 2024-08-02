using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        
    }
}
//  Gerek kalmayan yöntem

/*
        //CRUD işlemleri(Create-read-update-delete)
        //Methodun türü ve isminin olması gerekiyor. isminin sonunda () gerek
        // Listeleme işlemi için tür LİST
        List<Category> List();

        
        //ekleme işlemi için void türünde bir ifaede kullandım. Geriye değer döndürmemei için
        //ınsert benim methodumun adı , category kullanacağım sınıf, p de parametremin adı
        void Insert(Category p);//kaydetme methodu
        void Update(Category p);//Güncelleme methodu
        void Delete(Category p);//silme methodu
 */