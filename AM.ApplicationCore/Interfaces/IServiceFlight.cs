using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {

        public List<Flight> GetFlightDates(string destination) ;
        public void AffichFlights(string filterType, string filterValue);
        public void GetFlightDates();

        public void ShowFlightDetails(Plane plane);

        public int ProgrammedFlightNumber(DateTime startDate);

        public float DurationAverage(string destination);

        public List<Flight> OrderedDurationFlights();

        public List<Passenger> SeniorTravellers(Flight flight);

        public IEnumerable<IGrouping<String, Flight>> DestinationGroupedFlights();
    }
}
