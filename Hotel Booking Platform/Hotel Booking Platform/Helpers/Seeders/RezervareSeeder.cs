using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class RezervareSeeder
    {
        public readonly DBContext _context;

        public RezervareSeeder(DBContext context)
        {
            _context = context;
        }

        public void SeedRezervare()
        {
            if(!_context.Rezervari.Any())
            {
                var rez1 = new Rezervare
                {
                    NumeClient = "Ella",
                    NumeHotel = "Iaki",
                    CheckIn = DateTime.Parse("23-09-2023"),
                    CheckOut = DateTime.Parse("30-09-2023")
                };

                var rez2 = new Rezervare
                {
                    NumeClient = "Robert",
                    NumeHotel = "Dorna",
                    CheckIn = DateTime.Parse("05-09-2023"),
                    CheckOut = DateTime.Parse("20-09-2023")
                };

                _context.Rezervari.AddRange(rez1, rez2);
                _context.SaveChanges();
            }
        }
    }
}
