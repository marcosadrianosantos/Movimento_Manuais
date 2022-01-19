using Microsoft.EntityFrameworkCore.Migrations;

namespace MovimentosManuais.Data.Migrations
{
    public partial class AddedparameterstoProdutoandCosif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "COD_PRODUTO", "DES_PRODUTO", "STA_STATUS" },
                values: new object[,]
                {
                    { "0001", "Cadastro do Produto 0001", "A" },
                    { "0002", "Cadastro do Produto 0002", "A" },
                    { "0003", "Cadastro do Produto 0003", "A" }
                });

            migrationBuilder.InsertData(
                table: "ProdutosCosifs",
                columns: new[] { "COD_COSIF", "COD_CLASSIFICACAO", "COD_PRODUTO", "ProdutoCOD_PRODUTO", "STA_STATUS" },
                values: new object[,]
                {
                    { "48408352091", "", "0001", null, "A" },
                    { "42537728033", "", "0002", null, "A" },
                    { "07161383013", "", "0003", null, "A" },
                    { "14470492094", "", "0003", null, "A" },
                    { "25767337004", "", "0002", null, "A" },
                    { "38809386019", "", "0001", null, "A" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "07161383013");

            migrationBuilder.DeleteData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "14470492094");

            migrationBuilder.DeleteData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "25767337004");

            migrationBuilder.DeleteData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "38809386019");

            migrationBuilder.DeleteData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "42537728033");

            migrationBuilder.DeleteData(
                table: "ProdutosCosifs",
                keyColumn: "COD_COSIF",
                keyValue: "48408352091");
        }
    }
}
