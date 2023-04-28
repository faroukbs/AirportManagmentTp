using AM.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly AMContext context;

        //DI
        public UnitOfWork(AMContext context)
        {
            this.context = context;
        }
        //garabage collector memoire optimisation 
        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(context) ;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
