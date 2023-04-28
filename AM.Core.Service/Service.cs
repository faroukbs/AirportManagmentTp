using AM.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Service
{
    public class Service<T> : IService<T> where T : class
    {

        IRepository<T> repo;
        readonly IUnitOfWork unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {

            this.unitOfWork = unitOfWork;
            repo = unitOfWork.GetRepository<T>();
        }
        public void Add(T t)
        {
           repo.Add(t);
            unitOfWork.Save();
        }

        public void Delete(T t)
        {
            repo.Delete(t);
            unitOfWork.Save();
        }

        public T Get(int id)
        {
           return repo.Get(id);
        }

        public IList<T> GetAll()
        {
          return  repo.GetAll();
        }

        public void Upadate(T t)
        {
            repo.Upadate(t);
            unitOfWork.Save();
        }
    }
}
