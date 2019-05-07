using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class ReviewId
    {
        public readonly String reviewId;

        public ReviewId()
        {
            this.reviewId = System.Guid.NewGuid().ToString();
        }
    }
}
