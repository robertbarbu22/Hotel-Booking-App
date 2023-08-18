using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.DepartamentRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.DepartamentService
{
    public class DepartamentService : IDepartamentService
    {
        private IDepartamentRepository _departamentRepository;
        private IMapper _mapper;

        public DepartamentService(IDepartamentRepository departamentRepository, IMapper mapper)
        {
            _departamentRepository = departamentRepository;
            _mapper = mapper;
        }

        public async Task<List<DepartamentDTO>> GetAllDept()
        {
            var departamente = await _departamentRepository.GetAllDepartamente();
            return _mapper.Map<List<DepartamentDTO>>(departamente);
        }

        public void DeleteAll()
        {
            _departamentRepository.DeleteAll();
            _departamentRepository.Save();
        }
    }
}
