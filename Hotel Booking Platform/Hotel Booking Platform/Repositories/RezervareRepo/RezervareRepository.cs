using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RezervareRepo
{
    public class RezervareRepository : GenericRepository<Rezervare>, IRezervareRepository
    {
        public RezervareRepository(DBContext context) : base(context)
        {
        }

        public Rezervare GetRezervareById(Guid id)
        {
            return _context.Rezervari.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<Rezervare>> GetRezervariByClientId(Guid id)
        {
            return _context.Rezervari.Where(x => x.ClientId == id).ToList();
        }

        public async Task<List<Rezervare>> GetRezervariByHotelId(Guid id)
        {
            return _context.Rezervari.Where(x => x.HotelId == id).ToList();
        }
        
        public async Task<List<Rezervare>> GetAllRezervari()
        {
            return _context.Rezervari.ToList();
        }
    }
}
