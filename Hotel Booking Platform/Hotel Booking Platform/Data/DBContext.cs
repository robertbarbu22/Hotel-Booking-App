using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Models;


namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Hotel> Hoteluri { get; set; }
        public DbSet<Camera> Camere { get; set; }
        public DbSet<Rezervare> Rezervari { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Restaurant> Restaurante { get; set; }
        public DbSet<Departament> Departamente { get; set; }
        public DbSet<HotelClient> HotelClient { get; set; }
        public DbSet<User> User { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HotelClient>()
                .HasKey(hc => new { hc.HotelId, hc.ClientId });

            modelBuilder.Entity<HotelClient>()
                .HasOne<Hotel>(hc => hc.Hotel)
                .WithMany(h => h.HotelClient)
                .HasForeignKey(hc => hc.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HotelClient>()
                .HasOne<Client>(hc => hc.Client)
                .WithMany(c => c.HotelClient)
                .HasForeignKey(hc => hc.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Hotel>()
                .HasOne<Restaurant>(h => h.Restaurant)
                .WithOne(r => r.Hotel)
                .HasForeignKey<Restaurant>(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Hotel>()
                .HasMany<Camera>(h => h.Camere)
                .WithOne(c => c.Hotel)
                .HasForeignKey(c => c.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Hotel>()
                .HasMany<Angajat>(h => h.Angajati)
                .WithOne(a => a.Hotel)
                .HasForeignKey(a => a.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Client>()
                .HasMany<Rezervare>(c => c.Rezervari)
                .WithOne(r => r.Client)
                .HasForeignKey(r => r.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Departament>()
                .HasMany<Angajat>(d => d.Angajati)
                .WithOne(a => a.Departament)
                .HasForeignKey(a => a.DepartamentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

        }
    }
}
