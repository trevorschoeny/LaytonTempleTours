using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTempleTours.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    AppointmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 1, null, new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 52, null, new DateTime(2022, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 51, null, new DateTime(2022, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 50, null, new DateTime(2022, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 49, null, new DateTime(2022, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 48, null, new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 47, null, new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 53, null, new DateTime(2022, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 46, null, new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 44, null, new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 43, null, new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 42, null, new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 41, null, new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 40, null, new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 39, null, new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 45, null, new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 38, null, new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 54, null, new DateTime(2022, 4, 8, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 56, null, new DateTime(2022, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 70, null, new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 69, null, new DateTime(2022, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 68, null, new DateTime(2022, 4, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 67, null, new DateTime(2022, 4, 9, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 66, null, new DateTime(2022, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 65, null, new DateTime(2022, 4, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 55, null, new DateTime(2022, 4, 8, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 64, null, new DateTime(2022, 4, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 62, null, new DateTime(2022, 4, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 61, null, new DateTime(2022, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 60, null, new DateTime(2022, 4, 8, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 59, null, new DateTime(2022, 4, 8, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 58, null, new DateTime(2022, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 57, null, new DateTime(2022, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 63, null, new DateTime(2022, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 37, null, new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 36, null, new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 35, null, new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 15, null, new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 14, null, new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 13, null, new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 12, null, new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 11, null, new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 10, null, new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 16, null, new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 9, null, new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 7, null, new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 6, null, new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 5, null, new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 4, null, new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 3, null, new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 2, null, new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 8, null, new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 17, null, new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 18, null, new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 19, null, new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 34, null, new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 33, null, new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 32, null, new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 31, null, new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 30, null, new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 29, null, new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 28, null, new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 27, null, new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 26, null, new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 25, null, new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 24, null, new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 23, null, new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 22, null, new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 21, null, new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 20, null, new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 71, null, new DateTime(2022, 4, 9, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "ID", "AppointmentID", "DateTime" },
                values: new object[] { 72, null, new DateTime(2022, 4, 9, 19, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
