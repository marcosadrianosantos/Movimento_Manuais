using Microsoft.EntityFrameworkCore.Migrations;

namespace MovimentosManuais.Data.Migrations
{
    public partial class Changekeysincompositekeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovimentosManuais_ProdutosCosifs_Produto_CosifCOD_COSIF",
                table: "MovimentosManuais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovimentosManuais",
                table: "MovimentosManuais");

            migrationBuilder.DropIndex(
                name: "IX_MovimentosManuais_Produto_CosifCOD_COSIF",
                table: "MovimentosManuais");

            migrationBuilder.DropColumn(
                name: "Produto_CosifCOD_COSIF",
                table: "MovimentosManuais");

            migrationBuilder.AlterColumn<string>(
                name: "COD_PRODUTO",
                table: "MovimentosManuais",
                type: "CHAR(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(4)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovimentosManuais",
                table: "MovimentosManuais",
                columns: new[] { "DAT_ANO", "DAT_MES", "NUM_LANCAMENTO", "COD_PRODUTO", "COD_COSIF" });

            migrationBuilder.CreateIndex(
                name: "IX_MovimentosManuais_COD_COSIF",
                table: "MovimentosManuais",
                column: "COD_COSIF");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimentosManuais_ProdutosCosifs_COD_COSIF",
                table: "MovimentosManuais",
                column: "COD_COSIF",
                principalTable: "ProdutosCosifs",
                principalColumn: "COD_COSIF",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovimentosManuais_ProdutosCosifs_COD_COSIF",
                table: "MovimentosManuais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovimentosManuais",
                table: "MovimentosManuais");

            migrationBuilder.DropIndex(
                name: "IX_MovimentosManuais_COD_COSIF",
                table: "MovimentosManuais");

            migrationBuilder.AlterColumn<string>(
                name: "COD_PRODUTO",
                table: "MovimentosManuais",
                type: "CHAR(4)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(4)");

            migrationBuilder.AddColumn<string>(
                name: "Produto_CosifCOD_COSIF",
                table: "MovimentosManuais",
                type: "CHAR(11)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovimentosManuais",
                table: "MovimentosManuais",
                column: "COD_COSIF");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentosManuais_Produto_CosifCOD_COSIF",
                table: "MovimentosManuais",
                column: "Produto_CosifCOD_COSIF");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimentosManuais_ProdutosCosifs_Produto_CosifCOD_COSIF",
                table: "MovimentosManuais",
                column: "Produto_CosifCOD_COSIF",
                principalTable: "ProdutosCosifs",
                principalColumn: "COD_COSIF",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
