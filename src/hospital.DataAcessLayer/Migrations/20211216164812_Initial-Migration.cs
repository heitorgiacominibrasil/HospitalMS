 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospital.DataAcessLayer.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mural",
                columns: table => new
                {
                    Mural_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mural_Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mural_Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mural_Aviso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mural_Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mural_Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mural", x => x.Mural_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mural");
        }
    }
}
