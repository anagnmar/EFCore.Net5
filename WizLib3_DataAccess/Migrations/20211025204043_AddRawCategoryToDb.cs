using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib3_DataAccess.Migrations
{
    public partial class AddRawCategoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES ('Cat 1'), ('Cat 2'), ('Cat 3')");


            //  OR

            //  migrationBuilder.Sql("INSERT INTO tbl_category VALUES ('Cat 1')");
            //  migrationBuilder.Sql("INSERT INTO tbl_category VALUES ('Cat 2')");
            //  migrationBuilder.Sql("INSERT INTO tbl_category VALUES ('Cat 3')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
