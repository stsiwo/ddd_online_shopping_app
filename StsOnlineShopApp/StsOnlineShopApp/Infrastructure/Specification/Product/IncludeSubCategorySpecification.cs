using StsOnlineShopApp.Domain.ProductAggregate;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.Specification.Product
{
    public class IncludeSubCategorySpecification : CompositeSpecification<DataEntity.Product>
    {
        private readonly SubCategoryTypeEnum _SubCategoryType;

        public IncludeSubCategorySpecification(SubCategoryTypeEnum subCategoryType)
        {
            this._SubCategoryType = subCategoryType;
        }
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => product.SubCategory.Id ==  this._SubCategoryType; 
        }
    }
}
