using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    public class SubImage
    {
        public String Id { get; set; }
        public String Url { get; set; }
        public int ProductId  { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
