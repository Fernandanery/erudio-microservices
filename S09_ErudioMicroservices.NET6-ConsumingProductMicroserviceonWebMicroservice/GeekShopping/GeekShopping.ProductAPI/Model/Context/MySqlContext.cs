using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Camiseta personagens",
                Price = new decimal(69.90),
                Description = "Camiseta personagens",
                ImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic3.tcdn.com.br%2Fimg%2Fimg_prod%2F906555%2Fcamiseta_cartoon_90_bike_41_1_20201204185144.jpg&tbnid=ZjdvOhHZXfNEJM&vet=12ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ..i&imgrefurl=https%3A%2F%2Fwww.cnshop.com.br%2Fcamiseta-cartoon-90-bike&docid=_SrgGj80pkKFRM&w=802&h=1200&q=camiseta&ved=2ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Camiseta Mario",
                Price = new decimal(69.90),
                Description = "Camiseta super mário",
                ImageURL = "https://www.camisetasbichopreguica.com.br/media/product/87a/camiseta-super-mario-bros-s-456-a6a.jpg",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Camiseta Pernalonga",
                Price = new decimal(69.90),
                Description = "Camiseta pernalonga",
                ImageURL = "http://images.tcdn.com.br/img/img_prod/948023/camiseta_pernalonga_3813_variacao_11149_1_a10f6fec8eb39c6100650bf4592d0a03.jpg",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Camiseta Dolce e gabbana",
                Price = new decimal(1000.00),
                Description = "Camiseta dolce e gabbana",
                ImageURL = "https://prettynew.vtexassets.com/arquivos/ids/267017-1200-auto?v=638044049378370000&width=1200&height=auto&aspect=true",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Camiseta Star Wars",
                Price = new decimal(70.00),
                Description = "Camiseta Star Wars",
                ImageURL = "https://media.camden.es/c/product/camiseta-star-wars-520x520_sheOoi0.jpg",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Camiseta Marvel",
                Price = new decimal(70.00),
                Description = "Camiseta Marvel",
                ImageURL = "https://static.riachuelo.com.br/RCHLO/14547457001/portrait/bd6ed0c3191c2208b92545273c5b25f18e414594.jpg",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Camiseta DC",
                Price = new decimal(70.00),
                Description = "Camiseta DC",
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/352023/camiseta_masculina_dc_comics_villains_3745_1_20220222135325.jpg",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Camiseta Homen-Aranha",
                Price = new decimal(70.00),
                Description = "Camiseta Homen Aranha",
                ImageURL = "https://www.camisetasbichopreguica.com.br/media/product/fd2/camiseta-homem-aranha-7d6.jpg",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Camiseta Mulher Maravilha",
                Price = new decimal(70.00),
                Description = "Camiseta Mulher Maravilha",
                ImageURL = "https://images.fatum.com.br/site/produtos/39_20903_01.jpg?losslevel=1&v=10.4",
                CategoryName = "T-Shirt",
            });
            
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Camiseta Mickey",
                Price = new decimal(70.00),
                Description = "Camiseta Mickey",
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_mickey_mouse_hug_guilty_of_love_preta_ev_82271_variacao_21301_1_63bd80c55152e569ac0d8affb405ec53.jpg",
                CategoryName = "T-Shirt",
            });

        }

    }
}
