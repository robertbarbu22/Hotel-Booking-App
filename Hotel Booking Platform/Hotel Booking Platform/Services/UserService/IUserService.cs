using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        User GetById(Guid id);
        Task CreateUser(User user);
    }
}
