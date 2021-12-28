using Microsoft.EntityFrameworkCore.Migrations;

namespace jkhkhkuhuh.Migrations
{
    public partial class wwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "ntext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tittle",
                table: "Blogs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tittle",
                table: "Blogs");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext");
        }
    }
}
