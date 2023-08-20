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
                    Salariu = 2000
                };

                var angajat2 = new Angajat
                {
                    Nume = "Ionescu",
                    Prenume = "Mihai",
                    Functie = "Receptioner",
                    Telefon = "0722222232",
                    Salariu = 2000
                };

            }
        }
    }
}
