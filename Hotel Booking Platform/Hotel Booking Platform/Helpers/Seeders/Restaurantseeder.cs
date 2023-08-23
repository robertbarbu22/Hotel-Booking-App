using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Migrations;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class Restaurantseeder
    {
        public readonly DBContext _context;

        public Restaurantseeder(DBContext context)
        {
            _context = context;
        }

        public void SeedRestaurant()
        {
            if(!_context.Restaurante.Any())
            {
                var restaurant1 = new Restaurant
                {
                    Nume = "Vega",
                    NrLocuri = 100,
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Vega").Id
                };

                var restaurant2 = new Restaurant
                {
                    Nume = "Iaki",
                    NrLocuri = 50,
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Iaki").Id
                };

                var restaurant3 = new Restaurant
                {
                    Nume = "Malibu",
                    NrLocuri = 75,
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Malibu").Id
                };

                var restaurant4 = new Restaurant
                {
                    Nume = "Dorna",
                    NrLocuri = 75,
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Dorna").Id
                };

                var restaurant5 = new Restaurant
                {
                    Nume = "Bucovina",
                    NrLocuri = 20,
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Bucovina").Id
                };

                _context.Restaurante.AddRange(restaurant1, restaurant2, restaurant3, restaurant4, restaurant5);
                _context.SaveChanges();
            }
        }
    }
}
