using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.AngajatService
{
    public interface IAngajatService
    {
        Task<List<AngajatDTO>> GetAllAngajati();
        void DeleteAll();
    }
}
