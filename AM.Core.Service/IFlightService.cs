using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Service
{
    public interface IFlightService
    {
        //tp2 13-a:
        public delegate int GetScore(Passenger p);
        //
        IList<DateTime> GetFlightDates(String Destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane p);
        int GetWeeklyFlightNumber(DateTime StartDate);
        double GetDurationAverage(String destination);
        IList<Flight> SortFlights();
        IList<Passenger> GetThreeOlderTravellers(Flight f);
        void ShowGroupedFlights();
        Passenger GetSeniorPassenger(GetScore meth);
    }
}
