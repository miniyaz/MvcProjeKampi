using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


//BU SINIF SAYESİNDE CATEGORY GİBİ TEK TEK YAZMAMA GEREK YOK
//BU SINIF SAYESİNDE BÜTÜN SINIFLARIMDAN BÜTÜN İNTERFACELERİMDEN GEÇERLİ OLAN MİMARİYİ KURMAYA BAŞLADIM
namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    //GenericRepository sınıfı IRepository<T> interfaceinde tanımlanan tüm methodları içermek zorundadır.
    //(Where T:Class ==> bu constraint(kısıtlama), T tip parametresinin sadece referans tiplerinin(class) olacağını belirtir
    //yani t tipi int,double gibi değerler olamaz
    {
        Context c = new Context();//entity frameworkte veritabanı ile etkişim kurmak için kullanılır.
        //context sınıfınden context nesnesi oluşturdum.

        DbSet<T> _object;//entity frameworkte bir tabloyu temsil eden generic sınıfı
        //Belirli bir tabloya gelen bir DbSet nesnesi oluşturulur(_object) ve bu değişken belirli bir
        //tabloya karşılık gelecektir.

        public GenericRepository()// cto yazıp 2 defa tab tuşuna bastım.
        {
            //object nednesinin içine değer ataması yapmam gerekiyor.
            //Bunun için contexte bağlı olan t değeri objecte ait yeni değerdir diyorum.
            _object = c.Set<T>();
        }

        public void Delete(T p)// t sınıfından bir parametre al
        {
            _object.Remove(p);// objectteki DbSet nesnesindeki tabloda p parametresine al ve veritabanında 
            //remove ile objectteki tablodan sil
            c.SaveChanges();// contexxte değişiklikleri kaydet
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();//objectten gelen ögeleri to list metoduyla döndür.
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
