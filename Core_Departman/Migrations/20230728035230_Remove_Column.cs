using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Departman.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Departmans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Departmans",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
