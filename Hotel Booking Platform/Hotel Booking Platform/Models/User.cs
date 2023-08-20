using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Roles;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class User : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Username { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public Role Role { get; set; }
    }
}
