using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    [Table("review")]
    public class Review : IDataEntity
    {
        [Key]
        [Column("id", TypeName = "uuid")]
        public String Id { get; set; }

        [Required]
        [Column("author")]
        public String Author { get; set; }

        [Required]
        [Column("author")]
        public String Comment { get; set; }

        [Required]
        [Column("score")]
        public int Score { get; set; }
        
        [Required]
        [Column("product_id", TypeName = "uuid")]
        public String ProductId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("creation_date", TypeName = "timestamp with time zone")]
        public DateTime CreationDate { get; set; }
        
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
