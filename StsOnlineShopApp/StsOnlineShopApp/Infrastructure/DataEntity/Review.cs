using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    public class Review : IDataEntity
    {
        public String Id { get; set; }

        public String Author { get; set; }

        public String Comment { get; set; }

        public int Score { get; set; }

        public DateTime CreationDate { get; set; }
        
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
