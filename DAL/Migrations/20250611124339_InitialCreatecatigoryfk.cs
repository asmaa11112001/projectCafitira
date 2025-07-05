using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatecatigoryfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatigoryId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_products_CatigoryId",
                table: "products",
                column: "CatigoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Cateigorys_CatigoryId",
                table: "products",
                column: "CatigoryId",
                principalTable: "Cateigorys",
                principalColumn: "CatigoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Cateigorys_CatigoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CatigoryId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CatigoryId",
                table: "products");
        }
    }
}
