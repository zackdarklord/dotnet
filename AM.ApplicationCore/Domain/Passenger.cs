using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]
        public long PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }
        [MinLength(3,ErrorMessage = "min 3 caracteres")]
        [MaxLength(25,ErrorMessage ="max 25 caracteres")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Telephone number must be 8 digits")]
//8 digits        
        public long TelNumber { get; set; }
        public FullName FullName { get; set; }  

        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

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
