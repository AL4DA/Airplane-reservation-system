namespace Flight_Management_System;

class Program
{
    static void Main(string[] args)
    {
        List<Flight> flights = new List<Flight>()
        {
            new FlightReservationSystem(){FlightNumber = "FLR102",DepartureCity = "Tbilisi",ArrivalCity = "New York",DepartureTime = DateTime.Now,AvailableSeats = 12},
            new FlightReservationSystem(){FlightNumber = "JET456",DepartureCity = "Batumi",ArrivalCity = "Toronto,",DepartureTime = DateTime.Now,AvailableSeats = 3}
        };
        List<Reservation> reservations = new List<Reservation>();

        int manage = 0;
        string DepartureCity;
        string ArrivalCity;
        while (manage != 4)
        {
            Console.WriteLine("Flight Reservation System Menu:");
            Console.WriteLine("1. Search for flights");
            Console.WriteLine("2. Book a ticket");
            Console.WriteLine("3. Cancel a reservation");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            manage = int.Parse(Console.ReadLine());

            if (manage == 1)
            {
                FlightReservationSystem flightReservationSystem = new FlightReservationSystem();
                flightReservationSystem.SearchFlights(flights);
            }
            if (manage == 2)
            {
                FlightReservationSystem flightReservationSystem = new FlightReservationSystem();
                flightReservationSystem.BookATicket(flights,reservations);
            }
            if (manage == 3)
            {
                FlightReservationSystem flightReservationSystem = new FlightReservationSystem();
                flightReservationSystem.Cancel(flights,reservations);
            }
        }
    }
}

