using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using StsOnlineShopApp.Infrastructure.DataEntity;
using StsOnlineShopApp.Infrastructure.Specification;
using ProductAggregate = StsOnlineShopApp.Domain.ProductAggregate;

namespace StsOnlineShopApp.Infrastructure.QueryBuilder
{
    public class ProductQueryBuilder : IQueryBuilder<Product>
    {
        private readonly ISpecificationBuilder<Product> _SpecificationBuilder;

        private IQueryable<Product> _Query;

        public ProductQueryBuilder(ISpecificationBuilder<Product> specificationBuilder)
        {
            this._SpecificationBuilder = specificationBuilder;
        }
        public List<Product> Build(AppDbContext appDbContext, Dictionary<string, StringValues> qs = null) 
        {
            this._Query = appDbContext.Products
                .Include(p => p.SubImages)
                .Include(p => p.Reviews).AsQueryable();

            if (qs.Keys.Intersect(ProductAggregate.QueryTypeEnum.ToList()).Count() > 0)
                this._Query = this._Query.Where(this._SpecificationBuilder.Build(qs)).AsQueryable();

            if (qs.ContainsKey(ProductAggregate.QueryTypeEnum.Sort))
                this._Query = BuildOrderByClause(qs);

            return this._Query.ToList();
        }

        private IQueryable<Product> BuildOrderByClause(Dictionary<string, StringValues> qs)
        {
            {
                switch (Convert.ToInt16(qs[ProductAggregate.QueryTypeEnum.Sort]))
                {
                    case (int) ProductAggregate.SortTypeEnum.DateAsc:
                        return this._Query.OrderBy(p => p.CreationDate); 
                    case (int) ProductAggregate.SortTypeEnum.DateDesc:
                        return this._Query.OrderByDescending(p => p.CreationDate); 
                    case (int) ProductAggregate.SortTypeEnum.PriceAsc:
                        return this._Query.OrderBy(p => p.Price); 
                    case (int) ProductAggregate.SortTypeEnum.PriceDesc:
                        return this._Query.OrderByDescending(p => p.Price); 
                    case (int) ProductAggregate.SortTypeEnum.NameAsc:
                        return this._Query.OrderBy(p => p.Name); 
                    case (int) ProductAggregate.SortTypeEnum.NameDesc:
                        return this._Query.OrderByDescending(p => p.Name); 
                    case (int) ProductAggregate.SortTypeEnum.ReviewAsc:
                        return this._Query.OrderBy(p => p.Reviews.Count); 
                    case (int) ProductAggregate.SortTypeEnum.ReviewDesc:
                        return this._Query.OrderByDescending(p => p.Reviews.Count); 
                    case (int) ProductAggregate.SortTypeEnum.ReviewScoreAsc:
                        return this._Query.OrderBy(p => p.Reviews.Average(r => r.Score)); 
                    case (int) ProductAggregate.SortTypeEnum.ReviewScoreDesc:
                        return this._Query.OrderByDescending(p => p.Reviews.Average(r => r.Score)); 
                    default:
                        // if sort value is anything else than above just return defualt (DateAsc) 
                        return this._Query.OrderBy(p => p.CreationDate); 
                }
            }
        } 
    }
}
