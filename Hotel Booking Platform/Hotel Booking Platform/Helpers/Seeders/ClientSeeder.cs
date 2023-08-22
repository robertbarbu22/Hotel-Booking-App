using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
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

        }
    }
}
