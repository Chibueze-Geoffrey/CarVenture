using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EzeCarVentures.Migrations
{
    public partial class FixDateTimeColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[] { 1, "Toyota Camry", "Beauty" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[] { 2, "BMW", "Class" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[] { 3, "Mercedes", "Exotic" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "BrandId", "BrandName", "CarName", "ImageUrl", "LongDescription", "Price", "ShortDescription", "ShortName" },
                values: new object[,]
                {
                    { 1, 1, "Toyota Camry", "Toyota Camry 101", "https://img.freepik.com/free-vector/white-hatchback-car-isolated-white-vector_53876-67619.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", "The ultimate sports car, this vehicle is designed for speed. Featuring a twin-turbocharged engine and a robust frame, it can handle sharp turns and curves with ease", 200000m, "Beautiful car with Good Tires", "T101" },
                    { 2, 1, "Toyota Camry", "Toyota Camry 102", "https://img.freepik.com/premium-vector/premium-car-illustration-vector-design-graphic_617770-2.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " Rear-wheel drive and four-wheel ABS. Digital keypad power door locks. Simulated wood trim on the dash and interior doors.", 210000m, "Beautiful car with Good Tires", "T102" },
                    { 3, 1, "Toyota Camry", "Toyota Camry 103", "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-vector_53876-67402.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " Digital keypad power door locks. Simulated wood trim on the dash and interior doors.", 2241000m, "Beautiful car with Good Tires", "T103" },
                    { 4, 2, "BMW", "BMW111", "https://img.freepik.com/premium-vector/racing-city-car-illustration_173474-59.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "BMW cars are at the forefront of automotive technology, offering a range of cutting-edge features designed to enhance the driving experience. BMW’s iDrive infotainment system provides a user-friendly interface for controlling in-car features such as audio and navigation. Additionally, BMW’s ConnectedDrive technology offers a suite of connectivity services, such as real-time traffic information, remote control of the car from a smartphone, and the ability to stream music and podcasts on the go.", 30040000m, "Beautiful car with Good Engines", "B1" },
                    { 5, 2, "BMW", "BMW112", "https://img.freepik.com/free-vector/red-sports-car-black-background-vector_53876-67367.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "With its EfficientDynamics design system, purchasing a BMW is not only a luxury purchase but an environmentally conscious one.", 200000000m, "Beautiful car with Good Tires", "B2" },
                    { 6, 2, "BMW", "BMW113", "https://img.freepik.com/premium-vector/blue-racing-sport-car_692865-16.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "With its EfficientDynamics design system, purchasing this BMW is not only a luxury purchase but an environmentally conscious one.", 290000000m, "Beautiful car with Good Tires", "B3" },
                    { 7, 3, "Mercedes", "GLK 405", "https://img.freepik.com/premium-photo/generic-black-suv_2227-847.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", "Your satisfaction is our primary concern in both sales and service. Mercedes-Benz of Westminster is held to the highest standards in the industry by Mercedes-Benz. We appreciatively provide thoughtful amenities fostered around convenience for our customers. Low prices, great customer attention and the highest quality service support for your vehicle. Mercedes-Benz slogan says it all – Das beste oder nichts! (The best or nothing)", 404000000m, "Beautiful car with Good Tires", "G101" },
                    { 8, 3, "Mercedes", "4Matic", "https://image.shutterstock.com/image-vector/luxury-premium-realistic-sedan-coupe-260nw-2265160149.jpg", "Mercedes-Benz knows fulfilling that destiny will take more than just plug-in hybrids and battery electric vehicles. That’s why they’ve driven innovation of renewable, zero-emission hydrogen fuel cell power. You can own the future, today with the B-Class F-CELL.", 30000000m, "Beautiful car with Good Tires", "M101" },
                    { 9, 3, "Mercedes", "Mercedes 202", "https://img.freepik.com/free-photo/vintage-car-with-license-plate-that-says-license-plate-it_1340-28354.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=sph", "The Mercedes-Benz family is devoted to the craft of automobile making. A Mercedes-Benz should always look like a Mercedes-Benz, and what we produce are vehicles that not only look, but feel and sound like nothing else on the road.", 25000000m, "Beautiful car with Good Tires", "M101" },
                    { 10, 1, "Toyota Camry", "Toyota Camry 104", "https://img.freepik.com/free-vector/white-suv-car-black-background-vector_53876-64378.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " Leather steering wheel and seats. Height-adjustable and eight-way power driver and passenger seats. Simulated wood trim on the dash and interior doors.", 1504000m, "Beautiful car with Good Tires", "T104" },
                    { 11, 2, "BMW", "BMW114", "https://img.freepik.com/premium-vector/car-illustration_74218-147.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", " advanced technology makes its cars more convenient, comfortable, and safe to drive, while also improving the driving experience and providing drivers with the latest in automotive innovation. BMW drivers can feel confident that they are behind the wheel of a vehicle that is equipped with the most cutting-edge technology available.", 37400000m, "Beautiful car with Good Tires", "B14" },
                    { 12, 3, "Mercedes", "Benz1", "https://img.freepik.com/free-photo/white-offroader-jeep-parking_114579-4007.jpg?size=626&ext=jpg&uid=R115479512&ga=GA1.2.1782245604.1694014074&semt=ais", "Since inventing the first car, Mercedes-Benz has set the pace for what all cars might someday become. With an ongoing stream of firsts in safety, performance and driving there’s only one reason the world’s first automaker remains first in innovation. Carl Benz said it best: The love of inventing never dies.", 404000000m, "Beautiful car with Good Tires", "B101" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CarId",
                table: "OrderDetails",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CarId",
                table: "ShoppingCartItems",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
