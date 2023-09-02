using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class ClientDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public ICollection<RezervareDTO>? Rezervari { get; set; }
        public ICollection<HotelDTO>? Hoteluri { get; set; }
    }
}
