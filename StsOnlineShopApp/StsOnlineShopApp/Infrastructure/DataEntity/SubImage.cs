using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    [Table("sub_image")]
    public class SubImage : IDataEntity
    {
        [Key]
        [Column("id", TypeName = "uuid")]
        public String Id { get; set; }

        [Required]
        [Column("url")]
        public String Url { get; set; }

        [Required]
        [Column("product_id", TypeName = "uuid")]
        public int ProductId  { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
