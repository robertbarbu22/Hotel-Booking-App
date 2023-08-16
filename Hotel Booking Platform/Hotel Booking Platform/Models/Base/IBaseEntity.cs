using System;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? DateCreated { get; set; }
        DateTime? DateModified { get; set; }
    }
}
