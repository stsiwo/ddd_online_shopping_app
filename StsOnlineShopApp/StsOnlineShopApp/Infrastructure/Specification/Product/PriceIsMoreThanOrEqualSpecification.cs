using System;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using System.Linq.Expressions;

namespace StsOnlineShopApp.Infrastructure.Specification.Product
{
    public class PriceIsMoreThanOrEqualSpecification : CompositeSpecification<DataEntity.Product>
    {
        private readonly decimal _MaxPrice;

        public PriceIsMoreThanOrEqualSpecification(decimal maxPrice)
        {
            this._MaxPrice = maxPrice;
        }
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => product.Price >= this._MaxPrice;
        }
    }
}
