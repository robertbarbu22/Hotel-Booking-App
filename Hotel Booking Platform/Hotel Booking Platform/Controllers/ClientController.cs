using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.ClientRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.ClientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public readonly IClientService _clientService;
        public readonly IClientRepository _clientRepository;

        public ClientController(IClientService clientService, IClientRepository clientRepository)
        {
            _clientService = clientService;
            _clientRepository = clientRepository;
        }

        [HttpGet("GetClientById")]
        public IActionResult GetClientById([FromQuery] Guid id)
        {

            var client = _clientService.GetClientById(id);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet("GetClientByNume")]

        public IActionResult GetClientByNume([FromQuery] string nume)
        {
            var client = _clientService.GetClientByNume(nume);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet("GetAllClients")]
        public IActionResult GetAllClients()
        {
            var clients = _clientService.GetAllClients();
            if (clients == null)
            {
                return NotFound();
            }
            return Ok(clients);
        }

        [HttpPost("CreateClient")]
        public IActionResult CreateClient([FromBody] ClientDTO client)
        {
            var newClient = _clientService.CreateClient(client);
            if (newClient == null)
            {
                return BadRequest();
            }
            return Ok(newClient);
        }

        [HttpDelete("DeleteClient")]
        public IActionResult DeleteClient([FromQuery] Guid id)
        {
            _clientService.DeleteClient(id);
            return NoContent();
        }

        [HttpDelete("DeleteAll")]

        public IActionResult DeleteAll()
        {
            _clientService.DeleteAll();
            return NoContent();
        }



    }
}
