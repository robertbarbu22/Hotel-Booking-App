
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.AngajatRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.CameraRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.ClientRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.DepartamentRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.HotelRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RezervareRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.RestaurantRepo;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.UserRepo;
using Microsoft.Extensions.DependencyInjection;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.AngajatService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.CameraService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.ClientService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.DepartamentService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.HotelService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RestaurantService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.RezervareService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Services.UserService;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.JwtUtilsHelp;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Extension
{
    public static class Extension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IAngajatRepository, AngajatRepository>();
            services.AddTransient<ICameraRepository, CameraRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IDepartamentRepository, DepartamentRepository>();
            services.AddTransient<IHotelRepository, HotelRepository>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<IRezervareRepository, RezervareRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAngajatService, AngajatService>();
            services.AddTransient<ICameraService, CameraService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IDepartamentService, DepartamentService>();
            services.AddTransient<IHotelService, HotelService>();
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IRezervareService, RezervareService>();
            services.AddTransient<IUserService, UserService>();
            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<AngajatSeeder>();
            services.AddTransient<CameraSeeder>();
            services.AddTransient<ClientSeeder>();
            services.AddTransient<DepartamentSeeder>();
            services.AddTransient<HotelSeeder>();
            services.AddTransient<Restaurantseeder>();
            services.AddTransient<RezervareSeeder>();
            services.AddTransient<HotelClientSeeder>();
            return services;
        }

        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            services.AddScoped<IJwtUtils, JwtUtil>();
            return services;
        }
    }
}
