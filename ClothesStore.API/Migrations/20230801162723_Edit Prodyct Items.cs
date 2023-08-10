using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesStore.API.Migrations
{
    /// <inheritdoc />
    public partial class EditProdyctItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    nomenclature_number = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    category = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_items");
        }
    }
}
