using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Client : BaseEntity
    {
        public Guid? Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public ICollection<Rezervare> Rezervari { get; set; }
        public ICollection<HotelClient> HotelClient { get; set; }
    }
}
