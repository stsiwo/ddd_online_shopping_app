using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    [Table("category")]
    public class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        public String Title { get; set; }

        [Required]
        [Column("description")]
        public String Description { get; set; }

        [Required]
        [Column("image_url")]
        public String ImageURL { get; set; }

        public List<SubCategory> SubCategories  { get; set; }
    }
}
