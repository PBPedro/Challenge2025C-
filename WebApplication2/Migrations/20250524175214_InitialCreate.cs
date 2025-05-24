using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MT_USUARIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOME = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    SENHA = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MT_USUARIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MTT_MOTO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MARCA = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    MODELO = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    PLACA = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    ESTADO = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LOCAL = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTT_MOTO", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MT_USUARIO");

            migrationBuilder.DropTable(
                name: "MTT_MOTO");
        }
    }
}
