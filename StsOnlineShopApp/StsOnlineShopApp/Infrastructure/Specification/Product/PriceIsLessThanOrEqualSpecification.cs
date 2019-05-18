using System;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using System.Linq.Expressions;

namespace StsOnlineShopApp.Infrastructure.Specification.Product
{
    public class PriceIsLessThanOrEqualSpecification : CompositeSpecification<DataEntity.Product>
    {
        private readonly decimal _MinPrice;

        public PriceIsLessThanOrEqualSpecification(decimal minPrice)
        {
            this._MinPrice = minPrice;
        }
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => product.Price <= this._MinPrice;
        }
    }
}
