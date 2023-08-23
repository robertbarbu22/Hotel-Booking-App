using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RestaurantRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RestaurantService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        public readonly IRestaurantService _restaurantService;
        public readonly IRestaurantRepository _restaurantRepository;
        public RestaurantController(IRestaurantService restaurantService, IRestaurantRepository restaurantRepository)
        {
            _restaurantService = restaurantService;
            _restaurantRepository = restaurantRepository;
        }

        [HttpGet("getRestaurante")]
        public IActionResult GetRestaurante()
        {
            var restaurante = _restaurantRepository.GetAllRestaurante();
            return Ok(restaurante);
        }

        [HttpDelete("deleteRestaurante")]
        public IActionResult DeleteRestaurante()
        {
            _restaurantService.DeleteAll();
            return Ok();
        }
    }
}
