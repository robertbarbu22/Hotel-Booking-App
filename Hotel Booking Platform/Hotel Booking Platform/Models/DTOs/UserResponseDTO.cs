namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class UserResponseDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Username { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        
        public UserResponseDTO(User user, string token)
        {
            Id = user.Id;
            Nume = user.Nume;
            Prenume = user.Prenume;
            Username = user.Username;
            Telefon = user.Telefon;
            Email = user.Email;
            Token = token;
        }
    }
}
