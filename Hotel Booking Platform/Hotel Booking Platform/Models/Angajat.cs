using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Angajat : BaseEntity
    {
        public Hotel? Hotel { get; set; }
        public Departament? Departament { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Telefon { get; set; }
        public int Salariu { get; set; }
    }
}
