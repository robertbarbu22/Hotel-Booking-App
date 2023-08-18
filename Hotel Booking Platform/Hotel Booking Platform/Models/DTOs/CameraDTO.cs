namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class CameraDTO
    {
        public Guid Id { get; set; }
        public int NrCamera { get; set; }
        public int NrPersoane { get; set; }
        public Guid HotelId { get; set; }
        public HotelDTO Hotel { get; set; }
        
    }
}
