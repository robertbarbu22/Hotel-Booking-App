using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.HotelRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RestaurantRepo;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RestaurantService
{
    public class RestaurantService : IRestaurantService
    {
        private IRestaurantRepository _restaurantRepository;
        private IMapper _mapper;

        public RestaurantService(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        
        }

        public async Task<List<RestaurantDTO>> GetAllRestaurante()
        {
            var restaurante = await _restaurantRepository.GetAll();
            var restauranteDTO = _mapper.Map<List<RestaurantDTO>>(restaurante);
            return restauranteDTO;
        }

        public void DeleteAll()
        {
            _restaurantRepository.DeleteAll();
            _restaurantRepository.Save();
        }
    }
}
