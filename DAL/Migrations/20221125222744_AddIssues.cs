using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Issue_Unit_UnitId1",
                        column: x => x.UnitId1,
                        principalTable: "Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Issue",
                columns: new[] { "Id", "Title", "UnitId1" },
                values: new object[] { 1, "Repair", null });

            migrationBuilder.InsertData(
                table: "Issue",
                columns: new[] { "Id", "Title", "UnitId1" },
                values: new object[] { 2, "Repair", null });

            migrationBuilder.InsertData(
                table: "Issue",
                columns: new[] { "Id", "Title", "UnitId1" },
                values: new object[] { 3, "Repair", null });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_UnitId1",
                table: "Issue",
                column: "UnitId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");
        }
    }
}
