using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;
using System.Linq;

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
            return _dbSet.ToList();
        }

        public Restaurant GetRestaurantbyClientId(Guid id)
        {
            //join cu hotel
            var restaurant = from cl in _context.Clienti
                             join rez in _context.Rezervari on cl.Id equals rez.ClientId
                             join h in _context.Hoteluri on rez.HotelId equals h.Id
                             join r in _context.Restaurante on h.Id equals r.HotelId
                             where cl.Id == id
                             select r;
            return restaurant.FirstOrDefault();
        }
    }
}
