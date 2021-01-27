using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAVUS.Movie.DataAccess.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "18892196-fd1d-4d06-9437-9cb4da749db6", "a8f1de57-354c-4d5f-9e08-180e7151cf64" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "860f164f-6fd8-460f-9c17-396b1f4caee5", "e1765d7d-b58b-43db-a6f3-ed389a68e7c8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e1765d7d-b58b-43db-a6f3-ed389a68e7c8", "1f44ab23-55f2-4e23-bdd6-fbe252bcc556" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "860f164f-6fd8-460f-9c17-396b1f4caee5", "4ef8f97f-fa56-4dbc-b56e-51c210cc6f46" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 7, 53, "Song", "Kang-ho" },
                    { 8, 59, "George", "Clooney" },
                    { 9, 40, "Chris", "Pine" },
                    { 10, 40, "Margot", "Robbie" },
                    { 11, 34, "Christopher", "Abbott" },
                    { 12, 33, "Liu", "Yifei" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56bf0afd-fc6d-4f7c-a3f5-038b2ee2214a", "52df6d35-22a3-4ddb-a090-e5bba4cd92e4", "admin", "Administrator" },
                    { "91bf999f-d2f6-4424-a208-44f4ad9e8893", "63fd7e8b-4dcc-40d0-8df9-a28cd88e9cf4", "user", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1a1cd9f-c076-43d3-91ee-8b1f01c21b0f", 0, null, "c050a91a-d6f3-4b27-9812-d8c24d5a388e", "angelaadmin@gmail.com", true, false, null, "angelaadmin@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAEIEl71KMCh9nIy8G9OIXf6HgnPX0Q24l7WUVgWvFnAgxJZ2ZWdt2bdw05S35LhT54A==", null, false, "", false, "AngelaAdmin" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 2, 4, 2 },
                    { 1, 2, 1 },
                    { 12, 5, 2 },
                    { 11, 3, 3 },
                    { 4, 6, 4 },
                    { 3, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[] { 1, "Hall 01", "Standard" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "She is a angel princess from the angel world. She grew up loved by her parents and doesn't really know how to be evil or any of the common actions,   She is unable to cry due to Keita's accidental first wish, despite needed for him to wish.", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2020, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a1a1cd9f-c076-43d3-91ee-8b1f01c21b0f", "56bf0afd-fc6d-4f7c-a3f5-038b2ee2214a" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 10, 12, 10 },
                    { 9, 11, 9 },
                    { 5, 7, 5 },
                    { 7, 9, 7 },
                    { 6, 8, 6 },
                    { 8, 10, 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Available", "HallId", "Price", "RowNumber", "SeatNumber", "Type" },
                values: new object[,]
                {
                    { 1, (sbyte)1, 1, 9.00m, 1, 1, "Standard" },
                    { 2, (sbyte)1, 1, 9.00m, 1, 2, "Standard" },
                    { 3, (sbyte)1, 1, 9.00m, 1, 3, "Standard" },
                    { 5, (sbyte)1, 1, 9.00m, 1, 5, "Standard" },
                    { 6, (sbyte)1, 1, 9.00m, 1, 6, "Standard" },
                    { 7, (sbyte)1, 1, 9.00m, 1, 7, "Standard" },
                    { 8, (sbyte)1, 1, 9.00m, 1, 8, "Standard" },
                    { 9, (sbyte)1, 1, 9.00m, 1, 9, "Standard" },
                    { 10, (sbyte)1, 1, 9.00m, 1, 10, "Standard" },
                    { 4, (sbyte)1, 1, 9.00m, 1, 4, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "EndDate", "HallId", "MovieId", "ShowTime", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2021, 1, 29, 17, 1, 41, 676, DateTimeKind.Local), new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 1, 27, 17, 1, 41, 675, DateTimeKind.Local), new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "91bf999f-d2f6-4424-a208-44f4ad9e8893", "63fd7e8b-4dcc-40d0-8df9-a28cd88e9cf4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a1a1cd9f-c076-43d3-91ee-8b1f01c21b0f", "56bf0afd-fc6d-4f7c-a3f5-038b2ee2214a" });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "56bf0afd-fc6d-4f7c-a3f5-038b2ee2214a", "52df6d35-22a3-4ddb-a090-e5bba4cd92e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a1a1cd9f-c076-43d3-91ee-8b1f01c21b0f", "c050a91a-d6f3-4b27-9812-d8c24d5a388e" });

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e1765d7d-b58b-43db-a6f3-ed389a68e7c8", "1f44ab23-55f2-4e23-bdd6-fbe252bcc556", "admin", "Administrator" },
                    { "18892196-fd1d-4d06-9437-9cb4da749db6", "a8f1de57-354c-4d5f-9e08-180e7151cf64", "user", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "860f164f-6fd8-460f-9c17-396b1f4caee5", 0, null, "4ef8f97f-fa56-4dbc-b56e-51c210cc6f46", "angelaadmin@gmail.com", true, false, null, "angelaadmin@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAEFHoepSD0RvfpS6PAnQde5jI/qS/ZubwaKF04txPneIAjNoBx0SWcIyAlcdRXnYzXg==", null, false, "", false, "AngelaAdmin" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ReleaseDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "860f164f-6fd8-460f-9c17-396b1f4caee5", "e1765d7d-b58b-43db-a6f3-ed389a68e7c8" });
        }
    }
}
