using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RestaurantService
{
    public interface IRestaurantService
    {
        Task<List<RestaurantDTO>> GetAllRestaurante();
        void DeleteAll();
    }
}
