using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Camera : BaseEntity
    {
        public Guid? Id { get; set; }
        public Guid? HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public int NrCamera { get; set; }
        public int NrPersoane { get; set; }
    }
}
