using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class UserRequestDTO
    {
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        [Required]
        public string Username { get; set; }
        public string? Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Parola { get; set; }
    }
}
