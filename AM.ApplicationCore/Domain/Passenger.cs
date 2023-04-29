using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public long PassportNumber { get; set; }
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public long TelNumber { get; set; }

        public List<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "passenger : " + BirthDate + " " + FirstName + " " + LastName + " " + TelNumber;
        }

        public Boolean CheckProfile(String nom, String prenom) { return nom == this.FirstName && prenom == this.LastName; }
        public Boolean CheckProfile(String nom, String prenom,String Email) { return nom == this.FirstName && prenom == this.LastName && Email == this.EmailAddress; }
        public Boolean CheckProfileR(String nom, String prenom,String Email) {
            if (Email==null) return nom == this.FirstName && prenom == this.LastName; 
            return nom == this.FirstName && prenom == this.LastName && Email == this.EmailAddress; }
       
        public virtual void PassengerType()
        {
            Console.WriteLine("Iam a passenger \n");
        }
        
    }
}
