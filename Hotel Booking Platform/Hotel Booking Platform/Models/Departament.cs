using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Departament : BaseEntity
    {
        public Guid? HotelId { get; set; } // departamente dif pt fiecare hotel pt gestiune
        public int? NrAngajati { get; set; }
        public string Nume { get; set; }

        //angajati?
    }
}
