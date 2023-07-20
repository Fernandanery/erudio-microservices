using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Product")] //nome da tabela
    public class Product : BaseEntity
    {
        //Colunas da tabela

        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("Price")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("Description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("CategoryName")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("ImageURL")]
        [StringLength(300)]
        public string ImageURL { get; set; }

    }
}
