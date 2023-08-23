using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.AngajatRepo
{
    public class AngajatRepository : GenericRepository<Angajat>, IAngajatRepository
    {
        public AngajatRepository(DBContext context) : base(context)
        {
            
        }

        public Angajat GetAngajatById(Guid id)
        {
            return _context.Angajati.FirstOrDefault(x => x.Id == id);
        }

        public Angajat GetAngajatByNume(string nume)
        {
            return _context.Angajati.FirstOrDefault(x => x.Nume == nume);
        }

        public async Task<List<Angajat>> GetAngajatiByDepartamentId(Guid id)
        {
            return _dbSet.Where(x => x.DepartamentId == id).ToList();
        }

        public async Task<List<Angajat>> GetAngajatiByHotelId(Guid id)
        {
            return _dbSet.Where(x => x.HotelId == id).ToList();
        }

        public async Task<List<Angajat>> GetAllAngajati()
        {
            return _dbSet.ToList();
        }
    }
}
