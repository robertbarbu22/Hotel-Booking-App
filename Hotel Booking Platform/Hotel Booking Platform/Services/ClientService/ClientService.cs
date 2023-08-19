using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.ClientRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ClientDTO> GetClientById(Guid id)
        {
            var client = _clientRepository.GetClientById(id);
            return _mapper.Map<ClientDTO>(client);
        }

        public async Task<ClientDTO> GetClientByNume(string nume)
        {
            var client = _clientRepository.GetClientByNume(nume);
            return _mapper.Map<ClientDTO>(client);
        }

        public async Task CreateClient(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            await _clientRepository.CreateAsync(client);
            await _clientRepository.SaveAsync();
        }

        public async Task<List<ClientDTO>> GetAllClients()
        {
            var clients = await _clientRepository.GetAll();
            return _mapper.Map<List<ClientDTO>>(clients);
        }

        public void DeleteClient(Guid id)
        {
            var client = _clientRepository.GetClientById(id);
            _clientRepository.Delete(client);
            _clientRepository.Save();
        }

        public void DeleteAll()
        {
            _clientRepository.DeleteAll();
            _clientRepository.Save();
        }
    }
}
