using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.HotelRepo
{
    public interface IHotelRepository : IGenericRepository<Hotel>
    {
        Hotel GetHotelById(Guid id);
        Hotel GetHotelByNume(string nume);
        public Task<List<Hotel>> GetAllHotels();
    }
}
