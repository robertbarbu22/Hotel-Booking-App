using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.DepartamentRepo
{
    public class DepartamentRepository : GenericRepository<Departament>, IDepartamentRepository
    {
        public DepartamentRepository(DBContext context) : base(context)
        {
        }

        public Departament GetDepartamentById(Guid id)
        {
            return _context.Departamente.FirstOrDefault(x => x.Id == id);
        }

        public Departament GetDepartamentByNume(string nume)
        {
            return _context.Departamente.FirstOrDefault(x => x.Nume == nume);
        }

        public async Task<List<Departament>> GetAllDepartamente()
        {
            return _dbSet.ToList();
        }
    }
}
