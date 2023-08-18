using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.HotelService
{
    public interface IHotelService
    {
        Task<HotelDTO> GetHotelById(Guid id);
        Task<HotelDTO> GetHotelByNume(string nume);
        void DeleteHotel(Guid id);
        Task<List<HotelDTO>> GetAllHotels();
        void DeleteAll();
    }
}
