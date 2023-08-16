﻿
namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs
{
    public class AngajatDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Telefon { get; set; }
        public int Salariu { get; set; }
        public HotelDTO Hotel { get; set; }
        public DepartamentDTO Departament { get; set; }
    }
}