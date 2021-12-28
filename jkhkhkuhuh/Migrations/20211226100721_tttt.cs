using Microsoft.EntityFrameworkCore.Migrations;

namespace jkhkhkuhuh.Migrations
{
    public partial class tttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "BlogCategoryId",
                table: "Blogs",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_BlogCategoryId",
                table: "Blogs",
                newName: "IX_Blogs_Category");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategories_Category",
                table: "Blogs",
                column: "Category",
                principalTable: "BlogCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategories_Category",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Blogs",
                newName: "BlogCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_Category",
                table: "Blogs",
                newName: "IX_Blogs_BlogCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategories_BlogCategoryId",
                table: "Blogs",
                column: "BlogCategoryId",
                principalTable: "BlogCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
