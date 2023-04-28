using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension 
    {
        public static String UpperFullName(this Passenger passenger)
        {
            string firstName = passenger.FirstName;
            string lastName = passenger.LastName;

            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            return $"{firstName} {lastName}";
        }
    }
}
