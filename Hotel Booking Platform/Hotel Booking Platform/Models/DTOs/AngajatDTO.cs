
namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class AngajatDTO
    {
        public string NumeHotel { get; set; }
        public string NumeDepartament { get; set; }
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Telefon { get; set; }
        public int Salariu { get; set; }
        public Guid HotelId { get; set; }
        public Guid DepartamentId { get; set; }
        public HotelDTO Hotel { get; set; }
        public DepartamentDTO Departament { get; set; }
    }
}
