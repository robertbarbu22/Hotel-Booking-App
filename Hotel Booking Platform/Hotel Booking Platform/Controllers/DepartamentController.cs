using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.DepartamentRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.DepartamentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : ControllerBase
    {
        public readonly IDepartamentService _departamentService;
        public readonly IDepartamentRepository _departamentRepository;

        public DepartamentController(IDepartamentService departamentService, IDepartamentRepository departamentRepository)
        {
            _departamentService = departamentService;
            _departamentRepository = departamentRepository;
        }

        [HttpGet("getDepartamente")]
        public IActionResult GetDepartamente()
        {
            var departamente = _departamentService.GetAllDept();
            return Ok(departamente);
        }

        [HttpDelete("deleteDepartamente")]
        public IActionResult DeleteDepartamente()
        {
            _departamentService.DeleteAll();
            return Ok();
        }



    }
}
