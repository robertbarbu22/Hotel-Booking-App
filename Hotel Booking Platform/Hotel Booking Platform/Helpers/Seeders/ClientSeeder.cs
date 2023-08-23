using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Microsoft.Extensions.Configuration;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class ClientSeeder
    {
        public readonly DBContext _context;

        public ClientSeeder(DBContext context)
        {
            _context = context;
        }

        public void SeedClient()
        {
            if(!_context.Clienti.Any())
            {
                var client1 = new Client
                {
                    Nume = "Chiriac",
                    Prenume = "Ella",
                    Email = "ella@ella.ro",
                    Telefon = "1234"
                };

                var client2 = new Client
                {
                    Nume = "Barbu",
                    Prenume = "Robert",
                    Email = "robi@robi.ro",
                    Telefon = "2345"
                };

                _context.Clienti.Add(client1);
                _context.Clienti.Add(client2);
                _context.SaveChanges();
            }
        }
    }
}
