using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.CameraRepo
{
    public interface ICameraRepository : IGenericRepository<Camera>
    {
        Camera GetCameraById(Guid id);
        public Task<List<Camera>> GetCamereByHotelId(Guid id);
        public Task<List<Camera>> GetAllCamere();
    }
}
