using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trululu.web.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "castings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(nullable: true),
                    age_min = table.Column<int>(nullable: false),
                    age_max = table.Column<int>(nullable: false),
                    description_poste = table.Column<string>(nullable: true),
                    description_profil = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_castings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "civilite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_civilite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "entreprises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(nullable: true),
                    telephone = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entreprises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "utilisateurs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prenom = table.Column<string>(nullable: true),
                    nom = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    telephone = table.Column<string>(nullable: true),
                    dateDeNaissance = table.Column<DateTime>(nullable: false),
                    motDePasse = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utilisateurs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "castings");

            migrationBuilder.DropTable(
                name: "civilite");

            migrationBuilder.DropTable(
                name: "entreprises");

            migrationBuilder.DropTable(
                name: "utilisateurs");
        }
    }
}
