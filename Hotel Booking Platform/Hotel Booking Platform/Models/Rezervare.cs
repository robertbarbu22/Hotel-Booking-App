using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Rezervare : BaseEntity
    {
        public Guid? HotelId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? CameraId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Pret { get; set; }
    }
}
