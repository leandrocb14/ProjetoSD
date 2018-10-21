using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoSD.WebAPI.Migrations
{
    public partial class CreateTableMedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TMED",
                columns: table => new
                {
                    CMEDCRM = table.Column<int>(nullable: false),
                    CMEDNOME = table.Column<string>(maxLength: 90, nullable: false),
                    CMEDUF = table.Column<string>(nullable: false),
                    CMEDPROFISSAO = table.Column<string>(maxLength: 90, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMED", x => x.CMEDCRM);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TMED_CMEDCRM",
                table: "TMED",
                column: "CMEDCRM",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TMED");
        }
    }
}
