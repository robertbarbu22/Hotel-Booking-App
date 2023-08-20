using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.JwtUtilsHelp
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public Guid ValidateJwtToken(string token);
    }
}
