using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public float Prix { get; set; } 
        public string Siege { get; set; } 
        public Boolean Vip { get; set; } 

        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }

        public long PassengerFK { get; set; }
        public int FlightFK { get; set; }
    }
}
