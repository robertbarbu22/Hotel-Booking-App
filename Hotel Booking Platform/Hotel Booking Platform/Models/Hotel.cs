using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Hotel : BaseEntity
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public ICollection<Camera> Camere { get; set; }
        public ICollection<Rezervare> Rezervari { get; set; }
        public ICollection<Angajat> Angajati { get; set; }
        public Guid? RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<HotelClient> HotelClient { get; set; }
    }
}
