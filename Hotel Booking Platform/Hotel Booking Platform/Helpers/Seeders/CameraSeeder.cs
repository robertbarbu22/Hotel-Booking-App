using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class CameraSeeder
    {
        public readonly DBContext _context;

        public CameraSeeder(DBContext context)
        {
            _context = context;
        }

        public void SeedCamera()
        {
            if(!_context.Camere.Any())
            {
                var camera1 = new Camera
                {
                    NumeHotel = "Vega",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Vega").Id,
                    NrCamera = 1,
                    NrPersoane = 2
                };

                var camera2 = new Camera
                {
                    NumeHotel = "Vega",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Vega").Id,
                    NrCamera = 2,
                    NrPersoane = 2
                };

                var camera3 = new Camera
                {
                    NumeHotel = "Vega",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Vega").Id,
                    NrCamera = 3,
                    NrPersoane = 3
                };

                var camera4 = new Camera
                {
                    NumeHotel = "Iaki",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Iaki").Id,
                    NrCamera = 1,
                    NrPersoane = 2
                };

                var camera5 = new Camera
                {
                    NumeHotel = "Iaki",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Iaki").Id,
                    NrCamera = 2,
                    NrPersoane = 2
                };

                var camera6 = new Camera
                {
                    NumeHotel = "Malibu",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Malibu").Id,
                    NrCamera = 1,
                    NrPersoane = 3
                };

                var camera7 = new Camera
                {
                    NumeHotel = "Malibu",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Malibu").Id,
                    NrCamera = 2,
                    NrPersoane = 2
                };

                var camera8 = new Camera
                {
                    NumeHotel = "Malibu",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Malibu").Id,
                    NrCamera = 3,
                    NrPersoane = 2
                };

                var camera9 = new Camera
                {
                    NumeHotel = "Dorna",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Dorna").Id,
                    NrCamera = 1,
                    NrPersoane = 2
                };

                var camera10 = new Camera
                {
                    NumeHotel = "Dorna",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Dorna").Id,
                    NrCamera = 2,
                    NrPersoane = 1
                };

                var camera11 = new Camera
                {
                    NumeHotel = "Dorna",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Dorna").Id,
                    NrCamera = 3,
                    NrPersoane = 3
                };

                var camera12 = new Camera
                {
                    NumeHotel = "Bucovina",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Bucovina").Id,
                    NrCamera = 1,
                    NrPersoane = 2
                };

                var camera13 = new Camera
                {
                    NumeHotel = "Bucovina",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Bucovina").Id,
                    NrCamera = 2,
                    NrPersoane = 2
                };

                _context.Camere.AddRange(camera1, camera2, camera3, camera4, camera5, camera6, camera7, camera8, camera9, camera10, camera11, camera12, camera13);
                _context.SaveChanges();
            }
        }
    }
}
