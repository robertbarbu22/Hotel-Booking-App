using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.DepartamentService
{
    public interface IDepartamentService
    {
        Task<List<DepartamentDTO>> GetAllDept();
        void DeleteAll();
    }
}
