using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class Product
    {
        public ProductId ProductId { get; }

        public Name Name { get; set; }
        public Description Description { get; set; }
        public MainImage MainImage { get; set; }
        public HashSet<SubImage> SubImageList { get; set; }
        public Price Price { get; set; }
        public List<Review> ReviewList { get; set; }

    }
}
