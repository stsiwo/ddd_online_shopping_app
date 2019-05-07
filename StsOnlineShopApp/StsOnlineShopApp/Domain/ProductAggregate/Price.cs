using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class Price
    {
        public readonly Decimal price;

        public Price(Decimal price)
        {
            this.price = price;
        }
    }
}
