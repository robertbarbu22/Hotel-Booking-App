using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RestaurantRepo
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Restaurant GetRestaurantById(Guid id);
        Restaurant GetRestaurantByHotelId(Guid id);
        public Task<List<Restaurant>> GetAllRestaurante();
        Restaurant GetRestaurantbyClientId(Guid id);
    }
}
