using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    // Value Object
    public class CartId
    {
        public readonly String cartId;

        public CartId()
        {
            this.cartId = System.Guid.NewGuid().ToString();
        }
    }
}
