using AM.Core.Domain;
using AM.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Service
{
    public class PlaneService : IPlaneService
    {
       IRepository<Plane> planeRepo;
        readonly IUnitOfWork unitOfWork; 

        public PlaneService(IUnitOfWork unitOfWork)
        {
            
            this.unitOfWork = unitOfWork;
            planeRepo = unitOfWork.GetRepository<Plane>();
        }
        public void Add(Plane p)
        {
            planeRepo.Add(p);
            unitOfWork.Save();
        }

        public void Delete(Plane p)
        {
            planeRepo.Delete(p);
            unitOfWork.Save();
        }

        public IList<Plane> GetAll()
        {
            return planeRepo.GetAll();
        }
    }
}
