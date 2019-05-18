using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using DataEntity = StsOnlineShopApp.Infrastructure.DataEntity;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using StsOnlineShopApp.Domain.ProductAggregate;
using StsOnlineShopApp.Infrastructure.Specification.Product;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public class ProductSpecificationBuilder : SpecificationBuilder<DataEntity.Product>
    {
        public ProductSpecificationBuilder(ISpecification<DataEntity.Product> specification) : base(specification)
        {

        }
        public override Func<DataEntity.Product, bool> Build(Dictionary<string, StringValues> qs)
        {
            // 1. map query string dictionary with specification
            foreach (KeyValuePair<string, StringValues> query in qs)
            {
                if (query.Key.Equals(QueryTypeEnum.KeyWord)) 
                {
                    this._BaseSpecification.And(new IncludeKeyWordSpecification(query.Value));
                }
                else if (query.Key.Equals(QueryTypeEnum.MaxPrice))
                {
                    this._BaseSpecification.And(new PriceIsMoreThanOrEqualSpecification(Convert.ToDecimal(query.Value.ToString())));
                }
                else if (query.Key.Equals(QueryTypeEnum.MinPrice))
                {
                    this._BaseSpecification.And(new PriceIsLessThanOrEqualSpecification(Convert.ToDecimal(query.Value.ToString())));
                }
                else if (query.Key.Equals(QueryTypeEnum.ReviewScore))
                {
                    this._BaseSpecification.And(new IncludeReviewScoreSpecification((ScoreTypeEnum) Enum.Parse(typeof(ScoreTypeEnum), query.Value)));
                }
            }

            // 2. compile to Delegate
            return this._BaseSpecification.CompileToDelegate();

        }

    }
}
