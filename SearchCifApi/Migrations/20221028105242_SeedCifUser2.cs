using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenerateCifApi.Migrations
{
    public partial class SeedCifUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CifUser",
                columns: new[] { "CifId", "emailId" },
                values: new object[,]
                {
                    { 2, "bbb@test.com" },
                    { 3, "ccc@test.com" },
                    { 4, "ddd@test.com" },
                    { 5, "eee@test.com" },
                    { 6, "fff@test.com" },
                    { 7, "ggg@test.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 7);
        }
    }
}
