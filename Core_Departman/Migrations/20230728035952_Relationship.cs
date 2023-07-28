using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Departman.Migrations
{
    /// <inheritdoc />
    public partial class Relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartId",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartId",
                table: "Personels",
                column: "DepartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_DepartId",
                table: "Personels",
                column: "DepartId",
                principalTable: "Departmans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_DepartId",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "DepartId",
                table: "Personels");
        }
    }
}
