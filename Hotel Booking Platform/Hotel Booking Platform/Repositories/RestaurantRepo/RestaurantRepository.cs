using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RestaurantRepo
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(DBContext context) : base(context)
        {
        }

        public Restaurant GetRestaurantById(Guid id)
        {
            return _context.Restaurante.FirstOrDefault(x => x.Id == id);
        }

        public Restaurant GetRestaurantByHotelId(Guid id)
        {
            return _context.Restaurante.FirstOrDefault(x => x.HotelId == id);
        }

        public async Task<List<Restaurant>> GetAllRestaurante()
        {
            return _context.Restaurante.ToList();
        }
    }
}
