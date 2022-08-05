using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEntityRepository<T>
        //T demek calısacagımız tıp demek 
        //yanı bız t yerine her bır dalda bır entity tablosu gonderecegız demek
    {
        // bizim crud ıslemlerımız burada olacak
        // add metodu
        // delete metodu
        // update metodu
        // get metodu
        void Add(T entity); // C
        void Delete(T entity); // D
        void Update(T entity); // U
        List<T> GetAll(); // R
    }
}
