using Microsoft.EntityFrameworkCore.Migrations;

namespace MovimentosManuais.Data.Migrations
{
    public partial class RemovevaluePRODonCOD_PRODUTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "DES_DESCRICAO",
                table: "MovimentosManuais",
                type: "VARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO",
                table: "MovimentosManuais",
                type: "VARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)");

            migrationBuilder.AlterColumn<string>(
                name: "COD_PRODUTO",
                table: "MovimentosManuais",
                type: "CHAR(4)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(4)");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "COD_PRODUTO", "DES_PRODUTO", "STA_STATUS" },
                values: new object[,]
                {
                    { "0001", "DESC 0001", "A" },
                    { "0002", "DESC 0002", "A" },
                    { "0003", "DESC 0003", "A" }
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

            migrationBuilder.AlterColumn<string>(
                name: "DES_DESCRICAO",
                table: "MovimentosManuais",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO",
                table: "MovimentosManuais",
                type: "VARCHAR(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_PRODUTO",
                table: "MovimentosManuais",
                type: "CHAR(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(4)",
                oldNullable: true);

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
    }
}
