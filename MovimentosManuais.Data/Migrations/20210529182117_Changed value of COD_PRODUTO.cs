using Microsoft.EntityFrameworkCore.Migrations;

namespace MovimentosManuais.Data.Migrations
{
    public partial class ChangedvalueofCOD_PRODUTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "COD_PRODUTO",
                keyValue: "0001");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "COD_PRODUTO",
                keyValue: "0002");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "COD_PRODUTO",
                keyValue: "0003");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "COD_PRODUTO", "DES_PRODUTO", "STA_STATUS" },
                values: new object[,]
                {
                    { "PROD 001", "DESC 0001", "A" },
                    { "PROD 002", "DESC 0002", "A" },
                    { "PROD 003", "DESC 0003", "A" }
                });

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "07161383013",
                column: "COD_PRODUTO",
                value: "PROD 003");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "14470492094",
                column: "COD_PRODUTO",
                value: "PROD 003");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "25767337004",
                column: "COD_PRODUTO",
                value: "PROD 002");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "38809386019",
                column: "COD_PRODUTO",
                value: "PROD 001");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "42537728033",
                column: "COD_PRODUTO",
                value: "PROD 002");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "48408352091",
                column: "COD_PRODUTO",
                value: "PROD 001");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "COD_PRODUTO",
                keyValue: "PROD 001");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "COD_PRODUTO",
                keyValue: "PROD 002");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "COD_PRODUTO",
                keyValue: "PROD 003");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "COD_PRODUTO", "DES_PRODUTO", "STA_STATUS" },
                values: new object[,]
                {
                    { "0001", "Cadastro do Produto 0001", "A" },
                    { "0002", "Cadastro do Produto 0002", "A" },
                    { "0003", "Cadastro do Produto 0003", "A" }
                });

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "07161383013",
                column: "COD_PRODUTO",
                value: "0003");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "14470492094",
                column: "COD_PRODUTO",
                value: "0003");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "25767337004",
                column: "COD_PRODUTO",
                value: "0002");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "38809386019",
                column: "COD_PRODUTO",
                value: "0001");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "42537728033",
                column: "COD_PRODUTO",
                value: "0002");

            migrationBuilder.UpdateData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "48408352091",
                column: "COD_PRODUTO",
                value: "0001");
        }
    }
}
