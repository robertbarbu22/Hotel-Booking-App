namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class RestaurantDTO
    {
        public Guid Id { get; set; }
        public int NrLocuri { get; set; }
        public HotelDTO Hotel { get; set; }
    }
}
