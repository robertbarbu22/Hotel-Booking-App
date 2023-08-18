using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.AngajatRepo
{
    public interface IAngajatRepository : IGenericRepository<Angajat>
    {
        Angajat GetAngajatById(Guid id);
        Angajat GetAngajatByNume(string nume);
        public Task<List<Angajat>> GetAngajatiByDepartamentId(Guid id);
        public Task<List<Angajat>> GetAngajatiByHotelId(Guid id);
        public Task<List<Angajat>> GetAllAngajati();
    }
}
