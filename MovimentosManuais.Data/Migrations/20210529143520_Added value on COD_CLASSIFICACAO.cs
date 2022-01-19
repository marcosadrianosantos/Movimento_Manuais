using Microsoft.EntityFrameworkCore.Migrations;

namespace MovimentosManuais.Data.Migrations
{
    public partial class AddedvalueonCOD_CLASSIFICACAO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "07161383013",
                column: "COD_CLASSIFICACAO",
                value: "TESTE3");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "14470492094",
                column: "COD_CLASSIFICACAO",
                value: "TESTE4");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "25767337004",
                column: "COD_CLASSIFICACAO",
                value: "TESTE5");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "38809386019",
                column: "COD_CLASSIFICACAO",
                value: "TESTE6");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "42537728033",
                column: "COD_CLASSIFICACAO",
                value: "TESTE2");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "48408352091",
                column: "COD_CLASSIFICACAO",
                value: "TESTE1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "07161383013",
                column: "COD_CLASSIFICACAO",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "14470492094",
                column: "COD_CLASSIFICACAO",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "25767337004",
                column: "COD_CLASSIFICACAO",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "38809386019",
                column: "COD_CLASSIFICACAO",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "42537728033",
                column: "COD_CLASSIFICACAO",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "48408352091",
                column: "COD_CLASSIFICACAO",
                value: "");
        }
    }
}
