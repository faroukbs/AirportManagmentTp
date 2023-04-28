using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Interface
{
    public interface IRepository <T> where T : class
    {
      void  Add(T t);

        T Get (int id);
        T Get(string id);
        void Upadate(T t);
        void Delete(T t);
        IList<T> GetAll();
        //void Commit();

    }
}
