﻿// <auto-generated />
using System;
using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Booking_Platform.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230822234755_Angajati")]
    partial class Angajati
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Angajat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Functie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salariu")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.HasIndex("HotelId");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Camera", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NrCamera")
                        .HasColumnType("int");

                    b.Property<int>("NrPersoane")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Camere");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Departament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NrAngajati")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamente");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hoteluri");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.HotelClient", b =>
                {
                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HotelId", "ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("HotelClient");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NrLocuri")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId")
                        .IsUnique()
                        .HasFilter("[HotelId] IS NOT NULL");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Rezervare", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CameraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Pret")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CameraId");

                    b.HasIndex("ClientId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rezervari");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Angajat", b =>
                {
                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Departament", "Departament")
                        .WithMany("Angajati")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", "Hotel")
                        .WithMany("Angajati")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Departament");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Camera", b =>
                {
                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", "Hotel")
                        .WithMany("Camere")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.HotelClient", b =>
                {
                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Client", "Client")
                        .WithMany("HotelClient")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", "Hotel")
                        .WithMany("HotelClient")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Restaurant", b =>
                {
                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", "Hotel")
                        .WithOne("Restaurant")
                        .HasForeignKey("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Restaurant", "HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Rezervare", b =>
                {
                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraId");

                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Client", "Client")
                        .WithMany("Rezervari")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", "Hotel")
                        .WithMany("Rezervari")
                        .HasForeignKey("HotelId");

                    b.Navigation("Camera");

                    b.Navigation("Client");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Client", b =>
                {
                    b.Navigation("HotelClient");

                    b.Navigation("Rezervari");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Departament", b =>
                {
                    b.Navigation("Angajati");
                });

            modelBuilder.Entity("Hotel_Booking_Platform.Hotel_Booking_Platform.Models.Hotel", b =>
                {
                    b.Navigation("Angajati");

                    b.Navigation("Camere");

                    b.Navigation("HotelClient");

                    b.Navigation("Restaurant");

                    b.Navigation("Rezervari");
                });
#pragma warning restore 612, 618
        }
    }
}
