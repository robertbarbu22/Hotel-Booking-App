using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.HotelRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.HotelService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        public readonly IHotelService _hotelService;
        public readonly IHotelRepository _hotelRepository;
        public HotelController(IHotelService hotelService, IHotelRepository hotelRepository)
        {
            _hotelService = hotelService;
            _hotelRepository = hotelRepository;
        }

        [HttpGet("getById")]
        public IActionResult GetById(Guid id)
        {
            var hotel = _hotelService.GetHotelById(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        [HttpGet("getByNume")]
        public IActionResult GetByNume(string nume)
        {
            var hotel = _hotelService.GetHotelByNume(nume);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        [HttpGet("getHotels")]
        public IActionResult GetHotels()
        {
            var hotels = _hotelService.GetAllHotels();
            return Ok(hotels);
        }

        [HttpDelete("deleteHotel")]
        public IActionResult DeleteHotel(Guid id)
        {
            _hotelService.DeleteHotel(id);
            return Ok();
        }

        [HttpDelete("deleteHotels")]
        public IActionResult DeleteHotels()
        {
            _hotelService.DeleteAll();
            return Ok();
        }
    }
}
