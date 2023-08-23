using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class AngajatSeeder
    {
        public readonly DBContext _context;
        public AngajatSeeder(DBContext context)
        {
            _context = context;
        }

        public void SeedAngajat()
        {
            if (!_context.Angajati.Any())
            {
                var angajat1 = new Angajat
                {
                    Nume = "Popescu",
                    Prenume = "Ion",
                    Functie = "Receptioner",
                    Telefon = "0722222222",
                    Salariu = 2000,
                    NumeHotel = "Iaki",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Iaki").Id,
                    NumeDepartament = "Receptie",
                    DepartamentId = _context.Departamente.FirstOrDefault(d => d.Nume == "Receptie").Id
                };

                var angajat2 = new Angajat
                {
                    Nume = "Ionescu",
                    Prenume = "Mihai",
                    Functie = "Receptioner",
                    Telefon = "0722222232",
                    Salariu = 2000,
                    NumeHotel = "Iaki",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Iaki").Id,
                    NumeDepartament = "Receptie",
                    DepartamentId = _context.Departamente.FirstOrDefault(d => d.Nume == "Receptie").Id
                };


                var angajat3 = new Angajat
                {
                    Nume = "Popa",
                    Prenume = "Andrei",
                    Functie = "Gunoier",
                    Telefon = "0735289018",
                    Salariu = 1500,
                    NumeHotel = "Vega",
                    HotelId = _context.Hoteluri.FirstOrDefault(h => h.Nume == "Vega").Id,
                    NumeDepartament = "Curatenie",
                    DepartamentId = _context.Departamente.FirstOrDefault(d => d.Nume == "Curatenie").Id
                };

                _context.Angajati.Add(angajat1);
                _context.Angajati.Add(angajat2);
                _context.Angajati.Add(angajat3);
                _context.SaveChanges();
            }
            
            
        }
    }
}
