using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBooks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    bookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameBook = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    genreBook = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    authorBook = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    pagesBook = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.bookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
