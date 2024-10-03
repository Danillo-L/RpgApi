using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldDefaultValue: "Jogador");

            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 70, 255, 133, 219, 155, 70, 172, 124, 86, 193, 54, 182, 221, 210, 192, 126, 63, 157, 176, 236, 68, 98, 77, 72, 219, 34, 189, 42, 192, 164, 33, 46, 30, 82, 248, 149, 4, 235, 107, 113, 180, 216, 49, 211, 167, 234, 120, 89, 18, 226, 95, 215, 172, 9, 189, 235, 217, 212, 218, 76, 237, 121, 202, 204 }, new byte[] { 223, 36, 205, 54, 113, 43, 118, 240, 245, 179, 232, 11, 176, 123, 59, 6, 176, 66, 63, 209, 111, 83, 51, 126, 18, 31, 150, 211, 217, 122, 175, 84, 165, 105, 61, 124, 148, 10, 176, 17, 161, 99, 33, 138, 186, 183, 122, 76, 189, 89, 233, 204, 142, 254, 244, 76, 187, 142, 213, 90, 149, 198, 32, 42, 43, 153, 32, 156, 113, 176, 57, 129, 209, 22, 243, 211, 103, 88, 86, 198, 90, 148, 75, 187, 237, 125, 126, 180, 134, 41, 204, 191, 134, 203, 0, 247, 30, 180, 127, 48, 3, 230, 131, 142, 183, 214, 46, 229, 204, 149, 85, 14, 124, 94, 114, 243, 200, 175, 128, 74, 139, 113, 235, 44, 127, 228, 56, 46 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 58, 197, 193, 91, 12, 21, 164, 172, 244, 223, 102, 21, 80, 254, 236, 190, 81, 193, 44, 201, 238, 21, 197, 116, 171, 210, 73, 11, 157, 153, 142, 198, 118, 150, 112, 125, 184, 136, 110, 40, 71, 5, 103, 198, 126, 60, 115, 241, 195, 135, 195, 188, 41, 23, 193, 66, 254, 23, 55, 21, 162, 97, 9, 26 }, new byte[] { 86, 67, 249, 77, 164, 67, 48, 123, 55, 211, 99, 111, 2, 112, 62, 84, 107, 128, 237, 185, 132, 45, 188, 49, 29, 171, 192, 49, 160, 77, 114, 103, 211, 96, 28, 216, 7, 187, 162, 183, 229, 157, 182, 4, 253, 138, 157, 80, 37, 128, 219, 123, 251, 160, 163, 255, 125, 15, 157, 241, 171, 110, 221, 231, 57, 247, 99, 190, 205, 199, 208, 0, 122, 208, 209, 90, 255, 171, 73, 144, 119, 9, 241, 50, 30, 204, 199, 184, 160, 230, 111, 216, 222, 92, 74, 24, 109, 173, 252, 46, 50, 190, 85, 242, 138, 118, 248, 70, 2, 233, 142, 221, 178, 251, 17, 170, 77, 137, 208, 0, 232, 88, 9, 255, 240, 192, 36, 187 } });
        }
    }
}
