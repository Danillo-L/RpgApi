using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 58, 197, 193, 91, 12, 21, 164, 172, 244, 223, 102, 21, 80, 254, 236, 190, 81, 193, 44, 201, 238, 21, 197, 116, 171, 210, 73, 11, 157, 153, 142, 198, 118, 150, 112, 125, 184, 136, 110, 40, 71, 5, 103, 198, 126, 60, 115, 241, 195, 135, 195, 188, 41, 23, 193, 66, 254, 23, 55, 21, 162, 97, 9, 26 }, new byte[] { 86, 67, 249, 77, 164, 67, 48, 123, 55, 211, 99, 111, 2, 112, 62, 84, 107, 128, 237, 185, 132, 45, 188, 49, 29, 171, 192, 49, 160, 77, 114, 103, 211, 96, 28, 216, 7, 187, 162, 183, 229, 157, 182, 4, 253, 138, 157, 80, 37, 128, 219, 123, 251, 160, 163, 255, 125, 15, 157, 241, 171, 110, 221, 231, 57, 247, 99, 190, 205, 199, 208, 0, 122, 208, 209, 90, 255, 171, 73, 144, 119, 9, 241, 50, 30, 204, 199, 184, 160, 230, 111, 216, 222, 92, 74, 24, 109, 173, 252, 46, 50, 190, 85, 242, 138, 118, 248, 70, 2, 233, 142, 221, 178, 251, 17, 170, 77, 137, 208, 0, 232, 88, 9, 255, 240, 192, 36, 187 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 16, 230, 57, 41, 157, 5, 4, 103, 247, 150, 65, 224, 216, 7, 185, 64, 110, 47, 94, 31, 196, 180, 72, 186, 54, 87, 192, 97, 41, 21, 98, 116, 82, 5, 36, 85, 169, 221, 42, 194, 179, 10, 245, 254, 253, 206, 244, 23, 165, 108, 72, 117, 218, 231, 102, 79, 51, 49, 170, 111, 81, 195, 248 }, new byte[] { 231, 164, 199, 82, 27, 66, 185, 124, 16, 44, 48, 5, 229, 154, 3, 101, 212, 29, 124, 82, 82, 114, 78, 231, 29, 74, 128, 54, 39, 31, 229, 131, 238, 28, 30, 85, 124, 77, 219, 115, 89, 2, 39, 179, 147, 131, 124, 69, 175, 246, 220, 104, 180, 159, 17, 160, 34, 148, 178, 143, 217, 215, 215, 233, 8, 144, 35, 78, 56, 151, 45, 62, 214, 165, 181, 15, 148, 253, 99, 163, 138, 38, 38, 188, 66, 144, 84, 138, 140, 189, 70, 194, 204, 204, 83, 21, 79, 81, 186, 227, 91, 150, 230, 131, 21, 120, 43, 2, 97, 192, 48, 216, 71, 27, 229, 81, 192, 215, 135, 17, 123, 84, 78, 224, 183, 70, 148, 21 } });
        }
    }
}
