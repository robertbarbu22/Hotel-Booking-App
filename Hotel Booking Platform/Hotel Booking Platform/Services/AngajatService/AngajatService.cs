using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.AngajatRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.AngajatService
{
    public class AngajatService : IAngajatService
    {
        public IAngajatRepository _angajatRepository;
        public IMapper _mapper;

        public AngajatService(IAngajatRepository angajatRepository, IMapper mapper)
        {
            _angajatRepository = angajatRepository;
            _mapper = mapper;
        }
        
        public async Task<List<AngajatDTO>> GetAllAngajati()
        {
            var angajati = await _angajatRepository.GetAllAngajati();
            var angajatiDTO = _mapper.Map<List<AngajatDTO>>(angajati);
            return angajatiDTO;
        }

        public void DeleteAll()
        {
            _angajatRepository.DeleteAll();
            _angajatRepository.Save();
        }

    }
}
