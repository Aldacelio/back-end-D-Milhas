using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace back_end_D_Milhas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companhias",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companhias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "depoimentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    texto = table.Column<string>(type: "text", nullable: false),
                    autor = table.Column<string>(type: "text", nullable: false),
                    avatar = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depoimentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estados",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "promocoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    destino = table.Column<string>(type: "text", nullable: false),
                    imagem = table.Column<string>(type: "text", nullable: false),
                    preco = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promocoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "passagens",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo = table.Column<string>(type: "text", nullable: false),
                    precoIda = table.Column<int>(type: "integer", nullable: false),
                    precoVolta = table.Column<int>(type: "integer", nullable: false),
                    taxaEmbarque = table.Column<int>(type: "integer", nullable: false),
                    conexoes = table.Column<int>(type: "integer", nullable: false),
                    tempoVoo = table.Column<int>(type: "integer", nullable: false),
                    origemId = table.Column<int>(type: "integer", nullable: false),
                    destinoId = table.Column<int>(type: "integer", nullable: false),
                    companhiaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passagens", x => x.id);
                    table.ForeignKey(
                        name: "FK_passagens_companhias_companhiaId",
                        column: x => x.companhiaId,
                        principalTable: "companhias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_passagens_estados_destinoId",
                        column: x => x.destinoId,
                        principalTable: "estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_passagens_estados_origemId",
                        column: x => x.origemId,
                        principalTable: "estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    nascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    cpf = table.Column<string>(type: "text", nullable: false),
                    telefone = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    senha = table.Column<string>(type: "text", nullable: false),
                    genero = table.Column<string>(type: "text", nullable: false),
                    cidade = table.Column<string>(type: "text", nullable: false),
                    estadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_estados_estadoId",
                        column: x => x.estadoId,
                        principalTable: "estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_passagens_companhiaId",
                table: "passagens",
                column: "companhiaId");

            migrationBuilder.CreateIndex(
                name: "IX_passagens_destinoId",
                table: "passagens",
                column: "destinoId");

            migrationBuilder.CreateIndex(
                name: "IX_passagens_origemId",
                table: "passagens",
                column: "origemId");

            migrationBuilder.CreateIndex(
                name: "IX_users_estadoId",
                table: "users",
                column: "estadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "depoimentos");

            migrationBuilder.DropTable(
                name: "passagens");

            migrationBuilder.DropTable(
                name: "promocoes");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "companhias");

            migrationBuilder.DropTable(
                name: "estados");
        }
    }
}
