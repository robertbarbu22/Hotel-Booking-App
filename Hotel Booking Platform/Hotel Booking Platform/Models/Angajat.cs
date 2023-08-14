﻿using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models
{
    public class Angajat : BaseEntity
    {
        public Guid? HotelId { get; set; }
        public Guid? DepartamentId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Telefon { get; set; }
        public int Salariu { get; set; }
    }
}