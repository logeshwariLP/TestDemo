using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenerateCifApi.Migrations
{
    public partial class AddCifUserModeltoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CifUser",
                columns: table => new
                {
                    CifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emailId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CifUser", x => x.CifId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CifUser");
        }
    }
}
