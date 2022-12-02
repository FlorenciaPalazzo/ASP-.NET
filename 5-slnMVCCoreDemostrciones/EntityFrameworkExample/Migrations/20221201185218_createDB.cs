using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkExample.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Address", "City", "FirstName", "LastName" },
                values: new object[] { 1, "317 Long Street", "Ocala", "Tara", "Brewer" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Address", "City", "FirstName", "LastName" },
                values: new object[] { 2, "3163 Nickel Road", "Anaheim", "Andrew", "Tippett" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
