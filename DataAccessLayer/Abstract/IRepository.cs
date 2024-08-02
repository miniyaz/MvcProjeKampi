using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    // T= type= tür 
    //Bir entity varlığını karşılayacak.Yani biz sql'den ne gönderirsek onu karşılayacak.

    //Bunu yapmamızın nedeni her yeni tablolar için aynı işlemi yapmamak.
    //Bir tek T değeriyle hangi tablonun ne olduğunu anlayacak.
    {
        List<T> List();//T'den gelen verileri listele
        void Insert(T p);//T'den gelen parametreyi kaydet
        void Delete(T p);//T'den gelen parametreyi sil
        void Update(T p);//T'den gelen parametreyi güncelle
        List<T> List(Expression<Func<T, bool>> filter);
        // T içindeki ögeleri belirli bir koşula göre filtreleyip, koşulu sağlayıp sağlmadığını bool değere
        //dönüştüren Lambda ifadeleri sayesinde filtreleme koşullarını esnek ve okunaklı hale getiren method
    }
}
