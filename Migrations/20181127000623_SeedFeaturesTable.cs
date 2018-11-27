using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedFeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('AWD')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Sun Roof')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Automatic Transmission')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Hybrid')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Power Steering')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features WHERE Name IN ('AWD','Sun Roof','Automatic Transmission','Hybrid','Power Steering')");
        }
    }
}
