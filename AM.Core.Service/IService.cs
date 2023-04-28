using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Service
{
    public interface IService<T> where T : class
    {
         void  Add(T t);

        T Get (int id);
        void Upadate(T t);
        void Delete(T t);
        IList<T> GetAll();

    }
}
