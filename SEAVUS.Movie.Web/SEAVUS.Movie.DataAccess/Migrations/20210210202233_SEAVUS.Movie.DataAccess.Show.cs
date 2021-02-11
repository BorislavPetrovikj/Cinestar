using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAVUS.Movie.DataAccess.Migrations
{
    public partial class SEAVUSMovieDataAccessShow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "310e5a54-d993-4d02-8a35-4d6bd5978fa4", "fdba7016-1271-4300-9452-5b3119405fdc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a88b565c-2bee-420e-ac8b-8f65a433e8f5", "05500748-f3db-4203-a006-5bb5e425164a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "05500748-f3db-4203-a006-5bb5e425164a", "9398a72f-2ed0-4b37-89bf-3696404f423e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a88b565c-2bee-420e-ac8b-8f65a433e8f5", "24b0b63a-4e55-47ce-807b-daf0e24bdf2a" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec96ece2-8b64-4c6c-b1c1-f2cb31798bf1", "53c9a3d2-fa43-4300-b3f6-ec4f7e8af3b6", "admin", "Administrator" },
                    { "8f6f49a1-6cb0-4532-bdc8-55f15181b253", "04b495af-5f70-429f-916a-da4a9b11dbd6", "user", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d5bd8313-40cf-48a8-a2c9-e2e47b78f2b1", 0, null, "103c4aeb-8d47-4037-92ae-72ff362714ed", "angelaadmin@gmail.com", true, null, false, null, "angelaadmin@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAEMWWs0+1S+0TWJoZh6HKp+LhfpGAM1ljmJJSWMwEPJ/qIY73pentyaUuCbKqJN0UvQ==", null, false, "", false, "AngelaAdmin" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowTime",
                value: new DateTime(2020, 9, 10, 1, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowTime",
                value: new DateTime(2020, 2, 10, 2, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "EndDate", "HallId", "MovieId", "ShowTime", "StartDate" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(2001, 1, 20, 4, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2019, 6, 5, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, new DateTime(2019, 10, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d5bd8313-40cf-48a8-a2c9-e2e47b78f2b1", "ec96ece2-8b64-4c6c-b1c1-f2cb31798bf1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8f6f49a1-6cb0-4532-bdc8-55f15181b253", "04b495af-5f70-429f-916a-da4a9b11dbd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d5bd8313-40cf-48a8-a2c9-e2e47b78f2b1", "ec96ece2-8b64-4c6c-b1c1-f2cb31798bf1" });

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ec96ece2-8b64-4c6c-b1c1-f2cb31798bf1", "53c9a3d2-fa43-4300-b3f6-ec4f7e8af3b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d5bd8313-40cf-48a8-a2c9-e2e47b78f2b1", "103c4aeb-8d47-4037-92ae-72ff362714ed" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05500748-f3db-4203-a006-5bb5e425164a", "9398a72f-2ed0-4b37-89bf-3696404f423e", "admin", "Administrator" },
                    { "310e5a54-d993-4d02-8a35-4d6bd5978fa4", "fdba7016-1271-4300-9452-5b3119405fdc", "user", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a88b565c-2bee-420e-ac8b-8f65a433e8f5", 0, null, "24b0b63a-4e55-47ce-807b-daf0e24bdf2a", "angelaadmin@gmail.com", true, null, false, null, "angelaadmin@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAEK9SFJCz2GJ0IDj4Dan/p8uKCzO03J9P7W7aXOU2ROTUqHfPZ+Bt6rFMXUzUoXeyCg==", null, false, "", false, "AngelaAdmin" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowTime",
                value: new DateTime(2021, 1, 27, 23, 19, 43, 380, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowTime",
                value: new DateTime(2021, 1, 29, 23, 19, 43, 382, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a88b565c-2bee-420e-ac8b-8f65a433e8f5", "05500748-f3db-4203-a006-5bb5e425164a" });
        }
    }
}
