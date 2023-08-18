using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.ClientRepo
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetClientById(Guid id);
        Client GetClientByNume(string nume);
        public Task<List<Client>> GetAllClienti();
    }
}
