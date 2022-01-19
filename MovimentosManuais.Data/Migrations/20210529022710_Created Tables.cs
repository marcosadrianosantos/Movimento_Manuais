using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovimentosManuais.Data.Migrations
{
    public partial class CreatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    COD_PRODUTO = table.Column<string>(nullable: false),
                    DES_PRODUTO = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    STA_STATUS = table.Column<string>(type: "CHAR(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.COD_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosCosifs",
                columns: table => new
                {
                    COD_COSIF = table.Column<string>(type: "CHAR(11)", nullable: false),
                    COD_PRODUTO = table.Column<string>(nullable: true),
                    COD_CLASSIFICACAO = table.Column<string>(type: "CHAR(6)", nullable: false),
                    STA_STATUS = table.Column<string>(type: "CHAR(1)", nullable: false),
                    ProdutoCOD_PRODUTO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosCosifs", x => x.COD_COSIF);
                    table.ForeignKey(
                        name: "FK_ProdutosCosifs_Produtos_ProdutoCOD_PRODUTO",
                        column: x => x.ProdutoCOD_PRODUTO,
                        principalTable: "Produtos",
                        principalColumn: "COD_PRODUTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovimentosManuais",
                columns: table => new
                {
                    COD_COSIF = table.Column<string>(type: "CHAR(11)", nullable: false),
                    DAT_MES = table.Column<decimal>(type: "NUMERIC(2,0)", nullable: false),
                    DAT_ANO = table.Column<decimal>(type: "NUMERIC(4,0)", nullable: false),
                    NUM_LANCAMENTO = table.Column<decimal>(type: "NUMERIC(18,0)", nullable: false),
                    COD_PRODUTO = table.Column<string>(type: "CHAR(4)", nullable: false),
                    DES_DESCRICAO = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    DAT_MOVIMENTO = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    COD_USUARIO = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    VAL_VALOR = table.Column<decimal>(type: "NUMERIC(18,2)", nullable: false),
                    Produto_CosifCOD_COSIF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentosManuais", x => x.COD_COSIF);
                    table.ForeignKey(
                        name: "FK_MovimentosManuais_ProdutosCosifs_Produto_CosifCOD_COSIF",
                        column: x => x.Produto_CosifCOD_COSIF,
                        principalTable: "ProdutosCosifs",
                        principalColumn: "COD_COSIF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovimentosManuais_Produto_CosifCOD_COSIF",
                table: "MovimentosManuais",
                column: "Produto_CosifCOD_COSIF");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosCosifs_ProdutoCOD_PRODUTO",
                table: "ProdutosCosifs",
                column: "ProdutoCOD_PRODUTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovimentosManuais");

            migrationBuilder.DropTable(
                name: "ProdutosCosifs");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
