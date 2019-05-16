using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    public class Product
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String MainImageURL { get; set; }
        public List<SubImage> SubImages  { get; set; }
        public decimal Price { get; set; }
        public List<Review> Reviews  { get; set; }
    }
}
