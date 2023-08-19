using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.ClientService
{
    public interface IClientService
    {
        Task CreateClient(ClientDTO clientDTO);
        Task<ClientDTO> GetClientById(Guid id);
        Task<ClientDTO> GetClientByNume(string nume);
        void DeleteClient(Guid id);
        Task<List<ClientDTO>> GetAllClients();
        void DeleteAll();
    }
}
