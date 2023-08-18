using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.DepartamentRepo
{
    public interface IDepartamentRepository : IGenericRepository<Departament>
    {
        Departament GetDepartamentById(Guid id);
        Departament GetDepartamentByNume(string nume);
        public Task<List<Departament>> GetAllDepartamente();
    }
}
