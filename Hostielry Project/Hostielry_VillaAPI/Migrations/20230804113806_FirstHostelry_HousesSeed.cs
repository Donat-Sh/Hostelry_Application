using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstHostelry_HousesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 38, 6, 884, DateTimeKind.Local).AddTicks(6922), "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.", "Royal Hostelry" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 38, 6, 884, DateTimeKind.Local).AddTicks(6969), "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.", "Premium Pool Hostelry" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 38, 6, 884, DateTimeKind.Local).AddTicks(6972), "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.", "Luxury Pool Hostelry" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 38, 6, 884, DateTimeKind.Local).AddTicks(6975), "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.", "Diamond Hostelry" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 38, 6, 884, DateTimeKind.Local).AddTicks(6977), "From the outside this house looks cozy. It has been built with tan bricks and has sandstone decorations. Tall, rounded windows allow enough light to enter the home and have been added to the house in a mostly symmetric way. The house is equipped with a huge kitchen and two bathrooms, it also has a comfortable living room, three bedrooms, a roomy dining room, an office and a spacious garage. The building is shaped like a circle. The house is partially surrounded by wooden overhanging panels on two sides. The second floor is the same size as the first, which has been built exactly on top of the floor below it. This floor has roughly the same style as the floor below.", "Diamond Pool Hostelry" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 35, 15, 463, DateTimeKind.Local).AddTicks(4408), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 35, 15, 463, DateTimeKind.Local).AddTicks(4473), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 35, 15, 463, DateTimeKind.Local).AddTicks(4476), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 35, 15, 463, DateTimeKind.Local).AddTicks(4479), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "Name" },
                values: new object[] { new DateTime(2023, 8, 4, 13, 35, 15, 463, DateTimeKind.Local).AddTicks(4482), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Pool Villa" });
        }
    }
}
