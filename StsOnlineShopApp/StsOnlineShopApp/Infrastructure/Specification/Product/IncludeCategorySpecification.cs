using StsOnlineShopApp.Infrastructure.Specification.Core;
using System;
using System.Linq;
using System.Linq.Expressions;
using StsOnlineShopApp.Domain.ProductAggregate;

namespace StsOnlineShopApp.Infrastructure.Specification.Product
{
    public class IncludeCategorySpecification : CompositeSpecification<DataEntity.Product>
    {
        private readonly CategoryTypeEnum _CategoryType;

        public IncludeCategorySpecification(CategoryTypeEnum categoryType)
        {
            this._CategoryType = categoryType;
        }
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => product.SubCategory.Category.Id ==  this._CategoryType; 
        }
    }
}
