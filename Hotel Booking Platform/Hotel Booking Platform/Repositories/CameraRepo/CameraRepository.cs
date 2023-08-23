using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.CameraRepo
{
    public class CameraRepository : GenericRepository<Camera>, ICameraRepository
    {
        public CameraRepository(DBContext context) : base(context)
        {
            
        }

        public Camera GetCameraById(Guid id)
        {
            return _context.Camere.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<Camera>> GetCamereByHotelId(Guid id)
        {
            return _dbSet.Where(x => x.HotelId == id).ToList();
        }

        public async Task<List<Camera>> GetAllCamere()
        {
            return _dbSet.ToList();
        }
    }
}
