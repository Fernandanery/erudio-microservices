using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class camisetas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageURL", "name", "Price" },
                values: new object[,]
                {
                    { 12L, "T-Shirt", "Camiseta personagens", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic3.tcdn.com.br%2Fimg%2Fimg_prod%2F906555%2Fcamiseta_cartoon_90_bike_41_1_20201204185144.jpg&tbnid=ZjdvOhHZXfNEJM&vet=12ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ..i&imgrefurl=https%3A%2F%2Fwww.cnshop.com.br%2Fcamiseta-cartoon-90-bike&docid=_SrgGj80pkKFRM&w=802&h=1200&q=camiseta&ved=2ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ", "Camiseta personagens", 69.9m },
                    { 13L, "T-Shirt", "Camiseta super mário", "https://www.camisetasbichopreguica.com.br/media/product/87a/camiseta-super-mario-bros-s-456-a6a.jpg", "Camiseta Mario", 69.9m },
                    { 14L, "T-Shirt", "Camiseta pernalonga", "http://images.tcdn.com.br/img/img_prod/948023/camiseta_pernalonga_3813_variacao_11149_1_a10f6fec8eb39c6100650bf4592d0a03.jpg", "Camiseta Pernalonga", 69.9m },
                    { 15L, "T-Shirt", "Camiseta dolce e gabbana", "https://prettynew.vtexassets.com/arquivos/ids/267017-1200-auto?v=638044049378370000&width=1200&height=auto&aspect=true", "Camiseta Dolce e gabbana", 1000m },
                    { 16L, "T-Shirt", "Camiseta Star Wars", "https://media.camden.es/c/product/camiseta-star-wars-520x520_sheOoi0.jpg", "Camiseta Star Wars", 70m },
                    { 17L, "T-Shirt", "Camiseta Marvel", "https://static.riachuelo.com.br/RCHLO/14547457001/portrait/bd6ed0c3191c2208b92545273c5b25f18e414594.jpg", "Camiseta Marvel", 70m },
                    { 18L, "T-Shirt", "Camiseta DC", "https://static3.tcdn.com.br/img/img_prod/352023/camiseta_masculina_dc_comics_villains_3745_1_20220222135325.jpg", "Camiseta DC", 70m },
                    { 19L, "T-Shirt", "Camiseta Homen Aranha", "https://www.camisetasbichopreguica.com.br/media/product/fd2/camiseta-homem-aranha-7d6.jpg", "Camiseta Homen-Aranha", 70m },
                    { 20L, "T-Shirt", "Camiseta Mulher Maravilha", "https://images.fatum.com.br/site/produtos/39_20903_01.jpg?losslevel=1&v=10.4", "Camiseta Mulher Maravilha", 70m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "CategoryName", "Description", "ImageURL", "name", "Price" },
                values: new object[,]
                {
                    { 2L, "T-Shirt", "Camiseta personagens", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic3.tcdn.com.br%2Fimg%2Fimg_prod%2F906555%2Fcamiseta_cartoon_90_bike_41_1_20201204185144.jpg&tbnid=ZjdvOhHZXfNEJM&vet=12ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ..i&imgrefurl=https%3A%2F%2Fwww.cnshop.com.br%2Fcamiseta-cartoon-90-bike&docid=_SrgGj80pkKFRM&w=802&h=1200&q=camiseta&ved=2ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ", "Camiseta personagens", 69.9m },
                    { 3L, "T-Shirt", "Camiseta super mário", "https://www.camisetasbichopreguica.com.br/media/product/87a/camiseta-super-mario-bros-s-456-a6a.jpg", "Camiseta Mario", 69.9m },
                    { 4L, "T-Shirt", "Camiseta pernalonga", "http://images.tcdn.com.br/img/img_prod/948023/camiseta_pernalonga_3813_variacao_11149_1_a10f6fec8eb39c6100650bf4592d0a03.jpg", "Camiseta Pernalonga", 69.9m },
                    { 5L, "T-Shirt", "Camiseta dolce e gabbana", "https://prettynew.vtexassets.com/arquivos/ids/267017-1200-auto?v=638044049378370000&width=1200&height=auto&aspect=true", "Camiseta Dolce e gabbana", 1000m },
                    { 6L, "T-Shirt", "Camiseta Star Wars", "https://media.camden.es/c/product/camiseta-star-wars-520x520_sheOoi0.jpg", "Camiseta Star Wars", 70m },
                    { 7L, "T-Shirt", "Camiseta Marvel", "https://static.riachuelo.com.br/RCHLO/14547457001/portrait/bd6ed0c3191c2208b92545273c5b25f18e414594.jpg", "Camiseta Marvel", 70m },
                    { 8L, "T-Shirt", "Camiseta DC", "https://static3.tcdn.com.br/img/img_prod/352023/camiseta_masculina_dc_comics_villains_3745_1_20220222135325.jpg", "Camiseta DC", 70m },
                    { 9L, "T-Shirt", "Camiseta Homen Aranha", "https://www.camisetasbichopreguica.com.br/media/product/fd2/camiseta-homem-aranha-7d6.jpg", "Camiseta Homen-Aranha", 70m },
                    { 10L, "T-Shirt", "Camiseta Mulher Maravilha", "https://images.fatum.com.br/site/produtos/39_20903_01.jpg?losslevel=1&v=10.4", "Camiseta Mulher Maravilha", 70m }
                });
        }
    }
}
