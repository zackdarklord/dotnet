using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
/*
Plane plane = new Plane();
Passenger passenger = new Passenger();  
Staff staff = new Staff();  
Traveller traveller = new Traveller();
passenger.PassengerType();
staff.PassengerType();
traveller.PassengerType();
*/

ServiceFlight serviceFlight = new ServiceFlight();
serviceFlight.Flights = TestData.listFlights;
