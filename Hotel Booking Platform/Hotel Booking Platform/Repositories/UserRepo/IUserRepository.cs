using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.UserRepo
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUsername(string username);
    }
}
