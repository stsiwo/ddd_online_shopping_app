using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using StsOnlineShopApp.Infrastructure.DataEntity;
using System.Linq.Expressions;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public class ProductPriceIsLessThanSpecification : CompositeSpecification<Product>
    {
        private readonly decimal price;

        public ProductPriceIsLessThanSpecification(decimal price)
        {
            this.price = price;
        }
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Price < this.price;
        }
    }
}
