using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.UserService
{
    public interface IUserService
    {
        UserResponseDTO Authenticate(UserRequestDTO model);
        Task<List<User>> GetAllUsers();
        User GetById(Guid id);
        Task CreateUser(User user);
    }
}
