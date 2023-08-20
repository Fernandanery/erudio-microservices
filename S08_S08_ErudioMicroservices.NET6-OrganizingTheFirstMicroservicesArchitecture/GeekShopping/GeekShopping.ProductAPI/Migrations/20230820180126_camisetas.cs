using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class camisetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageURL", "name", "Price" },
                values: new object[] { 11L, "T-Shirt", "Camiseta Mickey", "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_mickey_mouse_hug_guilty_of_love_preta_ev_82271_variacao_21301_1_63bd80c55152e569ac0d8affb405ec53.jpg", "Camiseta Mickey", 70m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 11L);
        }
    }
}
