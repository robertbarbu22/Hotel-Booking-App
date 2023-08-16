namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class HotelDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public ICollection<CameraDTO> Camere { get; set; }
        public ICollection<RezervareDTO> Rezervari { get; set; }
        public ICollection<AngajatDTO> Angajati { get; set; }
        public ICollection<ClientDTO> Clienti { get; set; }
        public RestaurantDTO Restaurant { get; set; }
    }
}
