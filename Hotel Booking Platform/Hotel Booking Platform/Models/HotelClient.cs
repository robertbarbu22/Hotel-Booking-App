namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class HotelClient
    {
        public Guid? Id { get; set; }
        public Guid HotelId { get; set; }
        public Guid ClientId { get; set; }
        public Hotel Hotel { get; set; }
        public Client Client { get; set; }
    }
}
