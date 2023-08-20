using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.JwtUtilsHelp;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.UserRepo;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private readonly IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task CreateUser(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }

        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = _userRepository.GetByUsername(model.Username);

            if (user == null || !BCryptNet.Verify(model.Parola, user.Parola))
            {
                return null;
            }
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, jwtToken);
        }
    }
}
