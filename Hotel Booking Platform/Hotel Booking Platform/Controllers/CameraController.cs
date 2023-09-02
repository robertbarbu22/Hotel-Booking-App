using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.CameraRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.CameraService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : ControllerBase
    {
        public readonly ICameraService _cameraService;
        public readonly ICameraRepository _cameraRepository;

        public CameraController(ICameraService cameraService, ICameraRepository cameraRepository)
        {
            _cameraService = cameraService;
            _cameraRepository = cameraRepository;
        }

        [HttpGet("GetAllCamere")]
        public IActionResult Get()
        {
            var cameras = _cameraRepository.GetAllCamere();
            return Ok(cameras);
        }

        [HttpGet("GetCameraById/{id}")]
        public IActionResult Get(Guid id)
        {
            var camera = _cameraRepository.GetCameraById(id);
            return Ok(camera);
        }

        [HttpDelete("DeleteCamere")]
        public IActionResult Delete()
        {
            _cameraService.DeleteAll();
            return Ok();
        }
    }
}
