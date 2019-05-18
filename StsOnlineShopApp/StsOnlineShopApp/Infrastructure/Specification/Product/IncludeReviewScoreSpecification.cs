using System;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using DataEntity = StsOnlineShopApp.Infrastructure.DataEntity;
using System.Linq.Expressions;
using System.Linq;
using StsOnlineShopApp.Domain.ProductAggregate;

namespace StsOnlineShopApp.Infrastructure.Specification.Product
{
    public class IncludeReviewScoreSpecification : CompositeSpecification<DataEntity.Product>
    {
        private readonly ScoreTypeEnum _Score;

        public IncludeReviewScoreSpecification(ScoreTypeEnum score)
        {
            this._Score = score;
        }
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => Convert.ToInt16(product.Reviews.Average(r => r.Score)) == (int) this._Score;
        }
    }
}
