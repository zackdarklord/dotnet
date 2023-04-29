using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff :Passenger
    {
        public DateTime EmployementDate { get; set; }   
        public String Funcction { get; set; }
        [DataType(DataType.Currency)]
        public float Salary { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
        public override void PassengerType()
        {
            Console.WriteLine("Iam a Staff \n");
        }
    }
}
