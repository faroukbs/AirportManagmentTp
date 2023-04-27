using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boeing=1,
        Airbus=2
    }
    public class Plane
    {
        [Range(0,int.MaxValue,ErrorMessage ="only positive number allowed")]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public virtual IList<Flight>flights { get; set; }
        public Plane()
        {

        }
        /// <summary>
        /// constructeur parametré
        /// 
        /// </summary>
        /// <param name="planeType"></param>
        /// <param name="capacity"></param>
        /// <param name="manufacturedate"></param>
        public Plane(PlaneType planeType, int capacity, DateTime manufacturedate)
        {
            MyPlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufacturedate;
        }
        public override string ToString()
        {
            return "capacity:" + Capacity + ";ManufactureDate:" + ManufactureDate + ";PlaneId:" + PlaneId + ";MyplaneType:" + MyPlaneType ;
        }
    }
}
