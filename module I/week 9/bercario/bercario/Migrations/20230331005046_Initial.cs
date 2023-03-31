using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bercario.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Telefone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_medico = table.Column<int>(type: "int", nullable: false),
                    DataParto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioParto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bebe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso_Nascimento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Id_Mae = table.Column<int>(type: "int", nullable: false),
                    Id_Parto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bebe_Mae_Id_Mae",
                        column: x => x.Id_Mae,
                        principalTable: "Mae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bebe_Parto_Id_Parto",
                        column: x => x.Id_Parto,
                        principalTable: "Parto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaeParto",
                columns: table => new
                {
                    MaesId = table.Column<int>(type: "int", nullable: false),
                    PartosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaeParto", x => new { x.MaesId, x.PartosId });
                    table.ForeignKey(
                        name: "FK_MaeParto_Mae_MaesId",
                        column: x => x.MaesId,
                        principalTable: "Mae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaeParto_Parto_PartosId",
                        column: x => x.PartosId,
                        principalTable: "Parto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoParto",
                columns: table => new
                {
                    MedicosId = table.Column<int>(type: "int", nullable: false),
                    PartosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoParto", x => new { x.MedicosId, x.PartosId });
                    table.ForeignKey(
                        name: "FK_MedicoParto_Medico_MedicosId",
                        column: x => x.MedicosId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoParto_Parto_PartosId",
                        column: x => x.PartosId,
                        principalTable: "Parto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Id_Mae",
                table: "Bebe",
                column: "Id_Mae");

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Id_Parto",
                table: "Bebe",
                column: "Id_Parto");

            migrationBuilder.CreateIndex(
                name: "IX_MaeParto_PartosId",
                table: "MaeParto",
                column: "PartosId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoParto_PartosId",
                table: "MedicoParto",
                column: "PartosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebe");

            migrationBuilder.DropTable(
                name: "MaeParto");

            migrationBuilder.DropTable(
                name: "MedicoParto");

            migrationBuilder.DropTable(
                name: "Mae");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Parto");
        }
    }
}
