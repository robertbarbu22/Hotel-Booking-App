using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders
{
    public class DepartamentSeeder
    {
        public readonly DBContext _context;
        
        public DepartamentSeeder(DBContext context)
        {
            _context = context;
        }

        public void SeedDepartament()
        {
            if(!_context.Departamente.Any())
            {
                var departament1 = new Departament
                {
                    Nume = "Receptie",
                    NrAngajati = 10
                };

                var departament2 = new Departament
                {
                    Nume = "Curatenie",
                    NrAngajati = 20
                };

                var departament3 = new Departament
                {
                    Nume = "Bucatarie",
                    NrAngajati = 15
                };


                _context.Departamente.Add(departament1);
                _context.Departamente.Add(departament2);
                _context.Departamente.Add(departament3);
                _context.SaveChanges();
            }
        }
    }
}
