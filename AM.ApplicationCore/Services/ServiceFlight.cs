using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        
        public List<Flight> Flights = new List<Flight>();
        
        public ServiceFlight() {
            FlightDetailsDel flightDetailsDel = ShowFlightDetails;
            DurationAverageDel durationAverageDel = DurationAverage;

        }
        public List<Flight> GetFlightDates(string destination)
        {

            List<Flight> FlightsD =new List<Flight>();
           /* for ( int i = 0; i < Flights.Count; i++ ) {
               if (this.Flights[i].Destination == destination )
                {
                    FlightsD.Add(Flights[i] );  
                }
               }*/

            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    FlightsD.Add(flight);   
                }
            }
            return FlightsD;
        }

        public void AffichFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                    //other cases

                default:
                    Console.WriteLine("enter the filter type\n");
                    break;
            }
        }
        //LINQ

        public void GetFlightDates()
        {
           List<DateTime>Dates=Flights.Select(f => (f.FlightDate)).ToList();
            foreach (DateTime d in Dates)
            {
                Console.WriteLine(d);
            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            List<String>Destianations=Flights.Where(f=>f.Plane==plane).Select(f=>f.Destination).ToList();
            foreach(String Destianation in Destianations) { Console.WriteLine(Destianation); }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            return Flights.Where(f => f.EffectiveArrival == startDate.AddDays(7)).Count();
            
        }

        public float DurationAverage(string destination)
        {
            return Flights.Where(f=>f.Destination==destination).Select(f => f.EstimatedDuration).Average();

        }

        public List<Flight> OrderedDurationFlights()
        {
            return Flights.OrderBy(f=>f.EstimatedDuration).ToList();
        }

        public List<Passenger> SeniorTravellers(Flight flight)
        {
            return flight.Passengers.OrderBy(p => p.BirthDate).Take(3).ToList();
        }

        public IEnumerable<IGrouping<String,Flight>> DestinationGroupedFlights()
        {
            return Flights.GroupBy(f => f.Destination);
        }

        public delegate void FlightDetailsDel (Plane plane);
        public delegate float DurationAverageDel(String str);

        //LINQ predifinies

        public List<Passenger> SeniorTravellersP(Flight flight)
        {
            return (from f in flight.Passengers orderby f.BirthDate select f ).Take(3).ToList() ; 
        }
    }

  
}
