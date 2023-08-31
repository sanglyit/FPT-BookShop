using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPT_Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class library : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "CartItem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "CartItem",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
