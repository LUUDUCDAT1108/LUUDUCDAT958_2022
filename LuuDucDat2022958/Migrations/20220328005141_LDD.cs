using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuuDucDat2022958.Migrations
{
    public partial class LDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LDD0958",
                columns: table => new
                {
                    LDDid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LDDName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LDDGender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LDD0958", x => x.LDDid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LDD0958");
        }
    }
}
