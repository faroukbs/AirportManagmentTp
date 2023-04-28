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
        readonly IRepository<Plane> planeRepo;


        public PlaneService(IRepository<Plane> planeRepo)
        {
            this.planeRepo = planeRepo;

        }
        public void Add(Plane p)
        {
            planeRepo.Add(p);
            planeRepo.Commit();
        }

        public void Delete(Plane p)
        {
            planeRepo.Delete(p);
            planeRepo.Commit();
        }

        public IList<Plane> GetAll()
        {
            return planeRepo.GetAll();
        }
    }
}
