using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RezervareRepo
{
    public interface IRezervareRepository : IGenericRepository<Rezervare>
    {
        Rezervare GetRezervareById(Guid id);
        public Task<List<Rezervare>> GetRezervariByClientId(Guid id);
        public Task<List<Rezervare>> GetRezervariByHotelId(Guid id);
        public Task<List<Rezervare>> GetAllRezervari();
    }
}
