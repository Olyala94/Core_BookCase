using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Departman.Migrations
{
    /// <inheritdoc />
    public partial class Add_Detail_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Departmans",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Departmans");
        }
    }
}
