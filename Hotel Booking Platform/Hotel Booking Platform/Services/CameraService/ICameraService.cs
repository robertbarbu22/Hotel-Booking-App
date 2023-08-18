using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.CameraService
{
    public interface ICameraService
    {
        Task<List<CameraDTO>> GetAllCamere();
        void DeleteAll();
    }
}
