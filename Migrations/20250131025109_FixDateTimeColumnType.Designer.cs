﻿// <auto-generated />
using System;
using EzeCarVentures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EzeCarVentures.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250131025109_FixDateTimeColumnType")]
    partial class FixDateTimeColumnType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EzeCarVentures.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "Toyota Camry",
                            Description = "Beauty"
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "BMW",
                            Description = "Class"
                        },
                        new
                        {
                            BrandId = 3,
                            BrandName = "Mercedes",
                            Description = "Exotic"
                        });
                });

            modelBuilder.Entity("EzeCarVentures.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            BrandId = 1,
                            BrandName = "Toyota Camry",
                            CarName = "Toyota Camry 101",
                            ImageUrl = "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = "The ultimate sports car, this vehicle is designed for speed. Featuring a twin-turbocharged engine and a robust frame, it can handle sharp turns and curves with ease",
                            Price = 200000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 2,
                            BrandId = 1,
                            BrandName = "Toyota Camry",
                            CarName = "Toyota Camry 102",
                            ImageUrl = "https://img.freepik.com/premium-vector/premium-car-illustration-vector-design-graphic_617770-2.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " Rear-wheel drive and four-wheel ABS. Digital keypad power door locks. Simulated wood trim on the dash and interior doors.",
                            Price = 210000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T102"
                        },
                        new
                        {
                            CarId = 3,
                            BrandId = 1,
                            BrandName = "Toyota Camry",
                            CarName = "Toyota Camry 103",
                            ImageUrl = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-67402.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " Digital keypad power door locks. Simulated wood trim on the dash and interior doors.",
                            Price = 2241000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T103"
                        },
                        new
                        {
                            CarId = 4,
                            BrandId = 2,
                            BrandName = "BMW",
                            CarName = "BMW111",
                            ImageUrl = "https://img.freepik.com/premium-vector/racing-city-car-illustration_173474-59.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "BMW cars are at the forefront of automotive technology, offering a range of cutting-edge features designed to enhance the driving experience. BMW’s iDrive infotainment system provides a user-friendly interface for controlling in-car features such as audio and navigation. Additionally, BMW’s ConnectedDrive technology offers a suite of connectivity services, such as real-time traffic information, remote control of the car from a smartphone, and the ability to stream music and podcasts on the go.",
                            Price = 30040000m,
                            ShortDescription = "Beautiful car with Good Engines",
                            ShortName = "B1"
                        },
                        new
                        {
                            CarId = 5,
                            BrandId = 2,
                            BrandName = "BMW",
                            CarName = "BMW112",
                            ImageUrl = "https://img.freepik.com/free-vector/red-sports-car-black-background-vector_53876-67367.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "With its EfficientDynamics design system, purchasing a BMW is not only a luxury purchase but an environmentally conscious one.",
                            Price = 200000000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "B2"
                        },
                        new
                        {
                            CarId = 6,
                            BrandId = 2,
                            BrandName = "BMW",
                            CarName = "BMW113",
                            ImageUrl = "https://img.freepik.com/premium-vector/blue-racing-sport-car_692865-16.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "With its EfficientDynamics design system, purchasing this BMW is not only a luxury purchase but an environmentally conscious one.",
                            Price = 290000000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "B3"
                        },
                        new
                        {
                            CarId = 7,
                            BrandId = 3,
                            BrandName = "Mercedes",
                            CarName = "GLK 405",
                            ImageUrl = "https://img.freepik.com/premium-photo/generic-black-suv_2227-847.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = "Your satisfaction is our primary concern in both sales and service. Mercedes-Benz of Westminster is held to the highest standards in the industry by Mercedes-Benz. We appreciatively provide thoughtful amenities fostered around convenience for our customers. Low prices, great customer attention and the highest quality service support for your vehicle. Mercedes-Benz slogan says it all – Das beste oder nichts! (The best or nothing)",
                            Price = 404000000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "G101"
                        },
                        new
                        {
                            CarId = 8,
                            BrandId = 3,
                            BrandName = "Mercedes",
                            CarName = "4Matic",
                            ImageUrl = "https://image.shutterstock.com/image-vector/luxury-premium-realistic-sedan-coupe-260nw-2265160149.jpg",
                            LongDescription = "Mercedes-Benz knows fulfilling that destiny will take more than just plug-in hybrids and battery electric vehicles. That’s why they’ve driven innovation of renewable, zero-emission hydrogen fuel cell power. You can own the future, today with the B-Class F-CELL.",
                            Price = 30000000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "M101"
                        },
                        new
                        {
                            CarId = 9,
                            BrandId = 3,
                            BrandName = "Mercedes",
                            CarName = "Mercedes 202",
                            ImageUrl = "https://img.freepik.com/free-photo/vintage-car-with-license-plate-that-says-license-plate-it_1340-28354.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "The Mercedes-Benz family is devoted to the craft of automobile making. A Mercedes-Benz should always look like a Mercedes-Benz, and what we produce are vehicles that not only look, but feel and sound like nothing else on the road.",
                            Price = 25000000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "M101"
                        },
                        new
                        {
                            CarId = 10,
                            BrandId = 1,
                            BrandName = "Toyota Camry",
                            CarName = "Toyota Camry 104",
                            ImageUrl = "https://img.freepik.com/free-vector/white-suv-car-black-background-vector_53876-64378.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " Leather steering wheel and seats. Height-adjustable and eight-way power driver and passenger seats. Simulated wood trim on the dash and interior doors.",
                            Price = 1504000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T104"
                        },
                        new
                        {
                            CarId = 11,
                            BrandId = 2,
                            BrandName = "BMW",
                            CarName = "BMW114",
                            ImageUrl = "https://img.freepik.com/premium-vector/car-illustration_74218-147.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " advanced technology makes its cars more convenient, comfortable, and safe to drive, while also improving the driving experience and providing drivers with the latest in automotive innovation. BMW drivers can feel confident that they are behind the wheel of a vehicle that is equipped with the most cutting-edge technology available.",
                            Price = 37400000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "B14"
                        },
                        new
                        {
                            CarId = 12,
                            BrandId = 3,
                            BrandName = "Mercedes",
                            CarName = "Benz1",
                            ImageUrl = "https://img.freepik.com/free-photo/white-offroader-jeep-parking_114579-4007.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = "Since inventing the first car, Mercedes-Benz has set the pace for what all cars might someday become. With an ongoing stream of firsts in safety, performance and driving there’s only one reason the world’s first automaker remains first in innovation. Carl Benz said it best: The love of inventing never dies.",
                            Price = 404000000m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "B101"
                        });
                });

            modelBuilder.Entity("EzeCarVentures.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CarId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EzeCarVentures.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartItemId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CarId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("OrderTotal")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EzeCarVentures.Models.Car", b =>
                {
                    b.HasOne("EzeCarVentures.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("EzeCarVentures.Models.OrderDetail", b =>
                {
                    b.HasOne("EzeCarVentures.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EzeCarVentures.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("EzeCarVentures.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
