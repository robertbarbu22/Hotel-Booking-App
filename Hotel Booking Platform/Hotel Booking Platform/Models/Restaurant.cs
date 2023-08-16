using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Restaurant : BaseEntity
    {
        public Hotel? Hotel { get; set; }
        public int NrLocuri { get; set; }
    }
}
