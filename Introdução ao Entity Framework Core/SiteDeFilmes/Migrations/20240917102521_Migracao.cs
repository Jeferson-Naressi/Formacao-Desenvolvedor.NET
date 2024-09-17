using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteDeFilmes.Migrations
{
    /// <inheritdoc />
    public partial class Migracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimeiroNome = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    UltimoNome = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Genero = table.Column<string>(type: "VARCHAR(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElencoFilmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAtor = table.Column<int>(type: "int", nullable: false),
                    IdFilmes = table.Column<int>(type: "int", nullable: false),
                    Papel = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElencoFilmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElencoFilmes_Atores_IdAtor",
                        column: x => x.IdAtor,
                        principalTable: "Atores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElencoFilmes_Filmes_IdFilmes",
                        column: x => x.IdFilmes,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmesGeneros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGenero = table.Column<int>(type: "int", nullable: false),
                    IdFilmes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmesGeneros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmesGeneros_Filmes_IdFilmes",
                        column: x => x.IdFilmes,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmesGeneros_Generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElencoFilmes_IdAtor",
                table: "ElencoFilmes",
                column: "IdAtor");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoFilmes_IdFilmes",
                table: "ElencoFilmes",
                column: "IdFilmes");

            migrationBuilder.CreateIndex(
                name: "IX_FilmesGeneros_IdFilmes",
                table: "FilmesGeneros",
                column: "IdFilmes");

            migrationBuilder.CreateIndex(
                name: "IX_FilmesGeneros_IdGenero",
                table: "FilmesGeneros",
                column: "IdGenero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElencoFilmes");

            migrationBuilder.DropTable(
                name: "FilmesGeneros");

            migrationBuilder.DropTable(
                name: "Atores");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
