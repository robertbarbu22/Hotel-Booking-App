using AutoMapper;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models.DTOs;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Angajat, AngajatDTO>();
            CreateMap<AngajatDTO, Angajat>();
            CreateMap<Camera, CameraDTO>();
            CreateMap<CameraDTO, Camera>();
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
            CreateMap<Departament, DepartamentDTO>();
            CreateMap<DepartamentDTO, Departament>();
            CreateMap<Hotel, HotelDTO>();
            CreateMap<HotelDTO, Hotel>();
            CreateMap<Restaurant, RestaurantDTO>();
            CreateMap<RestaurantDTO, Restaurant>();
            CreateMap<Rezervare, RezervareDTO>();
            CreateMap<RezervareDTO, Rezervare>();
        }
    }
}
