namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class RezervareDTO
    {
        public Guid Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Pret { get; set; }
        public HotelDTO Hotel { get; set; }
        public ClientDTO Client { get; set; }
        public CameraDTO Camera { get; set; }
    }
}
