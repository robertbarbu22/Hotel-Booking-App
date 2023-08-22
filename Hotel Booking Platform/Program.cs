using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Linq;
using System.Net;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Middleware;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Seeders;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Helpers.Extension;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<DBContext>(opts => { opts.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")); });
builder.Services.AddControllersWithViews();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddSeeders();
builder.Services.AddUtils();
builder.Services.AddEndpointsApiExplorer();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

SeedDataAsync(app);

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseMiddleware<JwtMiddleware>();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;
app.UseCors("corsapp");
app.Run();


async Task SeedDataAsync(IHost app)
{
    var scope = app.Services.GetService<IServiceScopeFactory>().CreateScope();

    using var context = new DBContext(scope.ServiceProvider.GetRequiredService<DbContextOptions<DBContext>>());

    var serviceAngajat = new AngajatSeeder(context);
    serviceAngajat.SeedAngajat();

    var serviceCamera = new CameraSeeder(context);
    serviceCamera.SeedCamera();

    var serviceClient = new ClientSeeder(context);
    serviceClient.SeedClient();

    var serviceDepartament = new DepartamentSeeder(context);
    serviceDepartament.SeedDepartament();

    var serviceHotel = new HotelSeeder(context);
    serviceHotel.SeedHotel();

    var serviceHotelClient = new HotelClientSeeder(context);
    serviceHotelClient.SeedHotelClient();

    var serviceRestaurant = new Restaurantseeder(context);
    serviceRestaurant.SeedRestaurant();

    var serviceRezervare = new RezervareSeeder(context);
    serviceRezervare.SeedRezervare();

}