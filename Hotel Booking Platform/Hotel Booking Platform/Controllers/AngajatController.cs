using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.AngajatRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.AngajatService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngajatController : ControllerBase
    {
        public readonly IAngajatService _angajatService;
        public readonly IAngajatRepository _angajatRepository;

        public AngajatController(IAngajatService angajatService, IAngajatRepository angajatRepository)
        {
            _angajatService = angajatService;
            _angajatRepository = angajatRepository;
        }

        [HttpGet("getAngajati")]
        public IActionResult GetAngajati()
        {
            var angajati = _angajatService.GetAllAngajati();
            return Ok(angajati);
        }

        [HttpDelete("deleteAngajati")]
        public IActionResult DeleteAngajati()
        {
            _angajatService.DeleteAll();
            return Ok();
        }

    }
}
