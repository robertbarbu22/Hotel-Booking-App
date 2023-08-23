namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class RestaurantDTO
    {
        public string Nume { get; set; }
        public Guid Id { get; set; }
        public int NrLocuri { get; set; }
        public Guid HotelId { get; set; }
        public HotelDTO Hotel { get; set; }
    }
}
