using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//Soru; EntityFrameworkte değişiklikllerin kaydedilmesi için kullanılan SaveChanges metodunun
//Clasic Ado.net komutlarındaki karşılığı nedir?
//Değişiklikler kaydedilsin diye adonette ne kullanılır.

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
           _object.Remove(p);//p parametresinden gelen veriyi object nesnesinden sil
            c.SaveChanges();// Contexte değişiklikleri kaydet

        }

        public void Insert (Category p)
        {
            _object.Add(p);//p parametresinden gelen veriyi object nesnesine ekle
            c.SaveChanges();//Contexte değişiklikleri kaydet
        }

        public void Update(Category p)
        {
            c.SaveChanges();//Direkt olarak Contexte değişiklikleri kaydet
        }
        public List<Category> List() 
        {
            return _object.ToList();
            //objectden gelen verileri ToList() metodunda listele
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }    
 }
/*    ----EntityFrameworkte kullanılan diğer methodlar
 *    
 *    ToList = Listelemek için
 *    Add = Ekleme işlemleri için
 *    Remove = Silme işlemleri için
 *    Find = Bulma işlemleri için
 */