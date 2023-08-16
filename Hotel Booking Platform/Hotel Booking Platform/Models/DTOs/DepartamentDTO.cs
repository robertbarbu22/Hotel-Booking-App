namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class DepartamentDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string NrAngajati { get; set; }
        public ICollection<AngajatDTO> Angajati { get; set; }
    }
}
