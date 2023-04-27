using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
         
        //Duration en terme de minutes 
        public int EstimatedDuration { get; set; }
        [ForeignKey("MyPlane")]
        public int? PlaneId { get; set; }
        //ou bien :[ForeighKey("PlaneId")]
        
        public virtual Plane? MyPlane { get; set; } //virtual: activer le lazyloadig
        //public IList<Passenger> passengers { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        public override string ToString()
        {
            return "Destination:" + Destination + ";Departure:" + Departure + ";FlightDate" + FlightDate + ";EffectiveArrival:" + EffectiveArrival + ";EstimationDuration:" + EstimatedDuration;
        }
    }
}
