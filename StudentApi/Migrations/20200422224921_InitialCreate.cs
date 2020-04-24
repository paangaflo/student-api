using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Career = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Career", "FirstName", "LastName", "Username" },
                values: new object[] { 1, 24, "Systems engineer", "Juan", "Montoya", "juan.montoya" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Career", "FirstName", "LastName", "Username" },
                values: new object[] { 2, 23, "Systems engineer", "Juan", "Moreno", "juan.moreno" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Career", "FirstName", "LastName", "Username" },
                values: new object[] { 3, 19, "Public Health Administration", "Sara", "Cardona", "sara.carmona" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Career", "FirstName", "LastName", "Username" },
                values: new object[] { 4, 22, "Public Health Administration", "Stasy", "Castro", "stasy.castro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
