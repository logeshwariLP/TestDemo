using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenerateCifApi.Migrations
{
    public partial class SeedCifUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CifUser",
                columns: new[] { "CifId", "emailId" },
                values: new object[] { 1, "aaa@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CifUser",
                keyColumn: "CifId",
                keyValue: 1);
        }
    }
}
