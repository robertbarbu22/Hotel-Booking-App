using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RezervareRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RezervareService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervareController : ControllerBase
    {
        public readonly IRezervareService _rezervareService;
        public readonly IRezervareRepository _rezervareRepository;
        public RezervareController(IRezervareService rezervareService, IRezervareRepository rezervareRepository)
        {
            _rezervareService = rezervareService;
            _rezervareRepository = rezervareRepository;
        }

        [HttpGet("createRezervare")]
        public IActionResult CreateRezervare([FromBody] RezervareDTO rezervare)
        {
            var newRezervare = _rezervareService.CreateRezervare(rezervare);
            if (newRezervare == null)
            {
                return BadRequest();
            }
            return Ok(newRezervare);
        }

        [HttpPut("updateCheckin")]     
        public IActionResult UpdateCheckin([FromQuery] RezervareDTO rezervareDTO, DateTime datacheckin)
        {
            _rezervareService.UpdateCheckin( rezervareDTO, datacheckin);
            return Ok();
        }

        [HttpPut("updateCheckout")]
        public IActionResult UpdateCheckout([FromQuery] RezervareDTO rezervareDTO, DateTime datacheckout)
        {
            _rezervareService.UpdateCheckout(rezervareDTO, datacheckout);
            return Ok();
        }

        [HttpGet("getRezervareById")]
        public IActionResult GetRezervareById([FromQuery] Guid id)
        {
            var rezervare = _rezervareService.GetRezervare(id);
            if (rezervare == null)
            {
                return NotFound();
            }
            return Ok(rezervare);
        }

        [HttpGet("getRezervari")]
        public IActionResult GetRezervari()
        {
            var rezervari = _rezervareService.GetAllRezervari();
            return Ok(rezervari);
        }

        [HttpDelete("deleteRezervare")]
        public IActionResult DeleteRezervare([FromQuery] Guid id)
        {
            _rezervareService.DeleteRezervare(id);
            return Ok();
        }

        [HttpDelete("deleteRezervari")]
        public IActionResult DeleteRezervari()
        {
            _rezervareService.DeleteAll();
            return Ok();
        }
    }
}
