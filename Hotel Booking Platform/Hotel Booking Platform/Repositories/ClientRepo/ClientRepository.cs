using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.ClientRepo
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(DBContext context) : base(context)
        {
            
        }

        public Client GetClientById(Guid id)
        {
            return _context.Clienti.FirstOrDefault(x => x.Id == id);
        }

        public Client GetClientByNume(string nume)
        {
            return _context.Clienti.FirstOrDefault(x => x.Nume == nume);
        }

        public async Task<List<Client>> GetAllClienti()
        {
            return _context.Clienti.ToList();
        }
        
        
    }
}
