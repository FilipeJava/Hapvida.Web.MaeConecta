using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hapvida.Web.MaeConecta.Migrations
{
    /// <inheritdoc />
    public partial class bancoV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Tbl_procedimento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_procedimento_UsuarioId",
                table: "Tbl_procedimento",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_procedimento_Tbl_usuario_UsuarioId",
                table: "Tbl_procedimento",
                column: "UsuarioId",
                principalTable: "Tbl_usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_procedimento_Tbl_usuario_UsuarioId",
                table: "Tbl_procedimento");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_procedimento_UsuarioId",
                table: "Tbl_procedimento");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Tbl_procedimento");
        }
    }
}
