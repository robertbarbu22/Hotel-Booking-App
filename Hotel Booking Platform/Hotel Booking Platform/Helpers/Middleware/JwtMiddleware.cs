using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.JwtUtilsHelp;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.UserService;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var user = jwtUtils.ValidateJwtToken(token);

            if (user != Guid.Empty)
            {
                context.Items["User"] = userService.GetById(user);
            }

            await _next(context);

        }
    }
}
