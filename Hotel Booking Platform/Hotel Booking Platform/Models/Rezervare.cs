using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Rezervare : BaseEntity
    {
        public string NumeHotel { get; set; }
        public string NumeClient { get; set; }
        public Guid? HotelId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? CameraId { get; set; }
        public Hotel? Hotel { get; set; }
        public Client? Client { get; set; }
        public Camera? Camera { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Pret { get; set; }
    }
}
