using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public class ItsPriceIsMoreThanSpecification : CompositeSpecification<Product>
    {
        private readonly decimal price;

        public ItsPriceIsMoreThanSpecification(decimal price)
        {
            this.price = price;
        }
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Price > this.price;
        }
    }
}
