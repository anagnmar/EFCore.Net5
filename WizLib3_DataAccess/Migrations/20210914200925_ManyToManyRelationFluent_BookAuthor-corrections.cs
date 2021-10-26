using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib3_DataAccess.Migrations
{
    public partial class ManyToManyRelationFluent_BookAuthorcorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Authors_Book_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookAuthor_Author_Id",
                table: "Fluent_BookAuthor",
                column: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthor",
                column: "Author_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookAuthor_Author_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Authors_Book_Id",
                table: "Fluent_BookAuthor",
                column: "Book_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
