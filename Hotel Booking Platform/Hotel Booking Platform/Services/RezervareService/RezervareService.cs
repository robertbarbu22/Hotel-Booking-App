using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RezervareRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RezervareService
{
    public class RezervareService: IRezervareService
    {
        private IRezervareRepository _rezervareRepository;
        private IMapper _mapper;

        public RezervareService(IRezervareRepository rezervareRepository, IMapper mapper)
        {
            _rezervareRepository = rezervareRepository;
            _mapper = mapper;
        }

        public async Task<RezervareDTO> CreateRezervare(RezervareDTO rezervare)
        {
            var rezervareModel = _mapper.Map<Rezervare>(rezervare);
            var rezervareCreated = _rezervareRepository.CreateAsync(rezervareModel);
            return _mapper.Map<RezervareDTO>(rezervareCreated);
        }
        
        public void UpdateCheckin(RezervareDTO rezervare, DateTime datacheckin)
        {
            var rezervareModel = _mapper.Map<Rezervare>(rezervare);
            rezervareModel.CheckIn = datacheckin;

            _rezervareRepository.Update(rezervareModel);
            _rezervareRepository.Save();
        }

        public void UpdateCheckout(RezervareDTO rezervare, DateTime datacheckout)
        {
            var rezervareModel = _mapper.Map<Rezervare>(rezervare);
            rezervareModel.CheckOut = datacheckout;

            _rezervareRepository.Update(rezervareModel);
            _rezervareRepository.Save();
        }
        
        public async Task<RezervareDTO> GetRezervare(Guid id)
        {
            var rezervare = await _rezervareRepository.FindByIdAsync(id);
            return _mapper.Map<RezervareDTO>(rezervare);
        }

        public async Task<List<RezervareDTO>> GetAllRezervari()
        {
            var rezervari = await _rezervareRepository.GetAll();
            return _mapper.Map<List<RezervareDTO>>(rezervari);
        }

        public void DeleteRezervare(Guid id)
        {
            var rezervare = _rezervareRepository.FindById(id);
            _rezervareRepository.Delete(rezervare);
            _rezervareRepository.Save();
        }

        public void DeleteAll()
        {
            _rezervareRepository.DeleteAll();
            _rezervareRepository.Save();
        }
    }
}
