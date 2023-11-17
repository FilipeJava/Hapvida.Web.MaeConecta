using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hapvida.Web.MaeConecta.Migrations
{
    /// <inheritdoc />
    public partial class BancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Endereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Endereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_procedimento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ds_tipo = table.Column<int>(type: "int", nullable: false),
                    Ds_especialidade = table.Column<int>(type: "int", nullable: false),
                    Dt_procedimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_procedimento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    SemanaGestacao = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tp_Sangue = table.Column<int>(type: "int", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tbl_usuario_Tbl_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Tbl_Endereco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_contato",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relacionamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_contato", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tbl_contato_Tbl_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tbl_usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ocorrencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_ocorrencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ocorrencia", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tbl_ocorrencia_Tbl_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Tbl_usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_contato_UsuarioId",
                table: "Tbl_contato",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ocorrencia_UsuarioId",
                table: "Tbl_ocorrencia",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_usuario_EnderecoId",
                table: "Tbl_usuario",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_contato");

            migrationBuilder.DropTable(
                name: "Tbl_ocorrencia");

            migrationBuilder.DropTable(
                name: "Tbl_procedimento");

            migrationBuilder.DropTable(
                name: "Tbl_usuario");

            migrationBuilder.DropTable(
                name: "Tbl_Endereco");
        }
    }
}
