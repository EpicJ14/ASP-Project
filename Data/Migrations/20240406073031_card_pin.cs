using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank4.Data.Migrations
{
    public partial class card_pin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PIN",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PIN",
                table: "Card");
        }
    }
}
