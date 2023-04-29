using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
/*
Plane plane = new Plane();
Passenger passenger = new Passenger();  
Staff staff = new Staff();  
Traveller traveller = new Traveller();
passenger.PassengerType();
staff.PassengerType();
traveller.PassengerType();
*/

//ServiceFlight serviceFlight = new ServiceFlight();
//serviceFlight.Flights = TestData.listFlights;

AMContext context = new AMContext();
context.Flights.Add(TestData.flight2);
context.SaveChanges();
Console.WriteLine(context.Flights.First().Plane.Capacity);