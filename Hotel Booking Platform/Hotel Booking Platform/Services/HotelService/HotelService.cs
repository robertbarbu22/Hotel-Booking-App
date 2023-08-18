using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.HotelRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.HotelService
{
    public class HotelService: IHotelService
    {
        private IHotelRepository _hotelRepository;
        private IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        public async Task<List<HotelDTO>> GetAllHotels()
        {
            var hotels = await _hotelRepository.GetAllHotels();
            return _mapper.Map<List<HotelDTO>>(hotels);
        }

        public async Task<HotelDTO> GetHotelById(Guid id)
        {
            var hotel = _hotelRepository.GetHotelById(id);
            return _mapper.Map<HotelDTO>(hotel);
        }

        public async Task<HotelDTO> GetHotelByNume(string nume)
        {
            var hotel = _hotelRepository.GetHotelByNume(nume);
            return _mapper.Map<HotelDTO>(hotel);
        
        
        }
        public void DeleteHotel(Guid id)
        {
            var hotel = _hotelRepository.GetHotelById(id);
            _hotelRepository.Delete(hotel);
            _hotelRepository.Save();
        }
        
        public void DeleteAll()
        {
            _hotelRepository.DeleteAll();
            _hotelRepository.Save();
        }

    }
}
