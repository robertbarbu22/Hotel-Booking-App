using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.CameraRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.CameraService
{
    public class CameraService : ICameraService
    {
        private ICameraRepository _cameraRepository;
        private IMapper _mapper;

        public CameraService(ICameraRepository cameraRepository, IMapper mapper)
        {
            _cameraRepository = cameraRepository;
            _mapper = mapper;
        }

        public async Task<List<CameraDTO>> GetAllCamere()
        {
            var camere = await _cameraRepository.GetAllCamere();
            var camereDTO = _mapper.Map<List<CameraDTO>>(camere);
            return camereDTO;
        }

        public void DeleteAll()
        {
            _cameraRepository.DeleteAll();
            _cameraRepository.Save();
        }

    }
}
