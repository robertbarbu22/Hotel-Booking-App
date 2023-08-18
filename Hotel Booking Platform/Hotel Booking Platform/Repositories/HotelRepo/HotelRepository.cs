using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.HotelRepo
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(DBContext context) : base(context)
        {
        }

        public Hotel GetHotelById(Guid id)
        {
            return _context.Hoteluri.FirstOrDefault(x => x.Id == id);
        }

        public Hotel GetHotelByNume(string nume)
        {
            return _context.Hoteluri.FirstOrDefault(x => x.Nume == nume);
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            return _context.Hoteluri.ToList();
        }
    }
}
