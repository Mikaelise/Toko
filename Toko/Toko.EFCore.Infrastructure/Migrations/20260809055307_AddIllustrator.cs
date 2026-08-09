using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Toko.EFCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIllustrator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Illustrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Socials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSFW = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illustrators", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Illustrators");
        }
    }
}
