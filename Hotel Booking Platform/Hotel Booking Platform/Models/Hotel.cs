using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Hotel : BaseEntity
    {

        string Nume { get; set; }
        string Adresa { get; set; }
        string Telefon { get; set; }


    }
}
