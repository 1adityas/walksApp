using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace application2.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdataforwalkdifficultymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("675b1099-e02e-4b4e-b2ea-9ccd95aef145"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("896e721d-e8fc-454f-bfd6-9d11f43f5ffe"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("2be547f5-a3f7-4a98-9fe1-7e6a53fc939d"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("2e9761ff-290c-4284-80fc-355f07c4b18c"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("e94f43fb-f617-494b-80f7-ab04a9d8a866"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("675b1099-e02e-4b4e-b2ea-9ccd95aef145"), 3287263.0, "IN", 20.593699999999998, 78.962900000000005, "India", 1393409038L },
                    { new Guid("896e721d-e8fc-454f-bfd6-9d11f43f5ffe"), 9833517.0, "US", 37.090200000000003, -95.712900000000005, "United States", 331893745L }
                });

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("2be547f5-a3f7-4a98-9fe1-7e6a53fc939d"), "Hard" },
                    { new Guid("2e9761ff-290c-4284-80fc-355f07c4b18c"), "Medium" },
                    { new Guid("e94f43fb-f617-494b-80f7-ab04a9d8a866"), "Easy" }
                });
        }
    }
}
