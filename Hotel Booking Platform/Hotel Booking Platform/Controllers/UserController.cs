using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Roles;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly DBContext _context;

        public UserController(IUserService userService, DBContext context)
        {
            _userService = userService;
            _context = context;
        }

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                Username = user.Username,
                Parola = BCryptNet.HashPassword(user.Parola),
                Nume = user.Nume,
                Prenume = user.Prenume,
                Email = user.Email,
                Telefon = user.Telefon,
                Role = Role.User

            };
            if (await _context.User.AnyAsync(x => x.Username == userToCreate.Username))
            {
                return BadRequest("Username already in use");
            }
          
            await _userService.CreateUser(userToCreate);
            return Ok();
        }

        [HttpPost("createAdmin")]
        public async Task<IActionResult> CreateAdmin(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                Username = user.Username,
                Parola = BCryptNet.HashPassword(user.Parola),
                Nume = user.Nume,
                Prenume = user.Prenume,
                Email = user.Email,
                Telefon = user.Telefon,
                Role = Role.Admin
            };
            if (await _context.User.AnyAsync(x => x.Username == userToCreate.Username))
            {
                return BadRequest("Username already in use");
            }
            await _userService.CreateUser(userToCreate);
            return Ok();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UserRequestDTO user)
        {
            var response = _userService.Authenticate(user);
            if (response == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return Ok(response);
        }

    }
}
