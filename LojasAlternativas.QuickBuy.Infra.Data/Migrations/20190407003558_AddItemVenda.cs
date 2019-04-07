using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojasAlternativas.QuickBuy.Infra.Data.Migrations
{
    public partial class AddItemVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Vendas_VendaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_VendaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Produtos");

            migrationBuilder.CreateTable(
                name: "ItensVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    VendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensVenda_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensVenda_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_ProdutoId",
                table: "ItensVenda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_VendaId",
                table: "ItensVenda",
                column: "VendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensVenda");

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_VendaId",
                table: "Produtos",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Vendas_VendaId",
                table: "Produtos",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
