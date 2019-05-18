using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    [Table("product")]
    public class Product : IDataEntity
    {
        [Key]
        [Column("id", TypeName = "uuid")]
        public String Id { get; set; }

        [Required]
        [Column("name")]
        public String Name { get; set; }

        [Required]
        [Column("description")]
        public String Description { get; set; }

        [Required]
        [Column("main_image_url")]
        public String MainImageURL { get; set; }

        [Required]
        [Column("sub_category_id")]
        public int SubCategoryId { get; set; }

        [Required]
        [Column("price")]
        public decimal Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("creation_date", TypeName = "timestamp with time zone")]
        public DateTime CreationDate { get; set; }

        public List<SubImage> SubImages  { get; set; }

        public List<Review> Reviews  { get; set; }

        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }
    }
}
