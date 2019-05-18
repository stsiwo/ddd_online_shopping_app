using System;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using DataEntity = StsOnlineShopApp.Infrastructure.DataEntity;
using System.Linq.Expressions;

namespace StsOnlineShopApp.Infrastructure.Specification.Product
{
    public class IncludeKeyWordSpecification : CompositeSpecification<DataEntity.Product>
    {
        private readonly String _KeyWord;

        public IncludeKeyWordSpecification(String keyword)
        {
            this._KeyWord = keyword;
        }
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => product.Name.Contains(this._KeyWord) || product.Description.Contains(this._KeyWord) ;
        }
    }
}
