using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myapp.Migrations
{
    public partial class AddColumnsRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Tb_Movie",
                type: "char(1)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Tb_Movie");
        }
    }
}
