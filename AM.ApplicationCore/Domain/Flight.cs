using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public String Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightID { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public float EstimatedDuration { get; set; }

        public Plane Plane { get; set; }
        public string Airline { get; set; }
        public ICollection<Passenger> Passengers { get; set;}

        public override string ToString()
        {
            return "flight : " + Destination + " " + Departure + " " + FlightDate + " " + FlightID;
        }

    }
}
