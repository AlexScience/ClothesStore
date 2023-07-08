using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesStore.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    delivery_address = table.Column<string>(type: "varchar", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
