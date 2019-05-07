using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class ProductId
    {
        public readonly String productId;

        public ProductId()
        {
            this.productId = System.Guid.NewGuid().ToString();
        }

    }
}
