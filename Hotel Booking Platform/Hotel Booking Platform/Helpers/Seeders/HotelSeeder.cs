using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class HotelSeeder
    {
        public readonly DBContext _context;

        public HotelSeeder(DBContext context)
        {
            _context = context;
        }

        public void SeedHotel()
        {
            if(!_context.Hoteluri.Any())
            {
                var hotel1 = new Hotel
                {
                    Nume = "Vega",
                    Adresa = "Mamaia",
                    Telefon = "0712345678"
                };

                var hotel2 = new Hotel
                {
                    Nume = "Iaki",
                    Adresa = "Mamaia",
                    Telefon = "0712345637"
                };

                var hotel3 = new Hotel
                {
                    Nume = "Malibu",
                    Adresa = "Bucurest",
                    Telefon = "0712345372"
                };

                var hotel4 = new Hotel
                {
                    Nume = "Dorna",
                    Adresa = "Vatra Dornei",
                    Telefon = "071236271"
                };

                var hotel5 = new Hotel
                {
                    Nume = "Bucovina",
                    Adresa = "Vatra Dornei",
                    Telefon = "0712345678"
                };

                _context.Hoteluri.AddRange(hotel1, hotel2, hotel3, hotel4, hotel5);
                _context.SaveChanges();
            }
        }
    }
}
