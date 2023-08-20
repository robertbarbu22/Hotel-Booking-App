using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Attributes
{
    public class Authorization : Attribute, IAuthorizationFilter
    {
        public readonly ICollection<Role> _role;

        public Authorization(params Role[] role)
        {
            _role = role;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var unauthorized = new JsonResult(new { message = "Unauthorized" }) { StatusCode = 401 };

            if (_role == null)
            {
                context.Result = unauthorized;
            }

            var user = (User)context.HttpContext.Items["User"];
            if (user == null)
            {
                context.Result = unauthorized;
            }
        }
    }
}
