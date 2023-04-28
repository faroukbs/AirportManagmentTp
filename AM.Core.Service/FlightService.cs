using AM.Core.Domain;
using AM.Core.Interface;

namespace AM.Core.Service
{
    public class FlightService : Service<Flight> ,IFlightService
    {
        // IRepository<Flight> flightRepository;
        //readonly IUnitOfWork unitOfWork; 
       
        public IList<Flight> Flights { get; set; }

        public FlightService(IUnitOfWork unitOfWork) : base(unitOfWork) 
        {
            //this.unitOfWork = unitOfWork;
            //flightRepository = unitOfWork.GetRepository<Flight>();

        }
        public IList<DateTime> GetFlightDates(String Destiation)
        {
        //    List<DateTime> dates = new List<DateTime>(); 
         //   foreach (var flight in Flights)
          //  {
            //    if (flight.Destination == Destiation)
              //  {
                //    dates.Add(flight.FlightDate);
                //}
            //}
            //return dates;
            //linQ INTEGRé TP2 Question6
        //    return (from flight in Flights
        //            where flight.Destination == Destiation 
        //            select flight.FlightDate).ToList();
        //2eme methode
        return Flights.Where(f =>f.Destination == Destiation).Select(f =>f.FlightDate).ToList();
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightId":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                default:Console.WriteLine("ERROR");
                    break;
            }
        }
        public void ShowFlightDetails(Plane p)
        {
            //Methode extension
            Console.WriteLine(Flights.Where(f => f.MyPlane.PlaneId == p.PlaneId)
                .Select (f => f.Destination + " " + f.FlightDate));

            //2eme methode LINQ integre
            var result = from f in Flights
                         where f.MyPlane.PlaneId == p.PlaneId
                         select new {f.Destination, f.FlightDate };
            foreach(var f in result)
            {
                Console.WriteLine(f.Destination+""+f.FlightDate);
            }
           }
        public int GetWeeklyFlightNumber(DateTime date)
        {
      
            return Flights.Where(f=>f.FlightDate>=date && f.FlightDate< date.AddDays(7)).Count();
       
        }
        public double GetDurationAverage(String destination)
        {
            return Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).Average();//ou bien sans select directemen,t .Average(f=>f.EstimatedDuration);
        }
        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(f=>f.EstimatedDuration).ToList();  
        }
        public IList<Passenger> GetThreeOlderTravellers(Flight f)
        {

            //return f.passengers.OrderByDescending(p => p.Age).Take(3).ToList();
            return null;
            }
        public void ShowGroupedFlights()
        {
            var result = from f in Flights
                         group f by f.Destination;
            //Ienumerable<IGROUPING<String//cle,group//flight>>
            foreach (var group in result) {
                Console.WriteLine(group.Key);
                foreach (var f in group)
                    Console.WriteLine(f);
            }
        }
        public Passenger GetSeniorPassenger(IFlightService.GetScore meth)
        {
            //return (Passenger)Flights.SelectMany(f => f.passengers.OrderByDescending(p => meth(p)).Take(1));
            return null;
        }

        //public void Add(Flight flight)
        //{
        //    flightRepository.Add(flight);
        //    unitOfWork.Save();
        //}

        //public void Remove(Flight flight)
        //{
        //    flightRepository.Delete(flight);
        //    unitOfWork.Save();
        //}

        //public IList<Flight> GetAll()
        //{
        //   return flightRepository.GetAll();
        //}
    }
}