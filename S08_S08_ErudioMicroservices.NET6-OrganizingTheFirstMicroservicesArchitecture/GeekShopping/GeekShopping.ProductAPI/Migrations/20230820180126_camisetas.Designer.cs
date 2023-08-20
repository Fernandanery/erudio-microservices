﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20230820180126_camisetas")]
    partial class camisetas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CategoryName");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("Description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("ImageURL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("Price");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta personagens",
                            ImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic3.tcdn.com.br%2Fimg%2Fimg_prod%2F906555%2Fcamiseta_cartoon_90_bike_41_1_20201204185144.jpg&tbnid=ZjdvOhHZXfNEJM&vet=12ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ..i&imgrefurl=https%3A%2F%2Fwww.cnshop.com.br%2Fcamiseta-cartoon-90-bike&docid=_SrgGj80pkKFRM&w=802&h=1200&q=camiseta&ved=2ahUKEwj1ueiY3uuAAxWgg5UCHfZMDMcQMygJegUIARCNAQ",
                            Name = "Camiseta personagens",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta super mário",
                            ImageURL = "https://www.camisetasbichopreguica.com.br/media/product/87a/camiseta-super-mario-bros-s-456-a6a.jpg",
                            Name = "Camiseta Mario",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta pernalonga",
                            ImageURL = "http://images.tcdn.com.br/img/img_prod/948023/camiseta_pernalonga_3813_variacao_11149_1_a10f6fec8eb39c6100650bf4592d0a03.jpg",
                            Name = "Camiseta Pernalonga",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta dolce e gabbana",
                            ImageURL = "https://prettynew.vtexassets.com/arquivos/ids/267017-1200-auto?v=638044049378370000&width=1200&height=auto&aspect=true",
                            Name = "Camiseta Dolce e gabbana",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta Star Wars",
                            ImageURL = "https://media.camden.es/c/product/camiseta-star-wars-520x520_sheOoi0.jpg",
                            Name = "Camiseta Star Wars",
                            Price = 70m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta Marvel",
                            ImageURL = "https://static.riachuelo.com.br/RCHLO/14547457001/portrait/bd6ed0c3191c2208b92545273c5b25f18e414594.jpg",
                            Name = "Camiseta Marvel",
                            Price = 70m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta DC",
                            ImageURL = "https://static3.tcdn.com.br/img/img_prod/352023/camiseta_masculina_dc_comics_villains_3745_1_20220222135325.jpg",
                            Name = "Camiseta DC",
                            Price = 70m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta Homen Aranha",
                            ImageURL = "https://www.camisetasbichopreguica.com.br/media/product/fd2/camiseta-homem-aranha-7d6.jpg",
                            Name = "Camiseta Homen-Aranha",
                            Price = 70m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta Mulher Maravilha",
                            ImageURL = "https://images.fatum.com.br/site/produtos/39_20903_01.jpg?losslevel=1&v=10.4",
                            Name = "Camiseta Mulher Maravilha",
                            Price = 70m
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "T-Shirt",
                            Description = "Camiseta Mickey",
                            ImageURL = "https://static3.tcdn.com.br/img/img_prod/460977/camiseta_masculina_unissex_mickey_mouse_hug_guilty_of_love_preta_ev_82271_variacao_21301_1_63bd80c55152e569ac0d8affb405ec53.jpg",
                            Name = "Camiseta Mickey",
                            Price = 70m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
