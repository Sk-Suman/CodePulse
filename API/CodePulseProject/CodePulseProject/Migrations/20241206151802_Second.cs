using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulseProject.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogspost",
                table: "Blogspost");

            migrationBuilder.RenameTable(
                name: "Blogspost",
                newName: "Blogsposts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogsposts",
                table: "Blogsposts",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogsposts",
                table: "Blogsposts");

            migrationBuilder.RenameTable(
                name: "Blogsposts",
                newName: "Blogspost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogspost",
                table: "Blogspost",
                column: "Id");
        }
    }
}
