using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StsOnlineShopApp.Application;
using DTO = StsOnlineShopApp.UI.DTO;
using AutoMapper;
using StsOnlineShopApp.Infrastructure.QueryBuilder;
using DataEntity = StsOnlineShopApp.Infrastructure.DataEntity;
using Microsoft.Extensions.Primitives;

namespace StsOnlineShopApp.Infrastructure.Repository
{
    /**
     * #TASK: 
     *  1. inject DbContext per request
     *  2. integrate with Specification Pattern
     *  3. unit test
     **/

    /**
     * CAVEATS: 
     *  1. DON'T use IEnumerable or IQueryable as return type. just use "ToList". 
     *      => this is for mapping to DTO object
     **/
    public class ProductRepository : IProductRepository
    {
        // inject per request 
        private readonly AppDbContext _Context;

        // inject per request 
        private readonly IMapper _Mapper;

        // inject per request
        private readonly IQueryBuilder<DataEntity.Product> _QueryBuilder; 

        public ProductRepository(AppDbContext context, IMapper mapper)
        {
            this._Context = context;
        }
        public List<DTO.Product> getAllProducts()
        {
            // 1. get Products from DbContext
            List<DataEntity.Product> results = this._QueryBuilder.Build(this._Context);

            // 2. assign results to List<Product> DTO
            List<DTO.Product> products = this._Mapper.Map<List<DTO.Product>>(results);

            // 3. return it!!
            return products;
        }

        public List<DTO.Product> getProducts(Dictionary<string, StringValues> qs)
        {
            // 1. get Products from DbContext
            List<DataEntity.Product> results = this._QueryBuilder.Build(this._Context, qs);

            // 2. assign results to List<Product> DTO
            List<DTO.Product> products = this._Mapper.Map<List<DTO.Product>>(results);

            // 3. return it!!
            return products;
        }
    }
}
