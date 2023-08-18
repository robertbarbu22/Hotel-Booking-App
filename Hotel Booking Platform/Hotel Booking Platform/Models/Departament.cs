using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Departament : BaseEntity
    {
        public Guid? Id { get; set; }
        public int? NrAngajati { get; set; }
        public string Nume { get; set; }
        public ICollection<Angajat> Angajati { get; set; }
    }
}
