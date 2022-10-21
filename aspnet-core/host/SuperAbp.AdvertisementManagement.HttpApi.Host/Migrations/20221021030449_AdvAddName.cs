using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperAbp.AdvertisementManagement.Migrations
{
    public partial class AdvAddName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SuperAbpAdvertisements",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SuperAbpAdvertisements");
        }
    }
}
