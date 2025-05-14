using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace application2.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdataforwalk2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("09b1f232-6491-43cf-82af-7461a9b8c146"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("6c4bec8a-2f02-4e33-8e55-4ddf308b731e"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("c56cad60-8e0d-42c9-871c-c0ac677b333b"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Area", "Code", "Lat", "Long", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), 3287263.0, "IN", 20.593699999999998, 78.962900000000005, "India", 1393409038L },
                    { new Guid("55555555-5555-5555-5555-555555555555"), 9833517.0, "US", 37.090200000000003, -95.712900000000005, "United States", 331893745L }
                });

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Easy" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Medium" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Hard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("09b1f232-6491-43cf-82af-7461a9b8c146"), "Medium" },
                    { new Guid("6c4bec8a-2f02-4e33-8e55-4ddf308b731e"), "Easy" },
                    { new Guid("c56cad60-8e0d-42c9-871c-c0ac677b333b"), "Hard" }
                });
        }
    }
}
