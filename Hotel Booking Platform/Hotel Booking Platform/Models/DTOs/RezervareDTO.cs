namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class RezervareDTO
    {
        public string NumeHotel { get; set; }
        public int NumeClient { get; set; }
        public Guid Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Pret { get; set; }
        public Guid HotelId { get; set; }
        public Guid ClientId { get; set; }
        public Guid CameraId { get; set; }
        public HotelDTO Hotel { get; set; }
        public ClientDTO Client { get; set; }
        public CameraDTO Camera { get; set; }
    }
}
