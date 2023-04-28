using AM.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly AMContext context;

        //DI
        public Repository(AMContext context)
        {
            this.context = context;
        }
        public void Add(T t)
        {
         context.Add(t);
           
        }

        //for code optimisation 
        //public void Commit()
        //{
        //    context.SaveChanges();
        //}

        public void Delete(T t)
        {
            context.Remove(t);
          
        }

        public T Get(int id)
        {
            return (T)context.Find(typeof(T), id);
             
        }

        public T Get(string id)
        {
            return (T)context.Find(typeof(T), id);
        }

        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Upadate(T t)
        {
           context.Update(t);
        }
    }
}
