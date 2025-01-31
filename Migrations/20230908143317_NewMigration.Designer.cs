﻿// <auto-generated />
using EzeCarVentures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EzeCarVentures.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230908143317_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EzeCarVentures.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            CarName = "Toyota Camry 101",
                            ImageUrl = "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = "The ultimate sports car, this vehicle is designed for speed. Featuring a twin-turbocharged engine and a robust frame, it can handle sharp turns and curves with ease",
                            Price = 20.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 2,
                            BrandId = 1,
                            CarName = "Toyota Camry 102",
                            ImageUrl = "https://img.freepik.com/premium-vector/premium-car-illustration-vector-design-graphic_617770-2.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " Rear-wheel drive and four-wheel ABS. Digital keypad power door locks. Simulated wood trim on the dash and interior doors.",
                            Price = 21.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T102"
                        },
                        new
                        {
                            CarId = 3,
                            BrandId = 1,
                            CarName = "Toyota Camry 103",
                            ImageUrl = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-67402.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " Digital keypad power door locks. Simulated wood trim on the dash and interior doors.",
                            Price = 22.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 4,
                            BrandId = 2,
                            CarName = "BMW111",
                            ImageUrl = "https://img.freepik.com/premium-vector/racing-city-car-illustration_173474-59.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "BMW cars are at the forefront of automotive technology, offering a range of cutting-edge features designed to enhance the driving experience. BMW’s iDrive infotainment system provides a user-friendly interface for controlling in-car features such as audio and navigation. Additionally, BMW’s ConnectedDrive technology offers a suite of connectivity services, such as real-time traffic information, remote control of the car from a smartphone, and the ability to stream music and podcasts on the go.",
                            Price = 300.4m,
                            ShortDescription = "Beautiful car with Good Engines",
                            ShortName = "B1"
                        },
                        new
                        {
                            CarId = 5,
                            BrandId = 2,
                            CarName = "BMW112",
                            ImageUrl = "https://img.freepik.com/free-vector/red-sports-car-black-background-vector_53876-67367.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "With its EfficientDynamics design system, purchasing a BMW is not only a luxury purchase but an environmentally conscious one.",
                            Price = 200.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "B2"
                        },
                        new
                        {
                            CarId = 6,
                            BrandId = 2,
                            CarName = "BMW113",
                            ImageUrl = "https://img.freepik.com/premium-vector/blue-racing-sport-car_692865-16.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "With its EfficientDynamics design system, purchasing this BMW is not only a luxury purchase but an environmentally conscious one.",
                            Price = 200.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "B3"
                        },
                        new
                        {
                            CarId = 7,
                            BrandId = 3,
                            CarName = "GLK 405",
                            ImageUrl = "https://img.freepik.com/premium-photo/generic-black-suv_2227-847.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = "Your satisfaction is our primary concern in both sales and service. Mercedes-Benz of Westminster is held to the highest standards in the industry by Mercedes-Benz. We appreciatively provide thoughtful amenities fostered around convenience for our customers. Low prices, great customer attention and the highest quality service support for your vehicle. Mercedes-Benz slogan says it all – Das beste oder nichts! (The best or nothing)",
                            Price = 400.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 8,
                            BrandId = 3,
                            CarName = "4Matic",
                            ImageUrl = "https://image.shutterstock.com/image-vector/luxury-premium-realistic-sedan-coupe-260nw-2265160149.jpg",
                            LongDescription = "Mercedes-Benz knows fulfilling that destiny will take more than just plug-in hybrids and battery electric vehicles. That’s why they’ve driven innovation of renewable, zero-emission hydrogen fuel cell power. You can own the future, today with the B-Class F-CELL.",
                            Price = 300.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 9,
                            BrandId = 3,
                            CarName = "Mercedes 202",
                            ImageUrl = "https://img.freepik.com/free-photo/vintage-car-with-license-plate-that-says-license-plate-it_1340-28354.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph",
                            LongDescription = "The Mercedes-Benz family is devoted to the craft of automobile making. A Mercedes-Benz should always look like a Mercedes-Benz, and what we produce are vehicles that not only look, but feel and sound like nothing else on the road.",
                            Price = 250.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 10,
                            BrandId = 1,
                            CarName = "Toyota Camry 104",
                            ImageUrl = "https://img.freepik.com/free-vector/white-suv-car-black-background-vector_53876-64378.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " Leather steering wheel and seats. Height-adjustable and eight-way power driver and passenger seats. Simulated wood trim on the dash and interior doors.",
                            Price = 150.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T104"
                        },
                        new
                        {
                            CarId = 11,
                            BrandId = 2,
                            CarName = "BMW114",
                            ImageUrl = "https://img.freepik.com/premium-vector/car-illustration_74218-147.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = " advanced technology makes its cars more convenient, comfortable, and safe to drive, while also improving the driving experience and providing drivers with the latest in automotive innovation. BMW drivers can feel confident that they are behind the wheel of a vehicle that is equipped with the most cutting-edge technology available.",
                            Price = 370.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        },
                        new
                        {
                            CarId = 12,
                            BrandId = 3,
                            CarName = "Benz1",
                            ImageUrl = "https://img.freepik.com/free-photo/white-offroader-jeep-parking_114579-4007.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais",
                            LongDescription = "Since inventing the first car, Mercedes-Benz has set the pace for what all cars might someday become. With an ongoing stream of firsts in safety, performance and driving there’s only one reason the world’s first automaker remains first in innovation. Carl Benz said it best: The love of inventing never dies.",
                            Price = 400.4m,
                            ShortDescription = "Beautiful car with Good Tires",
                            ShortName = "T101"
                        });
                });

            modelBuilder.Entity("EzeCarVentures.Models.Car", b =>
                {
                    b.HasOne("EzeCarVentures.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
