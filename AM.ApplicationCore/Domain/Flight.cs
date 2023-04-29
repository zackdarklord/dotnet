using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
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
        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
        public virtual Plane Plane { get; set; }
        [AllowNull]
        public string Airline { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set;}
        public virtual ICollection<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return "flight : " + Destination + " " + Departure + " " + FlightDate + " " + FlightID;
        }

    }
}
