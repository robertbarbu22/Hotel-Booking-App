using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RezervareService
{
    public interface IRezervareService
    {
        Task<RezervareDTO> CreateRezervare(RezervareDTO rezervareDTO);
        void UpdateCheckin(RezervareDTO rezervareDTO, DateTime datacheckin);
        void UpdateCheckout(RezervareDTO rezervareDTO, DateTime datacheckout);
        Task<RezervareDTO> GetRezervare(Guid id);
        Task<List<RezervareDTO>> GetAllRezervari();
        void DeleteRezervare(Guid id);
        void DeleteAll();
    }
}
