using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEAVUS.Movie.DataAccess.Migrations
{
    public partial class SEAVUSMovieDomainModelsFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "56bf0afd-fc6d-4f7c-a3f5-038b2ee2214a", "52df6d35-22a3-4ddb-a090-e5bba4cd92e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a1a1cd9f-c076-43d3-91ee-8b1f01c21b0f", "c050a91a-d6f3-4b27-9812-d8c24d5a388e" });

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowTime",
                value: new DateTime(2021, 1, 27, 17, 1, 41, 675, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowTime",
                value: new DateTime(2021, 1, 29, 17, 1, 41, 676, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a1a1cd9f-c076-43d3-91ee-8b1f01c21b0f", "56bf0afd-fc6d-4f7c-a3f5-038b2ee2214a" });
        }
    }
}
